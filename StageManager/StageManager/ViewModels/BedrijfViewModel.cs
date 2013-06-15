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
        private WBedrijf Bedrijf = new WStored().SearchBedrijfSet()[random.Next(new WStored().SearchBedrijfSet().Count)];//temp
        public String Naam
        {
            get
            {
                return Bedrijf.Naam;
            }
            set
            {
                Bedrijf.Naam = value;
                NotifyOfPropertyChange(() => Naam);
            }
        }

        public String Straat
        {
            get
            {
               return Bedrijf.AdresSets.Straat;
            }
            set
            {
                Bedrijf.AdresSets.Straat = value;
                NotifyOfPropertyChange(() => Straat);
            }
        }

        public String Huisnummer
        {
            get
            {
                return Bedrijf.AdresSets.Huisnummer;
            }
            set
            {
                Bedrijf.AdresSets.Huisnummer = value;
                NotifyOfPropertyChange(() => Huisnummer);
            }
        }

        public String Postcode
        {
            get
            {
                return Bedrijf.AdresSets.Postcode;
            }
            set
            {
                Bedrijf.AdresSets.Postcode = value;
                NotifyOfPropertyChange(() => Postcode);
            }
        }

        public String Plaats
        {
            get
            {
                return Bedrijf.AdresSets.Plaats;
            }
            set
            {
                Bedrijf.AdresSets.Plaats = value;
                NotifyOfPropertyChange(() => Plaats);
            }
        }

        public BedrijfViewModel(MainViewModel main, WBedrijf bedrijf)
        {
            Main = main;
            Bedrijf = bedrijf;
        }

        public MainViewModel Main { get; set; }
    }
}
