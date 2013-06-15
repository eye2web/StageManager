using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StageManager.Models;
using Caliburn.Micro;

namespace StageManager.ViewModels
{
    class BedrijfsbegeleiderViewModel : PropertyChangedBase
    {
        private static Random random = new Random();
        private WBedrijfsBegeleider Begeleider = new WStored().SearchBedrijfsBegeleiderSet()[random.Next(new WStored().SearchBedrijfsBegeleiderSet().Count)];//temp

        /*public String Voornaam
        {
            get
            {
                return begeleider.Voornaam;
            }
            set
            {
                begeleider.Voornaam = value;
                NotifyOfPropertyChange(() => Voornaam);
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
                NotifyOfPropertyChange(() => Achternaam);
            }
        }
        */
        public String Functie
        {
            get
            {
                return Begeleider.Functie;
            }
        }

       /* public String EMail
        {
            get
            {
                return begeleider.Email;
            }
            set
            {
                begeleider.Email = value;
                NotifyOfPropertyChange(() => EMail);
            }
        }*/

        public String Opleiding
        {
            get
            {
                return Begeleider.Opleidingsniveau;
            }
            set
            {
                Begeleider.Opleidingsniveau = value;
                NotifyOfPropertyChange(() => Opleiding);
            }
        }

        public bool? BegeleidingUren
        {
            get
            {
                return Begeleider.Minimale_begeleidingstijd_gegarandeerd;
            }
            set
            {
                Begeleider.Minimale_begeleidingstijd_gegarandeerd = value;
                NotifyOfPropertyChange(() => BegeleidingUren);
            }
        }

        public BedrijfsbegeleiderViewModel(MainViewModel main, WBedrijfsBegeleider bedrijfsbegeleider)
        {
            Main = main;
            Begeleider = bedrijfsbegeleider;
        }

        public MainViewModel Main { get; set; }
    }
}
