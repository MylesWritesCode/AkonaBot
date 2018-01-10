using Akona.Core.Common;
using Akona.Core.Services.Database.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Akona.Core.Modules.Warcraft.Common {
    class MythicAffix {
        public MythicAffixModel _model;
        public bool _success = true;

        public MythicAffix() {
            _model = Utilities.DeserializeJsonToString<MythicAffixModel>(Alerts.GetAlert("MYTHIC+AFFIXREQUEST"), "web");

            if (_model != null) {
                _success = true;
            }
        }
    }
}
