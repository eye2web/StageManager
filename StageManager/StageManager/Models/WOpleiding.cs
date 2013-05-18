using StageManager.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StageManager.Models
{
    class WOpleiding : Wrapper<opleidingset>
    {
        public WOpleiding(opleidingset set)
            : base(set)
        {
        }

    }
}
