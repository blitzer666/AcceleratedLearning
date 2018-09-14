using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tomtenissar
{
    public class BattleEvents
    {
        public int Id { get; set; }
        public int Order { get; set; }
        public string Summary { get; set; }
        public string Description { get; set; }

        public BattleLog BattleLog { get; set; }
        public int BattleLogId { get; set; }

    }
}
