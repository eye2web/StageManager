using StageManager.Exceptions;
using StageManager.MVVM;
using StageManager.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StageManager.Models
{
    class WAcedemie:Wrapper<acedemiesets>
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

        public List<WOpleiding> opleidingsets
        {
            get
            {
                List<WOpleiding> oplSet = new List<WOpleiding>();
                for (int i = 0; i < getSet().opleidingsets.Count; i++)
                {
                    oplSet.Add(new WOpleiding(getSet().opleidingsets.ElementAt(i)));
                }
                return oplSet;
            }
            set
            {
                List<opleidingsets> list = new List<opleidingsets>();
                for (int i = 0; i < value.Count; i++)
                {
                    list.Add(value[i].getSet());
                }
                getSet().opleidingsets = list;
                save();
            }
        }
    
        public WAcedemie(acedemiesets set)
            :base(set)
        {
        }
    }
}
