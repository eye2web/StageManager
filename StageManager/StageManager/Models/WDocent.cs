using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StageManager.Services;

namespace StageManager.Models
{
    class WDocent : Wrapper<docentsets>
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


        public virtual algemeensets algemeenset
        {
            get
            {
                return getSet().algemeensets;
            }
            set
            {
                getSet().algemeensets = value;
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
        public virtual stagesets stageset
        {
            get
            {
                return getSet().stagesets;
            }
            set
            {
                getSet().stagesets = value;
                save();
            }
        }


        public virtual WAdres adressets
        {
            get
            {
                return new WAdres(getSet().adressets);
            }
            set
            {
                getSet().adressets = value.getSet();
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
                List<opleidingsets> list = new List<opleidingsets>();
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

        public WDocent(docentsets set)
            : base(set)
        {
        }
    }
}