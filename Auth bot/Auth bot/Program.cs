using System;
using DSharpPlus;
using DSharpPlus.CommandsNext;


namespace Auth_Bot
{
    class Program
    {
       static void  Main()
        {
            AsyncMain().GetAwaiter().GetResult();
        }

        async static  Task AsyncMain()
        {
            var Client = new DiscordClient(new DiscordConfiguration
            {
                Token = "OTM1Nzg1OTU4NDkyNzY2MjI5.YfDslg.qMQppihIyGC_D0K1LAiykbPm8Nc",
                Intents = DiscordIntents.AllUnprivileged,
                TokenType = TokenType.Bot
            });

            new DiscordConfiguration()
            {
                MinimumLogLevel = Microsoft.Extensions.Logging.LogLevel.Debug,
            };

            var commands = Client.UseCommandsNext( new CommandsNextConfiguration()
            {
                StringPrefixes = new[] { "." }
            });

            commands.RegisterCommands<DevPoints>();

        await  Client.ConnectAsync();
          await Task.Delay(-1);

                }
    }
}