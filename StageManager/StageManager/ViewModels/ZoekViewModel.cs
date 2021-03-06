﻿using Caliburn.Micro;
using StageManager.Models;
using StageManager.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StageManager.ViewModels
{
    public class ZoekViewModel : PropertyChanged
    {
        private String searchString;

        public String SearchString
        {
            get { return searchString; }
            set
            {
                searchString = value;
                searchStage();
                NotifyOfPropertyChange(() => SearchString);
            }
        }

        private List<String> opleidingStack;
        public List<String> OpleidingStack
        {
            get { return opleidingStack; }
            set
            {
                opleidingStack = value;
                NotifyOfPropertyChange(() => OpleidingStack);
            }
        }             

        private String searchOpleiding;
        public String SearchOpleiding
        {
            get { return searchOpleiding; }
            set
            {
                searchOpleiding = value;
                searchStage();
                NotifyOfPropertyChange(() => SearchOpleiding);
            }
        }

        private Dictionary<Object,WStage> list;
        public Dictionary<Object, WStage> List
        {
            get
            {
                return list;
            }
            set
            {
                list = value;
                GridContents = value.Keys.ToList();
                NotifyOfPropertyChange(() => List);
            }
        }

        private List<Object> gridContents;
        public List<object> GridContents
        {
            get
            {
                return gridContents;
            }
            set
            {
                gridContents = value;
                NotifyOfPropertyChange(() => GridContents);
            }
        }

        private WStage selectedStage;
        public WStage SelectedStage
        {
            get { return selectedStage; }
            set { selectedStage = value; }
        }

        public object SelectedObject
        {
            get
            {
                return selectedStage;
            }
            set
            {
                List.TryGetValue(value, out selectedStage);
                Main.ChangeButton("Koppel", new List<Object>() { selectedStage }, Services.Clear.No);

            }
        }

        public void Test(WStudent student)
        {
            Main.ChangeButton("Student", new List<object>() { student }, Clear.After, this);
        }

        public ZoekViewModel(MainViewModel main)
            :base(main)
        {
            OpleidingStack = (from opleiding in new WStored().SearchOpleidingSet() select opleiding.Naam).ToList();
            searchStage();
        }

        public ZoekViewModel(MainViewModel main, String zoekString)
            : this(main)
        {
            SearchString = zoekString;
        }

        public void searchStage(String searchString = "", String searchOpleiding = "")
        {
            List = new Dictionary<object, WStage>();
            List<WStage> stages = new WStored().SearchStage(false);
 
             List<WStudent> studenten = new List<WStudent>();
 
             for (int i = 0; i < stages.Count; i++)
            {
                if (stages[i].studentset != null)
                {
                     bool contains = false;
                     for (int j = 0; j < studenten.Count; j++)
                     {
                         if (stages[i].studentset.getSet() == studenten[j].getSet())
                         {
                             contains = true;
                             break;
                         }
                     }

                     if (!contains&&(foundString(stages[i].studentset, searchString,searchOpleiding)))
                     {
                         studenten.Add(stages[i].studentset);
                     }
                 }
                 if (stages[i].studentset2 != null)
                 {
                     bool contains = false;
                     for (int j = 0; j < studenten.Count; j++)
                     {
                         if (stages[i].studentset2.getSet() == studenten[j].getSet())
                         {
                             contains = true;
                             break;
                         }
                     }

                     if (!contains && (foundString(stages[i].studentset, searchString, searchOpleiding)))
                     {
                         studenten.Add(stages[i].studentset2);
                     }
                 }
             }
             list = new Dictionary<object, WStage>();//TODO
             list = (stages.ToDictionary(t=>(Object)new
                    {
                            Stage = t.Stageopdracht_omschijving,
                            Studentnummer = t.studentset.Studentnummer,
                            Voornaam = t.studentset.Voornaam,
                            Achternaam = t.studentset.Achternaam,
                            Opleiding = t.studentset.Opleidingset.Naam,
                            EC_Norm_Behaald = t.studentset.EC_norm_behaald
                    },t=>t));
            if (list.Count == 0)
            {
                list.Add((Object)new
                {
                    Error = "No occurrences found!"
                },null);

            }
                GridContents = list.Keys.ToList();
        }

        public override void update(object[] o)
        {
            try
            {
                SearchString = (String)o[1];
            }
            catch (Exception)
            {
            }
        }

        private bool foundString(WStudent wStudent, String searchString, String searchOpleiding)
        {
            return ((wStudent.Achternaam.Contains(searchString)
                || wStudent.Voornaam.Contains(searchString)
                || wStudent.Telefoonnummer.Contains(searchString)
                || wStudent.Email.Contains(searchString)
                || wStudent.Opleidingset.Naam.Contains(searchString)));
        }
    }
}
