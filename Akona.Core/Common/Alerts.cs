using System;
using System.IO;
using System.Text;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Akona.Core.Common {
    class Alerts {
        private static Dictionary<string, string> alerts;

        static Alerts() {
            string path = "./Resources/alerts.json";
            string json = File.ReadAllText(path);
            var data = JsonConvert.DeserializeObject<dynamic>(json);
            alerts = data.ToObject<Dictionary<string, string>>();
        }

        public static string GetAlert(string key) {
            if (alerts.ContainsKey(key)) return alerts[key];
            return "No key found.";
        }

        public static string GetFormattedAlert(string key, object parameter) {
            return GetFormattedAlert(key, new object[] { parameter });
        }

        public static string GetFormattedAlert(string key, params object[] parameter) {
            if (alerts.ContainsKey(key)) {
                return String.Format(alerts[key], parameter);
            }
            return "No key found.";
        }
    }
}
