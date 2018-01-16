using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Akona.Core.Common;
using Akona.Core.Modules.Warcraft.Common;
using Akona.Core.Services.Database.Models;
using Discord;
using Discord.Commands;

namespace Akona.Core.Modules.Warcraft {
    public class Warcraft : ModuleBase<SocketCommandContext> {
        [Command("lookup")]
        public async Task CharacterLookup([Remainder] string msg) {
            var botMessage = await Context.Channel.SendMessageAsync("Searching...");

            string[] parameters = msg.Split(new Char[] { ',', ' ', '-' },
                                                       2,
                                                       StringSplitOptions.RemoveEmptyEntries);
            string name = parameters[0];
            string realm = WarcraftUtilities.ReviseRealmName(parameters[1]);

            Character toon = new Character(name, realm);
            if (toon._success) {
                await botMessage.ModifyAsync(x => {
                    x.Content = "Akona found this character for you!";
                });
                int[] classColor = toon.getClassColor();
                var embed = new EmbedBuilder()
                    .WithTitle(Alerts.GetFormattedAlert("TITLE", toon.getName(),
                                                                 toon.getRealm(),
                                                                 toon.getAchievementPoints()))
                    .WithThumbnailUrl(Alerts.GetFormattedAlert("THUMBNAIL", toon.getThumbnail()))
                    .WithDescription(Alerts.GetFormattedAlert("CLASS", toon.getLevel(),
                                                                       toon.getSpec(),
                                                                       toon.getClass(),
                                                                       toon.getiLevel()))
                    .WithColor(classColor[0], classColor[1], classColor[2])
                    .AddField("Progression", Alerts.GetFormattedAlert("Progression", toon.getENProgress(),
                                                                                     toon.getToVProgress(),
                                                                                     toon.getNHProgress(),
                                                                                     toon.getToSProgress(),
                                                                                     toon.getAntorusProgress()))
                    .AddField("Artifact Traits", toon.getArtifactTraits())
                    .AddField("Stats", Alerts.GetFormattedAlert("StatsDescriptionMain", toon.getHealth(),
                                                                                        toon.getPower(),
                                                                                        toon.getAgility(),
                                                                                        toon.getStrength(),
                                                                                        toon.getIntellect()))
                    .AddField("Secondary Stats", Alerts.GetFormattedAlert("StatsDescriptionSecondary", toon.getCrit(),
                                                                                                       toon.getHaste(),
                                                                                                       toon.getMastery(),
                                                                                                       toon.getVers()))
                    .AddInlineField("WoWProgress:", Alerts.GetFormattedAlert("WoWProgress", realm, name))
                    .AddInlineField("RaiderIO:", Alerts.GetFormattedAlert("RaiderIO", realm, name))
                    .AddInlineField("Armory:", Alerts.GetFormattedAlert("Armory", realm, name))
                    .AddInlineField("WarcraftLogs:", Alerts.GetFormattedAlert("WarcraftLogs", realm, name));

                await Context.Channel.SendMessageAsync("", false, embed);
            } else {
                await botMessage.ModifyAsync(x => {
                    x.Content = "Akona couldn't find the character you are looking for!";
                });
            }  // End if (toon._success) && else
        }  // End public async Task CharacterLookup([Remainder] string msg)

        [Command("mythic-affixes")]
        public async Task DisplayMythicAffixes() {
            var botMessage = await Context.Channel.SendMessageAsync("Searching...");
            MythicAffix affixes = new MythicAffix();

            if (affixes._success) {
                await botMessage.ModifyAsync(x => {
                    x.Content = "Akona found the US Mythic+ Affixes for you!";
                });

                var embed = new EmbedBuilder()
                    .WithTitle(affixes._model.title)
                    .WithDescription("Knowing is half the battle!")
                    .WithFooter(String.Format("Data from Raider.IO"));
                for (int i = 0; i < 3; i++) {
                    var tempAffix = affixes._model.affix_details[i];
                    embed.AddField(tempAffix.name, Alerts.GetFormattedAlert("MYTHIC+AFFIXDESCRIPTION", tempAffix.description,
                                                                                                       tempAffix.wowhead_url));
                }

                await Context.Channel.SendMessageAsync("", false, embed);
            } else {
                await botMessage.ModifyAsync(x => {
                    x.Content = "Akona couldn't find any affixes :(";
                });
            }  // End if (affixes) && else
        }  // End public async Task displayMythicAffixes()
    }
}
