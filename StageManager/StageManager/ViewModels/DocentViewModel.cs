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
        private WDocent docent = new WStored().SearchDocentSet(null)[random.Next(new WStored().SearchDocentSet(null).Count)];

        public String Voornaam
        {
            get
            {
                return docent.Voornaam;
            }
            set
            {
                docent.Voornaam = value;
                NotifyOfPropertyChange(() => Voornaam);
            }
        }
        public String Achternaam
        {
            get
            {
                return docent.Achternaam;
            }
            set
            {
                docent.Achternaam = value;
                NotifyOfPropertyChange(() => Achternaam);
            }
        }
        public String Straat
        {
            get
            {
                return docent.adressets.Straat;
            }
            set
            {
                docent.adressets.Straat = value;
                NotifyOfPropertyChange(() => Straat);
            }
        }
        public String Huisnummer
        {
            get
            {
                return docent.adressets.Huisnummer;
            }
            set
            {
                docent.adressets.Huisnummer = value;
                NotifyOfPropertyChange(() => Huisnummer);
            }
        }

        public String Postcode
        {
            get
            {
                return docent.adressets.Postcode;
            }
            set
            {
                docent.adressets.Postcode = value;
                NotifyOfPropertyChange(() => Postcode);
            }
        }
        public String Woonplaats
        {
            get
            {
                return docent.adressets.Plaats;
            }
            set
            {
                docent.adressets.Plaats = value;
                NotifyOfPropertyChange(() => Woonplaats);
            }
        }
        public String Telefoon
        {
            get
            {
                return docent.Telefoonnummer;
            }
            set
            {
                docent.Telefoonnummer = value;
                NotifyOfPropertyChange(() => Telefoon);
            }
        }
        public String EMail
        {
            get
            {
                return docent.Email;
            }
            set
            {
                docent.Email = value;
                NotifyOfPropertyChange(() => EMail);
            }
        }

        public DocentViewModel()
        { }
    }
}