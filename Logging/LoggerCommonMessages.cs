using EinfachAlex.Utils.WebRequest;

namespace EinfachAlex.Utils.Logging
{
    public class LoggerCommonMessages
    {
        public static string PREFIX_WEBREQUEST = "[WEBREQUEST] ";
        
        public static void logEndpointRequest(string endpoint, ERequestTypes type) => Logger.s(PREFIX_WEBREQUEST + $"{type.ToString()} {endpoint}");
    }
}