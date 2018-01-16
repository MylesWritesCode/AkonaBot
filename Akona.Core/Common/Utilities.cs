using System;
using System.Collections.Generic;
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
            return (T)Convert.ChangeType(obj, typeof(T));
        }  // End public static T DeserializeJsonToString<T>(string path, string location)

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
                if (typeof(T) == typeof(string))
                    return (T)Convert.ChangeType("Error fetching data.", typeof(T));
                return default(T);
            }  // End try && catch
        }  // End public static T FetchWebResponse<T>(string url)

        /* Levenshtein Distance Algorithm */
        public static int ComputeDistanceInStrings(string s, string t) {
            int n = s.Length;
            int m = t.Length;
            int[,] d = new int[n + 1, m + 1];

            // Step 1
            if (n == 0) {
                return m;
            }

            if (m == 0) {
                return n;
            }

            // Step 2
            for (int i = 0; i <= n; d[i, 0] = i++) {
            }

            for (int j = 0; j <= m; d[0, j] = j++) {
            }

            // Step 3
            for (int i = 1; i <= n; i++) {
                //Step 4
                for (int j = 1; j <= m; j++) {
                    // Step 5
                    int cost = (t[j - 1] == s[i - 1]) ? 0 : 1;

                    // Step 6
                    d[i, j] = Math.Min(
                        Math.Min(d[i - 1, j] + 1, d[i, j - 1] + 1),
                        d[i - 1, j - 1] + cost);
                }
            }
            // Step 7
            return d[n, m];
        }  // End public static int ComputeDistanceInStrings(string s, string t)
    }  // End class Utilities

    public class StringSearch {
        private string _word;
        private List<string> _listOfWords;
        int _iteration = 0;

        public StringSearch() {
            return;
        }

        public StringSearch(string word, List<string> listOfWords, int iteration = 0) {
            _word = word;
            _listOfWords = listOfWords;
            _iteration = iteration;
        }

        public static string FindClosestMatch(StringSearch ssearch) {
            List<string> narrowedList = new List<string>();
            for (int i = 0; i <= ssearch._listOfWords.Count - 1; i++) {
                for (int j = 0; j < ssearch._listOfWords[i].Length; j++) {
                    if (ssearch._listOfWords[i][ssearch._iteration] == ssearch._word[ssearch._iteration]
                        && !narrowedList.Contains(ssearch._listOfWords[i])) {
                        narrowedList.Add(ssearch._listOfWords[i]);
                    }
                }
            }
            narrowedList.TrimExcess();
            if (narrowedList.Count == 1) {
                return narrowedList[0];
            } else {
                int newIteration = ssearch._iteration + 1;
                StringSearch tempStringSearch = new StringSearch(ssearch._word, narrowedList, newIteration);
                return FindClosestMatch(tempStringSearch);
            }
        }  // End public static string FindClosestMatch(StringSearch ssearch)
    }  // End public class StringSearch
}  // End namespace Akona.Core.Common