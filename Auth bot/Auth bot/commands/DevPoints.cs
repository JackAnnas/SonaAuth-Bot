using DSharpPlus.CommandsNext;
using DSharpPlus;
using DSharpPlus.Entities;
using DSharpPlus.CommandsNext.Attributes;
using System.Net;

public class DevPoints : BaseCommandModule
{
   // example of the link https://sonafreelance.xyz/api/admin/?devkey=88b5f92e88369d8a26411a56f4f97ed2&type=add&expiry=1&mask=XXXXXX-XXXXXX-XXXXXX-XXXXXX-XXXXXX-XXXXXX&level=1&amount=1&format=text

    [Command("Gen-Token")]
    public async Task generatekey(CommandContext ctx, DiscordMember member,string expiry, string level)
    {

        var wc = new WebClient();

        var key = wc.DownloadString($"https://sonafreelance.xyz/api/admin/?devkey=88b5f92e88369d8a26411a56f4f97ed2&type=add&expiry={expiry}&mask=XXXXXX-XXXXXX-XXXXXX-XXXXXX-XXXXXX-XXXXXX&level={level}&amount=1&format=text");


        var embed = new DiscordEmbedBuilder()
        {
            Description = "thank you for purchasing here are your details & key\r\n" +
            $"here is your key: {key}\r\n" +
            $"expiry {expiry} day/days\r\n" + 
            $"level: {level}"
        };

       await member.SendMessageAsync(embed);
    }
   
   

}