using DSharpPlus.Entities;
using System.Threading.Tasks;

namespace EinfachAlex.Utils.Discord
{
    public class MessageDeleter
    {
        public static async Task deleteAfter(DiscordMessage message, int deleteAfter = 10000)
        {
            await Task.Delay(deleteAfter);
            await message.DeleteAsync();
        }
    }
}
