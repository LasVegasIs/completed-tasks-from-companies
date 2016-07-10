using System.Configuration;

namespace TaskManager.Domain
{
    public static class AppConfiguration
    {
       
        public static string ConnectionString
        {
            get
            {
                return ConfigurationManager.ConnectionStrings[ConnectionStringName].ConnectionString;
            }
        }
       
        public static string ConnectionStringName
        {
            get
            {
                return "TaskManagerProvider";
            }
        }        
    }
}
