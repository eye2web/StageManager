using StageManager.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StageManager.Models
{
    class WAlgemeen : Wrapper<algemeensets>
    {
        public int Id
        {
            get
            {
                return getSet().Id;
            }
            set
            {
                getSet().Id = value;
                save();
            }
        }

        public String Jaargang
        {
            get
            {
                return getSet().Jaargang;
            }
            set
            {
                getSet().Jaargang = value;
                save();
            }
        }

        public String Werk_Uren
        {
            get
            {
                return getSet().Werk_Uren;
            }
            set
            {
                getSet().Werk_Uren = value;
                save();
            }
        }

        public String Blokken
        {
            get
            {
                return getSet().Blokken;
            }
            set
            {
                getSet().Blokken = value;
                save();
            }
        }

        public List<WDocent> docentsets
        {
            get
            {
                List<WDocent> list = new List<WDocent>();
                for (int i = 0; i < getSet().docentsets.Count; i++)
                {
                    list.Add(new WDocent(getSet().docentsets.ElementAt(i)));
                }
                return list;
            }
            set
            {
                List<docentsets> list = new List<docentsets>();
                for (int i = 0; i < value.Count; i++)
                {
                    list.Add(value[i].getSet());
                }
                getSet().docentsets = list;
                save();
            }
        }

        public WAlgemeen(algemeensets set)
            : base(set)
        { }
    }
}
