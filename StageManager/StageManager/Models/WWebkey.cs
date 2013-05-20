using StageManager.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StageManager.Models
{
    class WWebkey : Wrapper<webkeysets>
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

       

        public WWebkey(webkeysets set)
            : base(set)
        { }
    }
}
