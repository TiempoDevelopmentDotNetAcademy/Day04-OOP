using System;
using System.Collections.Generic;

namespace OOP_DependencyInversion
{
    public interface ILogger
    {
        void Log(int severity, string module, string message);

        void LogException(string module, Exception exception);
    }

    public class ConsoleLogger : ILogger {
        
        public ConsoleLogger() {

        }

        public void Log(int severity, string module, string message) {
            Console.WriteLine($"Writing in Console message: {message}");
        }

        public void LogException(string module, Exception exception) {
            Console.WriteLine("Logging Exception in Console.");
        }
    }

    public class FileLogger : ILogger {
        public FileLogger() {

        }

        public void Log(int severity, string module, string message) {
            Console.WriteLine($"Logging in a file message {message}");
        }

        public void LogException(string module, Exception exception) {
            Console.WriteLine("Logging Exception in a file.");
        }
    }

    public abstract class LoggerFactory
    {
        public abstract ILogger Create();
    }

    public class ConsoleLoggerFactory : LoggerFactory {
        public override ILogger Create() => new ConsoleLogger();
    }

    public class FileLoggerFactory : LoggerFactory {
        public override ILogger Create() => new FileLogger();
    }

    public class Logger {

        private readonly Dictionary<string, LoggerFactory> _factories;

        public Logger() {
            _factories = new Dictionary<string, LoggerFactory>
            {
                {"Console", new ConsoleLoggerFactory()},
                {"File", new FileLoggerFactory()}
            };
        }
        
        public ILogger Create( string logger_type) {

            foreach(KeyValuePair<string, LoggerFactory> entry in _factories)
            {
                if ( entry.Key == logger_type)
                {
                    return entry.Value.Create();
                }
            }
            return null;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Logger loggerFactory = new Logger();
            ILogger logger = loggerFactory.Create("File");
            if ( logger == null)
            {
                Console.WriteLine("Cannot load logger");
                return;
            }

            logger.Log(1,"","Application Started");
        }
    }
}
