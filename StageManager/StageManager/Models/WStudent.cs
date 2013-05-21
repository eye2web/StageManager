using StageManager.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StageManager.Models
{
    class WStudent : Wrapper<studentsets>
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
                save();
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
                save();
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
                save();
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
                save();
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
                save();
            }
        }

        public virtual opleidingsets opleidingset
        {
            get
            {
                return getSet().opleidingsets;
            }
            set
            {
                getSet().opleidingsets = value;
                save();
            }
        }
        
        public virtual persoonsets persoonset
        {
            get
            {
                return getSet().persoonsets;
            }
            set
            {
                getSet().persoonsets = value;
                save();
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
                List<stagesets> list = new List<stagesets>();
                for (int i = 0; i < value.Count; i++)
                {
                    list.Add(value[i].getSet());
                }
                getSet().stagesets = list;
                save();
            }
        }
       
        public virtual WWebkey webkeysets
        {
            get
            {
                return new WWebkey(getSet().webkeysets);
            }
            set
            {
                getSet().webkeysets = value.getSet();
                save();
            }
        }

        public WStudent(studentsets set)
            : base(set)
        { }
    }
}