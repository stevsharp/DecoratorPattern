
namespace DecoratorPatternUsingAutoFac
{
    public class TimestampLoggerDecorator(ILoggerService logger) : ILoggerService
    {
        private readonly ILoggerService _logger = logger;

        public void Log(string message)
        {
            string timestampedMessage = $"[{DateTime.Now:HH:mm:ss}] {message}";

            _logger.Log(timestampedMessage);
        }
    }
}