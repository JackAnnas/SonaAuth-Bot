using DSharpPlus.CommandsNext;
using DSharpPlus.CommandsNext.Attributes;
using DSharpPlus.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auth_bot.commands
{
    public class admin : BaseCommandModule
    {
        [Command("kick")]
        [Description("kicks member from guild")]
        [RequirePermissions(DSharpPlus.Permissions.KickMembers)]
        public async Task kick(CommandContext ctx, DiscordMember member)
        {
            await member.RemoveAsync();

            string guild = ctx.Guild.Name;

            var dm = new DiscordEmbedBuilder()
            {
                Description = $"you have been banned from {guild}"
            };

            var embed = new DiscordEmbedBuilder()
            {
                Description = $"you kicked {member} from this guild"
            };


            await member.SendMessageAsync(dm);
            await ctx.RespondAsync(embed);

        }

    }
}
