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
        private static Random random = new Random();
        private static List<WBedrijfsBegeleider> list = WStored.SearchBedrijfsBegeleiderSet();//temp
        private WBedrijfsBegeleider begeleider = list[random.Next(list.Count)];//temp

        public String Voornaam
        {
            get
            {
                return begeleider.Voornaam;
            }
            set
            {
                begeleider.Voornaam = value;
                OnPropertyChanged("Voornaam");
            }
        }

        public String Achternaam
        {
            get
            {
                return begeleider.Achternaam;
            }
            set
            {
                begeleider.Achternaam = value;
                OnPropertyChanged("Achternaam");
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
            set
            {
                begeleider.Email = value;
                OnPropertyChanged("EMail");
            }
        }

        public String Opleiding
        {
            get
            {
                return begeleider.Opleidingsniveau;
            }
            set
            {
                begeleider.Opleidingsniveau = value;
                OnPropertyChanged("Opleiding");
            }
        }

        public bool? BegeleidingUren
        {
            get
            {
                return begeleider.Minimale_begeleidingstijd_gegarandeerd;
            }
            set
            {
                begeleider.Minimale_begeleidingstijd_gegarandeerd = value;
                OnPropertyChanged("BegeleidingUren");
            }
        }
    }
}
