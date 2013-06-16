using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StageManager.Models;
using Caliburn.Micro;
using StageManager.Services;

namespace StageManager.ViewModels
{
    class BedrijfsbegeleiderViewModel : PropertyChanged
    {
        private static Random random = new Random();
        private WBedrijfsBegeleider begeleider = new WStored().SearchBedrijfsBegeleiderSet()[random.Next(new WStored().SearchBedrijfsBegeleiderSet().Count)];//temp

        internal WBedrijfsBegeleider Begeleider
        {
            get { return begeleider; }
            set
            {
                begeleider = value;
                NotifyOfPropertyChange(() => Functie);
                NotifyOfPropertyChange(() => Opleiding);
                NotifyOfPropertyChange(() => BegeleidingUren);
                /*NotifyOfPropertyChange(()=>Voornaam);
                NotifyOfPropertyChange(()=>Achternaam);
                NotifyOfPropertyChange(()=>EMail);*/
            }
        }

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
                return begeleider.Functie;
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
                return begeleider.Opleidingsniveau;
            }
            set
            {
                begeleider.Opleidingsniveau = value;
                NotifyOfPropertyChange(() => Opleiding);
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
                NotifyOfPropertyChange(() => BegeleidingUren);
            }
        }

        public BedrijfsbegeleiderViewModel(MainViewModel main)
        {
            Main = main;
        }
        public BedrijfsbegeleiderViewModel(MainViewModel main, WBedrijfsBegeleider bedrijfsbegeleider)
            : this(main)
        {
            Begeleider = bedrijfsbegeleider;
        }

        public MainViewModel Main { get; set; }

        public override void update(object[] o)
        {
            try
            {
                Begeleider = (WBedrijfsBegeleider)o[1];
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
