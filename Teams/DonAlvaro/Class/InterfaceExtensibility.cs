using System;
using System.IO;

namespace InterfaceExtensibility
{

    class Program   //OPEN OR CLOSED PRINCIPLE OCP
                    //SOFTWARE ENTITIES SHOULD BE OPEN FOR EXTENSION BUT CLOSED FOR MODIFICATION
    {
        static void main(string[] args)
        {
            var dbMigrator = new DbMigrator(new FileLogger("D:\\log.txt"));
            dbMigrator.Migrate();
        }
    }

    public interface ILogger
    {
        void LogError(string message);
        void LogInfo(string message);

    }

    public class FileLogger : ILogger
    {
        private readonly string path;

        public FileLogger(string path)
        {
            this.path = path;
        }
        public void LogError(string message)
        {
            Log(message, "ERROR");
        }

        public void LogInfo(string message)
        {
            Log(message, "INFO");
        }

        private void Log(string message, string messageType)
        {
            using (var streamWriter = new StreamWriter(path, true))
            {
                streamWriter.WriteLine(messageType + ": " + message);
            }

        }
    }

    public class DbMigrator
    {
        private readonly ILogger _logger;

        public DbMigrator(ILogger logger) //Dependency Injection
        {
            _logger = logger;
        }

        public void Migrate() //Problem is if we use a file or database instead of the Console.\\ We may have to change this method again.
        {
            _logger.LogInfo("Migration started at " + DateTime.Now);
            //Console.WriteLine("Migrating started at {0}", DateTime.Now);
            //Details of migrating the database
            //Console.WriteLine("Migrating finished at {0}", DateTime.Now);

            _logger.LogInfo("Migration Finished at " + DateTime.Now);
        }

    }

    public class ConsoleLogger : ILogger
    {
        public void LogError(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
        }

        public void LogInfo(string message)
        {

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(message);
        }
    }

}
