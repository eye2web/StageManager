using StageManager.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StageManager.Models
{
    class WPersoon : Wrapper<persoonsets>
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

        public virtual bedrijfsbegeleidersets bedrijfsbegeleiderset
        {
            get
            {
                return getSet().bedrijfsbegeleidersets;
            }
            set
            {
                getSet().bedrijfsbegeleidersets = value;
                save();
            }
        }
        
        public virtual docentsets docentset
        {
            get
            {
                return getSet().docentsets;
            }
            set
            {
                getSet().docentsets = value;
                save();
            }
        }
       
        public virtual studentsets studentset
        {
            get
            {
                return getSet().studentsets;
            }
            set
            {
                getSet().studentsets = value;
                save();
            }
        }

        public WPersoon(persoonsets set)
            : base(set)
        { }
    }
}