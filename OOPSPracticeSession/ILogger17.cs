using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSPracticeSession
{
    public interface ILogger17
    {
        void Log(string message);
    }
    public class FileLogger : ILogger17
    {
        public void Log(string message)
        {
            Console.WriteLine($"FileLogger: {message}");
        }
    }
    // Step 3: Create an abstract LoggerDecorator class
    public abstract class LoggerDecorator : ILogger17
    {
        protected ILogger17 logger;

        public LoggerDecorator(ILogger17 logger)
        {
            this.logger = logger;
        }

        public virtual void Log(string message)
        {
            logger.Log(message);
        }
    }
    // Step 4: Implement TimestampLogger to add timestamp functionality
    public class TimestampLogger : LoggerDecorator
    {
        public TimestampLogger(ILogger17 logger) : base(logger) { }

        public override void Log(string message)
        {
            string timestampedMessage = $"[{DateTime.Now}] {message}";
            base.Log(timestampedMessage);
        }
    }
    // Step 5: Implement ErrorCategoryLogger to add error categorization
    public class ErrorCategoryLogger : LoggerDecorator
    {
        private string errorCategory;

        public ErrorCategoryLogger(ILogger17 logger, string category) : base(logger)
        {
            this.errorCategory = category;
        }

        public override void Log(string message)
        {
            string categorizedMessage = $"[{errorCategory}] {message}";
            base.Log(categorizedMessage);
        }
    }
}
