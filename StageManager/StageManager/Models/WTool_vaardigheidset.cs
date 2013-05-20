using StageManager.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StageManager.Models
{
    class WTool_vaardigheidset:Wrapper<tool_vaardigheidset>
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

        public virtual List<WDocent> docentsets {
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
        
        public virtual List<WStage> stagesets {
            get
            {
                List<WStage> oplSet = new List<WStage>();
                for (int i = 0; i < getSet().stagesets.Count; i++)
                {
                    oplSet.Add(new WStage(getSet().stagesets.ElementAt(i)));
                }
                return oplSet;
            }
            set
            {
                List<stagesets> list = new List<stagesets>();
                for (int i = 0; i < value.Count; i++)
                {
                    list.Add(value[i].getSet());
                }
                getSet().stagesets = list;
                save();
            }
}

        public WTool_vaardigheidset(tool_vaardigheidset set)
            : base(set)
        { }
    }
}
