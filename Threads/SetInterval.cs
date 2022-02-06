using System;
using System.Threading.Tasks;

namespace EinfachAlex.Utils.Threads
{
    public class SetIntervalUtil
    {
        public static async Task SetInterval(Action action, TimeSpan timeout)
        {
            while (true)
            {
                await Task.Delay(timeout).ConfigureAwait(false);

                action();
            }
        }
    }
}