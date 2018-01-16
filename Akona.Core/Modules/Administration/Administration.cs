using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Akona.Core.Common;
using Akona.Core.Services.Database.Models;
using Discord;
using Discord.Commands;
using Discord.WebSocket;

namespace Akona.Core.Modules.Administration {
    public class Administration : ModuleBase<SocketCommandContext> {
        [Command("mute")]
        [RequireBotPermission(GuildPermission.MuteMembers)]
        [RequireUserPermission(GuildPermission.MuteMembers)]
        public async Task MuteUser(SocketGuildUser user) {
            var muter = Context.User as SocketGuildUser;
            var guild = Context.Guild as SocketGuild;

            if (muter.Id == user.Id) {
                await Context.Channel.SendMessageAsync("You cannot mute yourself.");
                return;
            }

            if (muter.Hierarchy <= user.Hierarchy) {
                await Context.Channel.SendMessageAsync(Alerts.GetAlert("MUTEHIGHERWARNING"));
                return;
            }

            var mutedRole = Context.Guild.Roles.FirstOrDefault(x => x.Name == "Silenced");
            
            if (user.Roles.Contains(mutedRole)) {
                await Context.Channel.SendMessageAsync(String.Format("{0} is already muted.", user.Username));
                return;
            }

            if (mutedRole == null) {
                await guild.CreateRoleAsync("Silenced");
            }

            await user.AddRoleAsync(mutedRole);
            await Context.Channel.SendMessageAsync(String.Format("{0} is now muted.", user.Username));
        }  // end public async Task MuteUser(SocketGuildUser user)

        [Command("unmute")]
        [RequireBotPermission(GuildPermission.MuteMembers)]
        [RequireUserPermission(GuildPermission.MuteMembers)]
        public async Task UnmuteUser(SocketGuildUser user) {
            var muter = Context.User as SocketGuildUser;
            var guild = Context.Guild as SocketGuild;

            if (muter.Hierarchy <= user.Hierarchy) {
                await Context.Channel.SendMessageAsync(Alerts.GetAlert("UNMUTEHIGHERWARNING"));
                return;
            }

            var mutedRole = Context.Guild.Roles.FirstOrDefault(x => x.Name == "Silenced");

            await user.RemoveRoleAsync(mutedRole);
            await Context.Channel.SendMessageAsync(String.Format("{0} is now unmuted.", user.Username));
        }  // end public async Task UnmuteUser(SocketGuildUser user)

        [Command("kick")]
        [RequireBotPermission(GuildPermission.KickMembers)]
        [RequireUserPermission(GuildPermission.KickMembers)]
        public async Task KickUser(SocketGuildUser user, [Remainder] string reason) {
            if (user == null) throw new ArgumentException("You must mention a user!");

            var guild = Context.Guild as SocketGuild;
            var embed = new EmbedBuilder()
                .WithColor(Color.Red)
                .WithTitle(String.Format("{0} has been kicked from {1}", user.Username, user.Guild.Name))
                .AddInlineField("User", user.Username)
                .AddInlineField("Guild", user.Guild.Name)
                .AddInlineField("Kicked By", Context.User.Mention)
                .AddField("Reason", reason);

            await user.KickAsync();
            await Context.Channel.SendMessageAsync("", false, embed);
        }  // End public async Task KickUser(SocketGuildUser user, [Remainder] string reason)
    }
}
