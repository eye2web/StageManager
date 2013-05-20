using StageManager.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StageManager.Models
{
    class WAdres:Wrapper<adresset>
    {
        public int Id
        {
            get
            {
                return getSet().Id;
            }
            set
            {
                getSet().Id = value;
                save();
            }
        }

        public String Plaats
        {
            get
            {
                return getSet().Plaats;
            }
            set
            {
                getSet().Plaats = value;
                save();
            }
        }

        public String Straat
        {
            get
            {
                return getSet().Straat;
            }
            set
            {
                getSet().Straat = value;
                save();
            }
        }
        
        public String Huisnummer
        {
            get
            {
                return getSet().Huisnummer;
            }
            set
            {
                getSet().Huisnummer = value;
                save();
            }
        }
        
        public String Postcode
        {
            get
            {
                return getSet().Postcode;
            }
            set
            {
                getSet().Postcode = value;
                save();
            }
        }
        
        public int bedrijfset_Bedrijfs_Id
        {
            get
            {
                return getSet().bedrijfset_Bedrijfs_Id;
            }
            private set
            {
                getSet().bedrijfset_Bedrijfs_Id = value;
                save();
            }
        }

        public int docentset_Id
        {
            get
            {
                return getSet().docentset_Id;
            }
            private set
            {
                getSet().docentset_Id = value;
                save();
            }
        }

        public WDocent Docent
        {
            get
            {
                return new WDocent(getSet().docentset);
            }
            set
            {
                getSet().docentset = value.getSet();
                docentset_Id = value.Id;
                save();
            }
        }

        public WBedrijf Bedrijf
        {
            get
            {
                return new WBedrijf(getSet().bedrijfset);
            }
            set
            {
                getSet().bedrijfset = value.getSet();
                save();
            }
        }

        public WAdres(adresset set)
            : base(set)
        {
        }
    }
}