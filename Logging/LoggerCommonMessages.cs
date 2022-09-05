using EinfachAlex.Utils.HashGenerator;
using EinfachAlex.Utils.WebRequest;

namespace EinfachAlex.Utils.Logging
{
    public class LoggerCommonMessages
    {
        public static string PREFIX_WEBREQUEST = "[WEBREQUEST] ";
        
        public static void logEndpointRequest(string endpoint, ERequestTypes type) => Logger.s(PREFIX_WEBREQUEST + $"{type.ToString()} {endpoint}");
       
        public static void logConstructNew(string key)
        {
            //Get what type is constructed based on call stack (name of calling class)
            string constructedItem = (new System.Diagnostics.StackTrace()).GetFrame(1).GetMethod().DeclaringType?.Name;
            
            Logger.i($"Trying to construct new {constructedItem} {key}");
        }
        
        public static void logGeneratedId(Hash id)
        {
            Logger.v($"Generated ID {id}");
        }
    }
}