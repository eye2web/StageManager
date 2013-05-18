using StageManager.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StageManager.Models
{
    class WBedrijf:Wrapper<bedrijfset>
    {
        public WBedrijf(bedrijfset set)
            : base(set)
        {
        }
    }
}
