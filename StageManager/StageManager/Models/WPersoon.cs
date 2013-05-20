using StageManager.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StageManager.Models
{
    class WPersoon : Wrapper<persoonset>
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
        
        public string Name
        {
            get
            {
                return getSet().Name;
            }
            set
            {
                getSet().Name = value;
                save();
            }
        }
        
        public string Email
        {
            get
            {
                return getSet().Email;
            }
            set
            {
                getSet().Email = value;
                save();
            }
        }
        
        public int? Telefoonnummer
        {
            get
            {
                return getSet().Telefoonnummer;
            }
            set
            {
                getSet().Telefoonnummer = value;
                save();
            }
        }

        public virtual bedrijfsbegeleiderset bedrijfsbegeleiderset
        {
            get
            {
                return getSet().bedrijfsbegeleiderset;
            }
            set
            {
                getSet().bedrijfsbegeleiderset = value;
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

        public WPersoon(persoonset set)
            : base(set)
        { }
    }
}