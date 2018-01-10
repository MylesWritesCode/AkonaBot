using System;
using Discord;
using Discord.WebSocket;
using System.Threading.Tasks;
using Akona.Core.Services;
using Akona.Core.Modules.Warcraft.Common;

namespace Akona.Core {
    class AkonaBot {
        DiscordSocketClient _client;
        CommandHandler _handler;

        static void Main(string[] args)
        => new AkonaBot().StartAsync().GetAwaiter().GetResult();

        public async Task StartAsync() {

            Configuration config = new Configuration();
            if (Configuration.bot.token == "" || Configuration.bot.token == null) return;
            _client = new DiscordSocketClient(new DiscordSocketConfig {
                LogLevel = LogSeverity.Verbose
            });

            _client.Log += Log;
            await _client.LoginAsync(TokenType.Bot, Configuration.bot.token);
            await _client.StartAsync();

            _handler = new CommandHandler();
            await _handler.InitializeAsync(_client);
            await Task.Delay(-1);
        }

        private async Task Log(LogMessage msg) {
            Console.WriteLine(msg.Message);
        }
    }
}
