using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StageManager.Services;

namespace StageManager.Models
{
    class WDocent : Wrapper<docentset>
    {
        public int Leraar_Id
        {
            get
            {
                return getSet().Leraar_Id;
            }
            set
            {
                getSet().Leraar_Id = value;
                save();
            }
        }
        public short? DBU1
        {
            get
            {
                return getSet().DBU1;
            }
            set
            {
                getSet().DBU1 = value;
                save();
            }
        }
        public short? DBU2
        {
            get
            {
                return getSet().DBU2;
            }
            set
            {
                getSet().DBU2 = value;
                save();
            }
        }
        public short? DBU3
        {
            get
            {
                return getSet().DBU3;
            }
            set
            {
                getSet().DBU3 = value;
                save();
            }
        }
        public short? DBU4
        {
            get
            {
                return getSet().DBU4;
            }
            set
            {
                getSet().DBU4 = value;
                save();
            }
        }
        public int stagesetStage_Id
        {
            get
            {
                return getSet().stagesetStage_Id;
            }
            set
            {
                getSet().stagesetStage_Id = value;
                save();
            }
        }
        public int algemeensetId
        {
            get
            {
                return getSet().algemeensetId;
            }
            set
            {
                getSet().algemeensetId = value;
                save();
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


        public virtual algemeenset algemeenset
        {
            get
            {
                return getSet().algemeenset;
            }
            set
            {
                getSet().algemeenset = value;
                save();
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
                save();
            }
        }
        public virtual stageset stageset
        {
            get
            {
                return getSet().stageset;
            }
            set
            {
                getSet().stageset = value;
                save();
            }
        }


        public virtual List<WAdres> adressets
        {
            get
            {
                List<WAdres> oplSet = new List<WAdres>();
                for (int i = 0; i < getSet().opleidingsets.Count; i++)
                {
                    oplSet.Add(new WAdres(getSet().adressets.ElementAt(i)));
                }
                return oplSet;
            }
            set
            {
                List<adresset> list = new List<adresset>();
                for (int i = 0; i < value.Count; i++)
                {
                    list.Add(value[i].getSet());
                }
                getSet().adressets = list;
                save();
            }
        }
        public virtual List<WWebkey> webkeysets
        {
            get
            {
                List<WWebkey> oplSet = new List<WWebkey>();
                for (int i = 0; i < getSet().opleidingsets.Count; i++)
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
                save();
            }
        }
        public virtual List<WOpleiding> opleidingsets
        {
            get
            {
                List<WOpleiding> oplSet = new List<WOpleiding>();
                for (int i = 0; i < getSet().opleidingsets.Count; i++)
                {
                    oplSet.Add(new WOpleiding(getSet().opleidingsets.ElementAt(i)));
                }
                return oplSet;
            }
            set
            {
                List<opleidingset> list = new List<opleidingset>();
                for (int i = 0; i < value.Count; i++)
                {
                    list.Add(value[i].getSet());
                }
                getSet().opleidingsets = list;
                save();
            }
        }
        public virtual List<WTool_vaardigheidset> tool_vaardigheidset
        {
            get
            {
                List<WTool_vaardigheidset> oplSet = new List<WTool_vaardigheidset>();
                for (int i = 0; i < getSet().opleidingsets.Count; i++)
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
                save();
            }
        }

        public WDocent(docentset set)
            : base(set)
        {
        }
    }
}