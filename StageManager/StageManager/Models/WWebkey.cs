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

        public WWebkey(webkeyset set)
            : base(set)
        { }
    }
}
