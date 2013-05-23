﻿using StageManager.Exceptions;
using StageManager.MVVM;
using StageManager.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StageManager.Models
{
    class WAcademie:Wrapper,ISetEntity<academieset>
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
                save(getSet());
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
                save(getSet());
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
                List<opleidingset> list = new List<opleidingset>();
                for (int i = 0; i < value.Count; i++)
                {
                    list.Add(value[i].getSet());
                }
                getSet().opleidingsets = list;
                save(getSet());
            }
        }
    
        public WAcademie(academieset set)
            :base()
        {
            if (set == null)
            {
                throw new CantBeNullException(set.GetType().Name + " is NULL");
            }
            this.set = set;
        }

        public academieset getSet()
        {
            return set;
        }

        private academieset set { get; set; }
    }
}
