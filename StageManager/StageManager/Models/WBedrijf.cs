using StageManager.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StageManager.Models
{
    class WBedrijf:Wrapper<bedrijfsets>
    {
        public int Id
        {
            get
            {
                return getSet().Bedrijfs_Id;
            }
            set
            {
                getSet().Bedrijfs_Id = value;
                save();
            }
        }

        public String Naam
        {
            get
            {
                return getSet().Naam;
            }
            set
            {
                getSet().Naam = value;
                save();
            }
        }

        public int? TelefoonNummer
        {
            get
            {
                return getSet().Telefoonnummer;
            }
            set{
                getSet().Telefoonnummer = value;
                save();
            }
        }

        public String Website
        {
            get
            {
                return getSet().Website;
            }
            set
            {
                getSet().Website = value;
                save();
            }
        }

        public WAdres AdresSets
        {
            get
            {
                return new WAdres(getSet().adressets);
            }
            set
            {
                getSet().adressets = value.getSet();
                save();
            }
        }

        public List<WBedrijfsBegeleider> Bedrijfsbegeleidersets
        {
            get
            {
                List<WBedrijfsBegeleider> list = new List<WBedrijfsBegeleider>();
                for (int i = 0; i < getSet().bedrijfsbegeleidersets.Count; i++)
                {
                    list.Add(new WBedrijfsBegeleider(getSet().bedrijfsbegeleidersets.ElementAt(i)));
                }
                return list;
            }
            set
            {
                List<bedrijfsbegeleidersets> list = new List<bedrijfsbegeleidersets>();
                for (int i = 0; i < value.Count; i++)
                {
                    list.Add(value[i].getSet());
                }
                getSet().bedrijfsbegeleidersets = list;
                save();
            }
        }

        public WBedrijf(bedrijfsets set)
            : base(set)
        {
        }
    }
}
