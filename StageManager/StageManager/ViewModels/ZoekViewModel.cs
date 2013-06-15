﻿using Caliburn.Micro;
using StageManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StageManager.ViewModels
{
    public class ZoekViewModel : PropertyChangedBase
    {
        private String searchString;

        public String SearchString
        {
            get { return searchString; }
            set
            {
                searchString = value;
                searchStudent();
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
                searchStudent();
                NotifyOfPropertyChange(() => SearchOpleiding);
            }
        }

        private Dictionary<Object,WStudent> list;
        Dictionary<Object, WStudent> List
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

        private WStudent selectedStudent;

        internal WStudent SelectedStudent
        {
            get { return selectedStudent; }
            set { selectedStudent = value;
            Main.ChangeButton("Koppel", new List<Object>(){SelectedStudent}, Services.Clear.No);
            }
        }
        public object SelectedObject
        {
            get
            {
                return SelectedStudent;
            }
            set
            {
                WStudent s;
                List.TryGetValue(value, out s);
                SelectedStudent = s;
            }
        }

        public ZoekViewModel(MainViewModel main,String zoekString)
        {
            Main = main;
            SearchString = zoekString;
            OpleidingStack = (from opleiding in new WStored().SearchOpleidingSet() select opleiding.Naam).ToList();

        }

        public void searchStudent()
        {
            list = new Dictionary<object, WStudent>();
            list = (new WStored().SearchStudentSet(searchString, searchOpleiding).ToDictionary(t=>(Object)new
                    {
                            StudentNummer = t.Studentnummer,
                            Voornaam = t.Voornaam,
                            Achternaam = t.Achternaam,
                            Opleiding = t.Opleidingset.Naam,
                            EC_Norm_Behaald = t.EC_norm_behaald
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

        public MainViewModel Main { get; set; }
    }
}
