using System;
using System.Runtime.CompilerServices;

namespace EinfachAlex.Utils.UnixTime
{
    public class UnixTime
    {
        public static double getUnixTimestamp() => DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1)).TotalMilliseconds;

        public static DateTime toDateTime(double unixTimestamp)
        {
            DateTime dtDateTime = new DateTime(1970,1,1,0,0,0,0,System.DateTimeKind.Utc);
            dtDateTime = dtDateTime.AddMilliseconds( unixTimestamp ).ToLocalTime();
            return dtDateTime;
        }
        
        public static TimeSpan toTimeSpan(double milliseconds)
        {
            TimeSpan timeSpan = new TimeSpan((long) milliseconds * TimeSpan.TicksPerMillisecond);

            return timeSpan;
        }
        
        public static double fromTimeSpan(TimeSpan timeSpan)
        {
            return timeSpan.Milliseconds;
        }

        public static double toUnixTimestamp(DateTime dateTime)
        {
            double unixTimestamp = dateTime.Subtract(new DateTime(1970, 1, 1)).TotalMilliseconds;

            if (unixTimestamp < 0) unixTimestamp = 0;

            return unixTimestamp;
        }
    }
}
