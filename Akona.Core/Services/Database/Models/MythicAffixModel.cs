using Akona.Core.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Akona.Core.Services.Database.Models {
    public class MythicAffixModel {
        public string region { get; set; }
        public string title { get; set; }
        public string leaderboard_url { get; set; }
        public Affix_Details[] affix_details { get; set; }
    }
    public class Affix_Details {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string wowhead_url { get; set; }
    }
}
