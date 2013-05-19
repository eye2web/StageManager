using StageManager.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StageManager.Models
{
    class WBedrijfsBegeleider : Wrapper<bedrijfsbegeleiderset>
    {
        public string Functie
        {
            get
            {
                return getSet().Functie;
            }
            set
            {
                getSet().Functie = value;
            }
        }
        public string Opleidingsniveau
        {
            get
            {
                return getSet().Opleidingsniveau;
            }
            set
            {
                getSet().Opleidingsniveau = value;
            }
        }
        public bool? Minimale_begeleidingstijd_gegarandeerd
        {
            get
            {
                return getSet().Minimale_begeleidingstijd_gegarandeerd;
            }
            set
            {
                getSet().Minimale_begeleidingstijd_gegarandeerd = value;
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
        public virtual stageset stageset
        {
            get
            {
                return getSet().stageset;
            }
            set
            {
                getSet().stageset = value;
            }
        }
        public virtual bedrijfset bedrijfset
        {
            get
            {
                return getSet().bedrijfset;
            }
            set
            {
                getSet().bedrijfset = value;
            }
        }

        public WBedrijfsBegeleider(bedrijfsbegeleiderset set)
            : base(set)
        { }
    }
}
