using StageManager.Exceptions;
using StageManager.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StageManager.Models
{
    class WStudent : WPersoon, ISetEntity<studentset>
    {
        public int Studentnummer
        {
            get
            {
                return getSet().Studentnummer;
            }
            set
            {
                getSet().Studentnummer = value;
                save(getSet());
            }
        }

        public bool EC_norm_behaald
        {
            get
            {
                return getSet().EC_norm_behaald;
            }
            set
            {
                getSet().EC_norm_behaald = value;
                save(getSet());
            }
        }
        
        public int OpleidingId
        {
            get
            {
                return getSet().OpleidingId;
            }
            set
            {
                getSet().OpleidingId = value;
                save(getSet());
            }
        }

        public int webkeysets_Id
        {
            get
            {
                return getSet().webkeysets_Id;
            }
            set
            {
                getSet().webkeysets_Id = value;
                save(getSet());
            }
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
                save(getSet());
            }
        }

        public virtual WOpleiding Opleidingset
        {
            get
            {
                return new WOpleiding(getSet().opleidingset);
            }
            set
            {
                getSet().opleidingset = value.getSet();
                save(getSet());
            }
        }
        
        public virtual WPersoon persoonset
        {
            get
            {
                return new WPersoon(getSet().persoonset);
            }
            set
            {
                getSet().persoonset = value.getSet();
                save(getSet());
            }
        }
      
        public virtual List<WStage> stagesets
        {
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
                List<stageset> list = new List<stageset>();
                for (int i = 0; i < value.Count; i++)
                {
                    list.Add(value[i].getSet());
                }
                getSet().stagesets = list;
                save(getSet());
            }
        }
       
        public virtual WWebkey webkeysets
        {
            get
            {
                return new WWebkey(getSet().webkeyset);
            }
            set
            {
                getSet().webkeyset = value.getSet();
                save(getSet());
            }
        }

        public WStudent(studentset set)
            : base(set.persoonset)
        {
            if (set == null)
            {
                throw new CantBeNullException(set.GetType().Name + " is NULL");
            }
            this.set = set;
        }

        public studentset getSet()
        {
            return set;
        }

        public studentset set { get; set; }
    }
}