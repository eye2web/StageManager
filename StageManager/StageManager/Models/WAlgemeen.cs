using StageManager.Exceptions;
using StageManager.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StageManager.Models
{
    class WAlgemeen : Wrapper, ISetEntity<algemeenset>
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
                save(getSet());
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
                save(getSet());
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
                save(getSet());
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
                save(getSet());
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
            : base()
        {
            if (set == null)
            {
                throw new CantBeNullException(set.GetType().Name + " is NULL");
            }
            this.set = set;
        }

        public algemeenset getSet()
        {
            return set;
        }

        public algemeenset set { get; set; }
    }
}
