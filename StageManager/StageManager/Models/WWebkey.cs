using StageManager.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StageManager.Models
{
    class WWebkey : Wrapper<webkeyset>
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

        public string ConnectionKey
        {
            get
            {
                return getSet().ConnectionKey;
            }
            set
            {
                getSet().ConnectionKey = value;
                save();
            }
        }

        public string Status
        {
            get
            {
                return getSet().Status;
            }
            set
            {
                getSet().Status = value;
                save();
            }
        }

        public int docentset_Id
        {
            get
            {
                return getSet().docentset_Id;
            }
            set
            {
                getSet().docentset_Id = value;
                save();
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
                getSet().studentset_Id = value;
                save();
            }
        }

        public virtual docentset docentset
        {
            get
            {
                return getSet().docentset;
            }
            set
            {
                getSet().docentset = value;
                save();
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
                save();
            }
        }

        public WWebkey(webkeyset set)
            : base(set)
        { }
    }
}
