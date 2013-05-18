using StageManager.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StageManager.Models
{
    class WBedrijfsBegeleider:Wrapper<bedrijfsbegeleiderset>
    {
        public WBedrijfsBegeleider(bedrijfsbegeleiderset set)
            : base(set)
        { }
    }
}
