using System;
using Microsoft.Extensions.Logging;

namespace DBSoft.FMPCloud.Logging
{
    public static class LoggingExtensions
    {
        private static readonly Action<ILogger, string, Exception> _requestError = LoggerMessage.Define<string>(
                LogLevel.Critical,
                new EventId(1, nameof(RequestError)),
                "Error sending request to remote server: {destination}");

        private static readonly Func<ILogger, Guid, IDisposable> _beginRequest = LoggerMessage.DefineScope<Guid>("Request {TransactionId}");

        public static void RequestError(this ILogger logger, string destination, Exception ex) => 
            _requestError(logger, destination, ex);

        public static IDisposable BeginRequestScope(this ILogger logger) =>
            _beginRequest(logger, Guid.NewGuid());
    }
}
