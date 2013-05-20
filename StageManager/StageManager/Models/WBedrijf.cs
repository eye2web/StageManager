using StageManager.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StageManager.Models
{
    class WBedrijf:Wrapper<bedrijfset>
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
            }
        }

        public List<WAdres> AdresSets
        {
            get
            {
                List<WAdres> list = new List<WAdres>();
                for (int i = 0; i < getSet().adressets.Count; i++)
                {
                    list.Add(new WAdres(getSet().adressets.ElementAt(i)));
                }
                return list;
            }
            set
            {
                List<adresset> list = new List<adresset>();
                for (int i = 0; i < value.Count; i++)
                {
                    list.Add(value[i].getSet());
                }
                getSet().adressets = list;
                save(getSet());
            }
        }

        public List<WBedrijfsBegeleider> BedrijfsbegeleiderSets
        {
            get
            {
                List<WBedrijfsBegeleider> list = new List<WBedrijfsBegeleider>();
                for (int i = 0; i < getSet().adressets.Count; i++)
                {
                    list.Add(new WBedrijfsBegeleider(getSet().bedrijfsbegeleidersets.ElementAt(i)));
                }
                return list;
            }
            set
            {
                List<bedrijfsbegeleiderset> list = new List<bedrijfsbegeleiderset>();
                for (int i = 0; i < value.Count; i++)
                {
                    list.Add(value[i].getSet());
                }
                getSet().bedrijfsbegeleidersets = list;
                save(getSet());
            }
        }

        public WBedrijf(bedrijfset set)
            : base(set)
        {
        }
    }
}
