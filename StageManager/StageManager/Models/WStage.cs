using StageManager.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StageManager.Models
{
    class WStage : Wrapper<stageset>
    {
        public int Stage_Id
        {
            get
            {
                return getSet().Stage_Id;
            }
            set
            {
                getSet().Stage_Id = value;
            }
        }
        
        public System.DateTime? Start_datum
        {
            get
            {
                return getSet().Start_datum;
            }
            set
            {
                getSet().Start_datum = value;
            }
        }
        
        public System.DateTime? Eind_datum
        {
            get
            {
                return getSet().Eind_datum;
            }
            set
            {
                getSet().Eind_datum = value;
            }
        }
        
        public string Stageopdracht_omschijving
        {
            get
            {
                return getSet().Stageopdracht_omschijving;
            }
            set
            {
                getSet().Stageopdracht_omschijving = value;
            }
        }
        
        public int bedrijfEnBegeleiderId
        {
            get
            {
                return getSet().bedrijfEnBegeleiderId;
            }
            set
            {
                getSet().bedrijfEnBegeleiderId = value;
            }
        }
        
        public int studentset_Id
        {
            get
            {
                return getSet().studentset_Id;
            }
            set
            {
                getSet().bedrijfEnBegeleiderId = value;
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
        
        public virtual studentset studentset
        {
            get
            {
                return getSet().studentset;
            }
            set
            {
                getSet().studentset = value;
            }
        }
        
        public virtual List<WTool_vaardigheidset> tool_vaardigheidset
        {
            get
            {
                List<WTool_vaardigheidset> oplSet = new List<WTool_vaardigheidset>();
                for (int i = 0; i < getSet().tool_vaardigheidset.Count; i++)
                {
                    oplSet.Add(new WTool_vaardigheidset(getSet().tool_vaardigheidset.ElementAt(i)));
                }
                return oplSet;
            }
            set
            {
                List<tool_vaardigheidset> list = new List<tool_vaardigheidset>();
                for (int i = 0; i < value.Count; i++)
                {
                    list.Add(value[i].getSet());
                }
                getSet().tool_vaardigheidset = list;
                save(getSet());
            }
        }
        
        public virtual List<WBedrijfsBegeleider> bedrijfsbegeleiderset
        {
            get
            {
                List<WBedrijfsBegeleider> oplSet = new List<WBedrijfsBegeleider>();
                for (int i = 0; i < getSet().bedrijfsbegeleidersets.Count; i++)
                {
                    oplSet.Add(new WBedrijfsBegeleider(getSet().bedrijfsbegeleidersets.ElementAt(i)));
                }
                return oplSet;
            }
            set
            {
                List<bedrijfsbegeleiderset> list = new List<bedrijfsbegeleiderset>();
                for (int i = 0; i < value.Count; i++)
                {
                    list.Add(value[i].getSet());
                }
                getSet().bedrijfsbegeleidersets = list;
                save(getSet());
            }
        }

        public WStage(stageset set)
            : base(set)
        { }
    }
}