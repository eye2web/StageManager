using StageManager.MVVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StageManager.Models;

namespace StageManager.ViewModels
{
    class BedrijfsbegeleiderViewModel : PropertyChangedBase
    {
        public WBedrijfsBegeleider begeleider;

        public String Naam
        {
            get
            {
                return begeleider.Voornaam + " " + begeleider.Achternaam;
            }
        }

        public String Functie
        {
            get
            {
                return begeleider.Functie;
            }
        }

        public String EMail
        {
            get
            {
                return begeleider.Email;
            }
        }

        public String Opleiding
        {
            get
            {
                return begeleider.Opleidingsniveau;
            }
        }

        public bool? BegeleidingUren
        {
            get
            {
                return begeleider.Minimale_begeleidingstijd_gegarandeerd;
            }
        }
    }
}
