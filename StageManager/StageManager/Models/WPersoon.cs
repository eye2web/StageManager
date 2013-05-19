﻿using StageManager.Services;
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

        public WPersoon(persoonset set)
            : base(set)
        { }
    }
}