namespace TaskManagerCS;

static class Program
{
    
    
    
    [STAThread]
    static void Main()
    {
        
        
        ApplicationConfiguration.Initialize();
        TaskManagerCS.Data.Database.Init();
        Application.Run(new TaskManagerCS.Forms.LoginForm());
    }    
}
