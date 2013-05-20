using StageManager.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StageManager.Models
{
    class WOpleiding : Wrapper<opleidingsets>
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

        public string Naam
        {
            get
            {
                return getSet().Naam;
            }
            set
            {
                getSet().Naam = value;
                save();
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
                save();
            }
        }

        public virtual acedemiesets acedemieset
        {
            get
            {
                return getSet().acedemiesets;
            }
            set
            {
                getSet().acedemiesets = value;
                save();
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
                List<studentsets> list = new List<studentsets>();
                for (int i = 0; i < value.Count; i++)
                {
                    list.Add(value[i].getSet());
                }
                getSet().studentsets = list;
                save();
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
                List<docentsets> list = new List<docentsets>();
                for (int i = 0; i < value.Count; i++)
                {
                    list.Add(value[i].getSet());
                }
                getSet().docentsets = list;
                save();
            }
        }

        public WOpleiding(opleidingsets set)
            : base(set)
        {
        }

    }
}