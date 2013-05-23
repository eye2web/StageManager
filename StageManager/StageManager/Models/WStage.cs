using StageManager.Exceptions;
using StageManager.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StageManager.Models
{
    class WStage : Wrapper, ISetEntity<stageset>
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

        public int studentset1_Id
        {
            get
            {
                return getSet().studentset1_Id;
            }
            set
            {
                getSet().studentset1_Id = value;
                save(getSet());
            }
        }
        public int? studentset2_Id
        {
            get
            {
                return getSet().studentset2_Id;
            }
            set
            {
                getSet().studentset2_Id = value;
                save(getSet());
            }
        }

        public virtual WDocent docentsets
        {
            get
            {
                return new WDocent(getSet().docentset);
            }
            set
            {
                getSet().docentset = value.getSet();
                save(getSet());
            }
        }
        
        public virtual WStudent studentset
        {
            get
            {
                return new WStudent(getSet().studentset);
            }
            set
            {
                getSet().studentset = value.getSet();
                save(getSet());
            }
        }
        
        public virtual List<WKennisgebied> tool_vaardigheidset
        {
            get
            {
                List<WKennisgebied> oplSet = new List<WKennisgebied>();
                for (int i = 0; i < getSet().kennisgebiedsets.Count; i++)
                {
                    oplSet.Add(new WKennisgebied(getSet().kennisgebiedsets.ElementAt(i)));
                }
                return oplSet;
            }
            set
            {
                List<kennisgebiedset> list = new List<kennisgebiedset>();
                for (int i = 0; i < value.Count; i++)
                {
                    list.Add(value[i].getSet());
                }
                getSet().kennisgebiedsets = list;
                save(getSet());
            }
        }
        
        public virtual WBedrijfsBegeleider bedrijfsbegeleiderset
        {
            get
            {
                return new WBedrijfsBegeleider(getSet().bedrijfsbegeleiderset);
            }
            set
            {
                getSet().bedrijfsbegeleiderset = value.getSet();
                save(getSet());
            }
        }

        public WStage(stageset set)
            : base()
        {
            if (set == null)
            {
                throw new CantBeNullException(set.GetType().Name + " is NULL");
            }
            this.set = set;
        }

        public stageset getSet()
        {
            return set;
        }

        public stageset set { get; set; }
    }
}