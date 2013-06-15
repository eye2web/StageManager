using Caliburn.Micro;
using StageManager.Models;
using StageManager.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StageManager.ViewModels
{
    class BedrijfViewModel : PropertyChanged
    {
        private static Random random = new Random();
        private WBedrijf bedrijf = new WStored().SearchBedrijfSet()[random.Next(new WStored().SearchBedrijfSet().Count)];//temp

        internal WBedrijf Bedrijf
        {
            get { return bedrijf; }
            set { bedrijf = value; 
                        NotifyOfPropertyChange(()=>Naam);
            NotifyOfPropertyChange(()=>Straat);
            NotifyOfPropertyChange(()=>Huisnummer);
            NotifyOfPropertyChange(()=>Postcode);
            NotifyOfPropertyChange(()=>Plaats);
            }
        }
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

        public BedrijfViewModel(MainViewModel main)
        {
            Main = main;
        }
        public BedrijfViewModel(MainViewModel main, WBedrijf bedrijf)
            : this(main)
        {
            Bedrijf = bedrijf;
        }

        public MainViewModel Main { get; set; }

        public virtual void update(object[] o)
        {
            try
            {
                Bedrijf = (WBedrijf)o[1];
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
