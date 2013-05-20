using StageManager.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StageManager.Models
{
    class WAdres:Wrapper<adressets>
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
        

        public WAdres(adressets set)
            : base(set)
        {
        }
    }
}