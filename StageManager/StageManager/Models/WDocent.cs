using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StageManager.Services;

namespace StageManager.Models
{
    class WDocent:Wrapper<docentset>
    {
        public WDocent(docentset set)
            :base(set)
        {
        }

        public int Id
        {
            get
            {
                return getSet().Id;
            }
            set
            {
                getSet().Id = value;
            }
        }
    }
}
