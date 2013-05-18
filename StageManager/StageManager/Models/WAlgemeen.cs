using StageManager.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StageManager.Models
{
    class WAlgemeen : Wrapper<algemeenset>
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
                List<docentset> list = new List<docentset>();
                for (int i = 0; i < value.Count; i++)
                {
                    list.Add(value[i].getSet());
                }
                getSet().docentsets = list;
                save(getSet());
            }
        }

        public WAlgemeen(algemeenset set)
            : base(set)
        { }
    }
}
