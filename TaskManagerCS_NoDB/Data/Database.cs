using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.Data.Sqlite;
using TaskManagerCS.Models;
using Task = TaskManagerCS.Models.Task;

namespace TaskManagerCS.Data
{
    public static class Database
    {
        
        private static readonly string DbPath = Path.Combine(
            AppDomain.CurrentDomain.BaseDirectory, "taskmanager.db");

        private static string ConnectionString => $"Data Source={DbPath}";

        
        
        
        public static void Init()
        {
            using var conn = new SqliteConnection(ConnectionString);
            conn.Open();

            var cmd = conn.CreateCommand();
            cmd.CommandText = @"
                CREATE TABLE IF NOT EXISTS users (
                    user_id  INTEGER PRIMARY KEY AUTOINCREMENT,
                    username TEXT    NOT NULL UNIQUE,
                    email    TEXT    NOT NULL UNIQUE,
                    password TEXT    NOT NULL
                );
                CREATE TABLE IF NOT EXISTS tasks (
                    task_id   INTEGER PRIMARY KEY AUTOINCREMENT,
                    taskName  TEXT    NOT NULL,
                    progress  TEXT    NOT NULL,
                    priority  TEXT    NOT NULL,
                    user_id   INTEGER NOT NULL,
                    dueDate   TEXT    NOT NULL DEFAULT '2000-01-01T00:00:00',
                    isTrashed INTEGER NOT NULL DEFAULT 0,
                    FOREIGN KEY (user_id) REFERENCES users(user_id)
                );";
            cmd.ExecuteNonQuery();

            
            try
            {
                var migrationCmd = conn.CreateCommand();
                migrationCmd.CommandText = "ALTER TABLE tasks ADD COLUMN dueDate TEXT NOT NULL DEFAULT '2000-01-01T00:00:00';";
                migrationCmd.ExecuteNonQuery();
            }
            catch (SqliteException)
            {
                
            }

            
            try
            {
                var migrationCmd2 = conn.CreateCommand();
                migrationCmd2.CommandText = "ALTER TABLE tasks ADD COLUMN isTrashed INTEGER NOT NULL DEFAULT 0;";
                migrationCmd2.ExecuteNonQuery();
            }
            catch (SqliteException) { }

            
            try
            {
                var migrationCmd3 = conn.CreateCommand();
                migrationCmd3.CommandText = "ALTER TABLE tasks ADD COLUMN taskType TEXT NOT NULL DEFAULT 'To-Do';";
                migrationCmd3.ExecuteNonQuery();
            }
            catch (SqliteException) { }

            try
            {
                var migrationCmd4 = conn.CreateCommand();
                migrationCmd4.CommandText = "ALTER TABLE tasks ADD COLUMN startTime TEXT;";
                migrationCmd4.ExecuteNonQuery();
            }
            catch (SqliteException) { }

            try
            {
                var migrationCmd5 = conn.CreateCommand();
                migrationCmd5.CommandText = "ALTER TABLE tasks ADD COLUMN endTime TEXT;";
                migrationCmd5.ExecuteNonQuery();
            }
            catch (SqliteException) { }
        }

        
        
        

        
        public static int LoginUser(string usernameOrEmail, string password)
        {
            using var conn = new SqliteConnection(ConnectionString);
            conn.Open();

            var cmd = conn.CreateCommand();
            cmd.CommandText =
                "SELECT user_id, password FROM users WHERE username = $u OR email = $u";
            cmd.Parameters.AddWithValue("$u", usernameOrEmail);

            using var reader = cmd.ExecuteReader();
            if (!reader.HasRows) return -1;   

            reader.Read();
            var storedPass = reader.GetString(1);
            if (storedPass != password) return -1;  

            return reader.GetInt32(0);
        }

        
        public static int SignupUser(string username, string email, string password)
        {
            using var conn = new SqliteConnection(ConnectionString);
            conn.Open();

            
            var check = conn.CreateCommand();
            check.CommandText =
                "SELECT COUNT(*) FROM users WHERE username = $u OR email = $e";
            check.Parameters.AddWithValue("$u", username);
            check.Parameters.AddWithValue("$e", email);
            long count = (long)check.ExecuteScalar()!;
            if (count > 0) return -1;

            
            var insert = conn.CreateCommand();
            insert.CommandText =
                "INSERT INTO users (username, email, password) VALUES ($u, $e, $p)";
            insert.Parameters.AddWithValue("$u", username);
            insert.Parameters.AddWithValue("$e", email);
            insert.Parameters.AddWithValue("$p", password);
            insert.ExecuteNonQuery();

            var getRowId = conn.CreateCommand();
            getRowId.CommandText = "SELECT last_insert_rowid()";
            return (int)(long)getRowId.ExecuteScalar()!;
        }

        
        
        

