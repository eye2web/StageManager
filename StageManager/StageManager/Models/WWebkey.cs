using StageManager.Exceptions;
using StageManager.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StageManager.Models
{
    class WWebkey : Wrapper, ISetEntity<webkeyset>
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
                save(getSet());
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
                save(getSet());
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
                save(getSet());
            }
        }



        public WWebkey(webkeyset set)
            : base()
        {
            if (set == null)
            {
                throw new CantBeNullException(set.GetType().Name + " is NULL");
            }
            this.set = set;
        }

        public webkeyset getSet()
        {
            return set;
        }

        public webkeyset set { get; set; }
    }
}
