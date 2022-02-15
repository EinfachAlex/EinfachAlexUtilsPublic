using DSharpPlus.Entities;
using System;

namespace EinfachAlex.Utils.Discord
{
    public abstract class EmbedGenerator
    {
        public static DiscordEmbed createEmbed(DiscordUser embedUser, DiscordColor embedColor, string embedTitle, string embedDescription, string embedFooterText = "D2P")
        {
            DiscordEmbedBuilder embed = new DiscordEmbedBuilder
            {
                Color = embedColor,
                Title = embedTitle,
                Description = embedDescription,
                Timestamp = DateTime.UtcNow
            };

            embed.WithFooter(embedFooterText, embedUser.AvatarUrl);

            return embed;
        }
    }
}