        public static List<Task> GetTasksForUser(int userId)
        {
            var list = new List<Task>();
            using var conn = new SqliteConnection(ConnectionString);
            conn.Open();

            var cmd = conn.CreateCommand();
            cmd.CommandText =
                "SELECT task_id, taskName, progress, priority, user_id, dueDate, isTrashed, taskType, startTime, endTime FROM tasks WHERE user_id = $uid AND isTrashed = 0";
            cmd.Parameters.AddWithValue("$uid", userId);

            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                list.Add(new Task(
                    reader.GetInt32(0),
                    reader.GetString(1),
                    reader.GetString(2),
                    reader.GetString(3),
                    reader.GetInt32(4),
                    DateTime.Parse(reader.GetString(5)),
                    reader.GetInt32(6) == 1,
                    reader.GetString(7),
                    reader.IsDBNull(8) ? null : DateTime.Parse(reader.GetString(8)),
                    reader.IsDBNull(9) ? null : DateTime.Parse(reader.GetString(9))));
            }
            return list;
        }

        public static int AddTask(string name, string progress, string priority, int userId, DateTime dueDate, string taskType = "To-Do", DateTime? startTime = null, DateTime? endTime = null)
        {
            using var conn = new SqliteConnection(ConnectionString);
            conn.Open();

            var cmd = conn.CreateCommand();
            cmd.CommandText =
                "INSERT INTO tasks (taskName, progress, priority, user_id, dueDate, taskType, startTime, endTime) VALUES ($n, $pr, $p, $u, $d, $type, $st, $et)";
            cmd.Parameters.AddWithValue("$n", name);
            cmd.Parameters.AddWithValue("$pr", progress);
            cmd.Parameters.AddWithValue("$p", priority);
            cmd.Parameters.AddWithValue("$u", userId);
            cmd.Parameters.AddWithValue("$d", dueDate.ToString("o"));
            cmd.Parameters.AddWithValue("$type", taskType);
            cmd.Parameters.AddWithValue("$st", startTime?.ToString("o") ?? (object)DBNull.Value);
            cmd.Parameters.AddWithValue("$et", endTime?.ToString("o") ?? (object)DBNull.Value);
            cmd.ExecuteNonQuery();

            var getRowId = conn.CreateCommand();
            getRowId.CommandText = "SELECT last_insert_rowid()";
            return (int)(long)getRowId.ExecuteScalar()!;
        }

        public static void UpdateTask(int taskId, int userId, string name, string progress, string priority, DateTime dueDate, string taskType = "To-Do", DateTime? startTime = null, DateTime? endTime = null)
        {
            using var conn = new SqliteConnection(ConnectionString);
            conn.Open();

            var cmd = conn.CreateCommand();
            cmd.CommandText =
                "UPDATE tasks SET taskName = $n, progress = $pr, priority = $p, dueDate = $d, taskType = $type, startTime = $st, endTime = $et WHERE task_id = $id AND user_id = $uid";
            cmd.Parameters.AddWithValue("$n", name);
            cmd.Parameters.AddWithValue("$pr", progress);
            cmd.Parameters.AddWithValue("$p", priority);
            cmd.Parameters.AddWithValue("$d", dueDate.ToString("o"));
            cmd.Parameters.AddWithValue("$type", taskType);
            cmd.Parameters.AddWithValue("$st", startTime?.ToString("o") ?? (object)DBNull.Value);
            cmd.Parameters.AddWithValue("$et", endTime?.ToString("o") ?? (object)DBNull.Value);
            cmd.Parameters.AddWithValue("$id", taskId);
            cmd.Parameters.AddWithValue("$uid", userId);
            cmd.ExecuteNonQuery();
        }

