using StageManager.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StageManager.Models
{
    class WStudent : Wrapper<studentset>
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
            }
        }
        
        public string Webkey
        {
            get
            {
                return getSet().Webkey;
            }
            set
            {
                getSet().Webkey = value;
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
            }
        }

        public virtual opleidingset opleidingset
        {
            get
            {
                return getSet().opleidingset;
            }
            set
            {
                getSet().opleidingset = value;
            }
        }
        
        public virtual persoonset persoonset
        {
            get
            {
                return getSet().persoonset;
            }
            set
            {
                getSet().persoonset = value;
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
       
        public virtual List<WWebkey> webkeysets
        {
            get
            {
                List<WWebkey> oplSet = new List<WWebkey>();
                for (int i = 0; i < getSet().stagesets.Count; i++)
                {
                    oplSet.Add(new WWebkey(getSet().webkeysets.ElementAt(i)));
                }
                return oplSet;
            }
            set
            {
                List<webkeyset> list = new List<webkeyset>();
                for (int i = 0; i < value.Count; i++)
                {
                    list.Add(value[i].getSet());
                }
                getSet().webkeysets = list;
                save(getSet());
            }
        }

        public WStudent(studentset set)
            : base(set)
        { }
    }
}