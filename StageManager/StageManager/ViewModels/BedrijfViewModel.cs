using StageManager.Models;
using StageManager.MVVM;
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
                OnPropertyChanged("Naam");
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
                OnPropertyChanged("Straat");
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
                OnPropertyChanged("Nummer");
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
                OnPropertyChanged("Postcode");
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
                OnPropertyChanged("Plaats");
            }
        }
    }
}
