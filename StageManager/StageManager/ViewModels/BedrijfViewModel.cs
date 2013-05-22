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
        public WBedrijf bedrijf;

        public String Naam
        {
            get
            {
                return bedrijf.Naam;
            }
            set
            {
                bedrijf.Naam = value;
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
            }
        }

        public String Nummer
        {
            get
            {
                return bedrijf.AdresSets.Huisnummer;
            }
            set
            {
                bedrijf.AdresSets.Huisnummer = value;
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
            }
        }
    }
}
