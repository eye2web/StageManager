using StageManager.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StageManager.Models
{
    class WBedrijfsBegeleider : Wrapper<bedrijfsbegeleidersets>
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
                save();
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
                save();
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
        public virtual bedrijfsets bedrijfset
        {
            get
            {
                return getSet().bedrijfsets;
            }
            set
            {
                getSet().bedrijfsets = value;
                save();
            }
        }

        public WBedrijfsBegeleider(bedrijfsbegeleidersets set)
            : base(set)
        { }
    }
}
