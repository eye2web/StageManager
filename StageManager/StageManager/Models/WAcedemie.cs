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
    class WAcedemie:Wrapper<acedemieset>
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
    
        public WAcedemie(acedemieset set)
            :base(set)
        {
            if (set == null)
            {
                throw new CantBeNullException("Acedemie");
            }
        }
    }
}