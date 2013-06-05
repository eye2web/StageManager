using Caliburn.Micro;
using StageManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StageManager.ViewModels
{
    class BedrijfViewModel : PropertyChangedBase
    {
        private static Random random = new Random();
        private WBedrijf bedrijf = new WStored().SearchBedrijfSet()[random.Next(new WStored().SearchBedrijfSet().Count)];//temp
        public String Naam
        {
            get
            {
                return bedrijf.Naam;
            }
            set
            {
                bedrijf.Naam = value;
                NotifyOfPropertyChange(() => Naam);
            }
        }

        public String Straat
        {
            get
            {
               return bedrijf.AdresSets.Straat;
            }
            set
            {
                bedrijf.AdresSets.Straat = value;
                NotifyOfPropertyChange(() => Straat);
            }
        }

        public String Huisnummer
        {
            get
            {
                return bedrijf.AdresSets.Huisnummer;
            }
            set
            {
                bedrijf.AdresSets.Huisnummer = value;
                NotifyOfPropertyChange(() => Huisnummer);
            }
        }

        public String Postcode
        {
            get
            {
                return bedrijf.AdresSets.Postcode;
            }
            set
            {
                bedrijf.AdresSets.Postcode = value;
                NotifyOfPropertyChange(() => Postcode);
            }
        }

        public String Plaats
        {
            get
            {
                return bedrijf.AdresSets.Plaats;
            }
            set
            {
                bedrijf.AdresSets.Plaats = value;
                NotifyOfPropertyChange(() => Plaats);
            }
        }
    }
}