        public static void DeleteTask(int taskId, int userId)
        {
            using var conn = new SqliteConnection(ConnectionString);
            conn.Open();

            var cmd = conn.CreateCommand();
            cmd.CommandText = "UPDATE tasks SET isTrashed = 1 WHERE task_id = $id AND user_id = $uid";
            cmd.Parameters.AddWithValue("$id", taskId);
            cmd.Parameters.AddWithValue("$uid", userId);
            cmd.ExecuteNonQuery();
        }

        public static List<Task> GetTrashedTasksForUser(int userId)
        {
            var list = new List<Task>();
            using var conn = new SqliteConnection(ConnectionString);
            conn.Open();

            var cmd = conn.CreateCommand();
            cmd.CommandText =
                "SELECT task_id, taskName, progress, priority, user_id, dueDate, isTrashed, taskType, startTime, endTime FROM tasks WHERE user_id = $uid AND isTrashed = 1";
            cmd.Parameters.AddWithValue("$uid", userId);

            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                list.Add(new Task(
                    reader.GetInt32(0),
                    reader.GetString(1),
                    reader.GetString(2),
                    reader.GetString(3),
                    reader.GetInt32(4),
                    DateTime.Parse(reader.GetString(5)),
                    reader.GetInt32(6) == 1,
                    reader.GetString(7),
                    reader.IsDBNull(8) ? null : DateTime.Parse(reader.GetString(8)),
                    reader.IsDBNull(9) ? null : DateTime.Parse(reader.GetString(9))));
            }
            return list;
        }

        public static void RestoreTask(int taskId, int userId)
        {
            using var conn = new SqliteConnection(ConnectionString);
            conn.Open();

            var cmd = conn.CreateCommand();
            cmd.CommandText = "UPDATE tasks SET isTrashed = 0 WHERE task_id = $id AND user_id = $uid";
            cmd.Parameters.AddWithValue("$id", taskId);
            cmd.Parameters.AddWithValue("$uid", userId);
            cmd.ExecuteNonQuery();
        }

        public static void HardDeleteTask(int taskId, int userId)
        {
            using var conn = new SqliteConnection(ConnectionString);
            conn.Open();

            var cmd = conn.CreateCommand();
            cmd.CommandText = "DELETE FROM tasks WHERE task_id = $id AND user_id = $uid";
            cmd.Parameters.AddWithValue("$id", taskId);
            cmd.Parameters.AddWithValue("$uid", userId);
            cmd.ExecuteNonQuery();
        }

        public static void HardDeleteAllTrashedTasks(int userId)
        {
            using var conn = new SqliteConnection(ConnectionString);
            conn.Open();

            var cmd = conn.CreateCommand();
            cmd.CommandText = "DELETE FROM tasks WHERE user_id = $uid AND isTrashed = 1";
            cmd.Parameters.AddWithValue("$uid", userId);
            cmd.ExecuteNonQuery();
        }

        public static void TrashAllTasks(int userId)
        {
            using var conn = new SqliteConnection(ConnectionString);
            conn.Open();

            var cmd = conn.CreateCommand();
            cmd.CommandText = "UPDATE tasks SET isTrashed = 1 WHERE user_id = $uid AND isTrashed = 0";
            cmd.Parameters.AddWithValue("$uid", userId);
            cmd.ExecuteNonQuery();
        }
    }
}
