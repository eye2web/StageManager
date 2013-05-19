using StageManager.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StageManager.Models
{
    class WOpleiding : Wrapper<opleidingset>
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

        public string Naam
        {
            get
            {
                return getSet().Naam;
            }
            set
            {
                getSet().Naam = value;
            }
        }

        public int acedemieId
        {
            get
            {
                return getSet().acedemieId;
            }
            set
            {
                getSet().acedemieId = value;
            }
        }

        public virtual acedemieset acedemieset
        {
            get
            {
                return getSet().acedemieset;
            }
            set
            {
                getSet().acedemieset = value;
            }
        }
        
        public virtual List<WStudent> studentsets
        {
            get
            {
                List<WStudent> oplSet = new List<WStudent>();
                for (int i = 0; i < getSet().studentsets.Count; i++)
                {
                    oplSet.Add(new WStudent(getSet().studentsets.ElementAt(i)));
                }
                return oplSet;
            }
            set
            {
                List<studentset> list = new List<studentset>();
                for (int i = 0; i < value.Count; i++)
                {
                    list.Add(value[i].getSet());
                }
                getSet().studentsets = list;
                save(getSet());
            }
        }
        
        public virtual List<WDocent> docentsets
        {
            get
            {
                List<WDocent> oplSet = new List<WDocent>();
                for (int i = 0; i < getSet().docentsets.Count; i++)
                {
                    oplSet.Add(new WDocent(getSet().docentsets.ElementAt(i)));
                }
                return oplSet;
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

        public WOpleiding(opleidingset set)
            : base(set)
        {
        }

    }
}