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
    public class ZoekViewModel : PropertyChanged
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
        public Dictionary<Object, WStudent> List
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
        public WStudent SelectedStudent
        {
            get { return selectedStudent; }
            set { selectedStudent = value; }
        }

        public object SelectedObject
        {
            get
            {
                return selectedStudent;
            }
            set
            {
                List.TryGetValue(value, out selectedStudent);
                Main.ChangeButton("Koppel", new List<Object>() { selectedStudent.stagesets }, Services.Clear.No);

            }
        }

        public void Test(WStudent student)
        {
            bool b = false;
        }

        public ZoekViewModel(MainViewModel main)
        {
            Main = main;
            OpleidingStack = (from opleiding in new WStored().SearchOpleidingSet() select opleiding.Naam).ToList();
            searchStudent();
        }

        public ZoekViewModel(MainViewModel main, String zoekString)
            : this(main)
        {
            SearchString = zoekString;
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
    }
}
