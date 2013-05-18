using StageManager.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StageManager.Models
{
    class WStage:Wrapper<stageset>
    {
        public WStage(stageset set)
            : base(set)
        { }
    }
}
