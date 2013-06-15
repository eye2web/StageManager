using Caliburn.Micro;
using StageManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StageManager.ViewModels
{
    class DocentViewModel : PropertyChangedBase
    {
        private static Random random = new Random();
        private WDocent Docent = new WStored().SearchDocentSet(null)[random.Next(new WStored().SearchDocentSet(null).Count)];

        public String Voornaam
        {
            get
            {
                return Docent.Voornaam;
            }
            set
            {
                Docent.Voornaam = value;
                NotifyOfPropertyChange(() => Voornaam);
            }
        }
        public String Achternaam
        {
            get
            {
                return Docent.Achternaam;
            }
            set
            {
                Docent.Achternaam = value;
                NotifyOfPropertyChange(() => Achternaam);
            }
        }
        public String Straat
        {
            get
            {
                return Docent.adressets.Straat;
            }
            set
            {
                Docent.adressets.Straat = value;
                NotifyOfPropertyChange(() => Straat);
            }
        }
        public String Huisnummer
        {
            get
            {
                return Docent.adressets.Huisnummer;
            }
            set
            {
                Docent.adressets.Huisnummer = value;
                NotifyOfPropertyChange(() => Huisnummer);
            }
        }

        public String Postcode
        {
            get
            {
                return Docent.adressets.Postcode;
            }
            set
            {
                Docent.adressets.Postcode = value;
                NotifyOfPropertyChange(() => Postcode);
            }
        }
        public String Woonplaats
        {
            get
            {
                return Docent.adressets.Plaats;
            }
            set
            {
                Docent.adressets.Plaats = value;
                NotifyOfPropertyChange(() => Woonplaats);
            }
        }
        public String Telefoon
        {
            get
            {
                return Docent.Telefoonnummer;
            }
            set
            {
                Docent.Telefoonnummer = value;
                NotifyOfPropertyChange(() => Telefoon);
            }
        }
        public String EMail
        {
            get
            {
                return Docent.Email;
            }
            set
            {
                Docent.Email = value;
                NotifyOfPropertyChange(() => EMail);
            }
        }

        public DocentViewModel(MainViewModel main, WDocent docent)
        {
            Main = main;
            Docent = docent;
        }

        public MainViewModel Main { get; set; }
    }
}