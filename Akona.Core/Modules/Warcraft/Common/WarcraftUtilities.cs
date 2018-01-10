using Akona.Core.Common;
using Akona.Core.Services;
using Akona.Core.Services.Database.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Akona.Core.Modules.Warcraft.Common;
using Newtonsoft.Json;

namespace Akona.Core.Modules.Warcraft.Common {
    public class WarcraftUtilities {
        public WarcraftUtilities() { }
        public static string ReviseRealmName(string realm) {
            realm = realm.ToLower();
            RealmData realmInfo = new RealmData();
            // TODO: Figure out how to clean realm list.
            var realms = realmInfo._model.realms;
            List<string> listOfWords = new List<string>();
            for (int i = 0; i < realms.Length; i++) {
                listOfWords.Add(realms[i].slug);
            }

            StringSearch ssearch = new StringSearch(realm, listOfWords);
            return StringSearch.FindClosestMatch(ssearch);
        }
    }

    public class RealmData {
        public RealmModel _model;
        public bool _success = false;
        public RealmData() {
            _model = Utilities.DeserializeJsonToString<RealmModel>(Alerts.GetAlert("LOCALREALMLIST"), "local");
            if (_model != null) {
                _success = true;
            }
        }
    }
}
