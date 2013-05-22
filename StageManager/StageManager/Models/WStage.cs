using StageManager.Exceptions;
using StageManager.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StageManager.Models
{
    class WStage : Wrapper, ISetEntity<stagesets>
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
                save(getSet());
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
                save(getSet());
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
                save(getSet());
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
                save(getSet());
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
                save(getSet());
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
                List<docentsets> list = new List<docentsets>();
                for (int i = 0; i < value.Count; i++)
                {
                    list.Add(value[i].getSet());
                }
                getSet().docentsets = list;
                save(getSet());
            }
        }
        
        public virtual WStudent studentset
        {
            get
            {
                return new WStudent(getSet().studentsets);
            }
            set
            {
                getSet().studentsets = value.getSet();
                save(getSet());
            }
        }
        
        public virtual List<WKennisgebied> tool_vaardigheidset
        {
            get
            {
                List<WKennisgebied> oplSet = new List<WKennisgebied>();
                for (int i = 0; i < getSet().tool_vaardigheidset.Count; i++)
                {
                    oplSet.Add(new WKennisgebied(getSet().tool_vaardigheidset.ElementAt(i)));
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
                List<bedrijfsbegeleidersets> list = new List<bedrijfsbegeleidersets>();
                for (int i = 0; i < value.Count; i++)
                {
                    list.Add(value[i].getSet());
                }
                getSet().bedrijfsbegeleidersets = list;
                save(getSet());
            }
        }

        public WStage(stagesets set)
            : base()
        {
            if (set == null)
            {
                throw new CantBeNullException(set.GetType().Name + " is NULL");
            }
            this.set = set;
        }

        public stagesets getSet()
        {
            return set;
        }

        public stagesets set { get; set; }
    }
}