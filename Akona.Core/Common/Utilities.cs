using System;
using System.IO;
using System.Net;
using System.Text;
using Newtonsoft.Json;

namespace Akona.Core.Common {
    class Utilities {
        public Utilities() { }

        public static T DeserializeJsonToString<T>(string path, string location) {
            string json;
            if (location == "local") {
                json = File.ReadAllText(path);
            } else {
                json = FetchWebResponse<string>(path);
            }
            object obj = JsonConvert.DeserializeObject<T>(json);
            return (T) Convert.ChangeType(obj, typeof(T));
        }

        public static T DeserializeJsonToString<T>(string json) {
            object obj = JsonConvert.DeserializeObject<T>(json);
            return (T)Convert.ChangeType(obj, typeof(T));
        }

        public static string SerializeObjectToJson<T>(T obj, string path) {
            string json = JsonConvert.SerializeObject(obj, Formatting.Indented);
            return json;
        }

        public static T FetchWebResponse<T>(string url) {
            try {
                WebClient wc = new WebClient() { Encoding = Encoding.UTF8 };
                using (wc) {
                    if (typeof(T) == typeof(string)) {
                        var response = wc.DownloadString(url);
                        return (T)Convert.ChangeType(response, typeof(T));
                    } else {
                        var response = wc.DownloadData(url);
                        return (T)Convert.ChangeType(response, typeof(T));
                    }
                }
            } catch (Exception e) {
                Console.WriteLine(e.Message);
                return default(T);
            }
        }
    }
}
