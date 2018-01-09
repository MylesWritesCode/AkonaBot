using System;
using System.IO;
using Akona.Core.Common;

namespace Akona.Core.Services {
    public class Configuration
    {
        public const string configFolder = "Resources";
        public const string configFile   = "botConfig.json";

        public static BotConfig bot;

        static Configuration() {
            string path = String.Format("{0}/{1}", configFolder, configFile);

            if (!Directory.Exists(configFolder)) {
                Directory.CreateDirectory(configFolder);
            }

            if (!File.Exists(path)) {
                bot = new BotConfig();
                string json = Utilities.SerializeObjectToJson<BotConfig>(bot, path);
                File.WriteAllText(path, json);
            } else {
                bot = Utilities.DeserializeJsonToString<BotConfig>(path, "local");
            }
        }
    }

    public struct BotConfig {
        public string token;
        public string WoWAPIKey;
        public string commandPrefix;
        public string voiceChannelName;
        public string textChannelName;
    }
}

