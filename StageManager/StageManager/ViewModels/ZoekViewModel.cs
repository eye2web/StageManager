using Caliburn.Micro;
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

        public ZoekViewModel()
        {
            SearchString = "";
            searchString = "Trefwoord(en)";
            OpleidingStack = (from opleiding in new WStored().SearchOpleidingSet() select opleiding.Naam).ToList();

        }

        public void searchStudent()
        {
            List<Object> list = new List<object>();
            list = (from student in new WStored().SearchStudentSet(searchString, searchOpleiding)
                    select (Object)new
                    {
                        StudentNummer = student.Studentnummer,
                        Voornaam = student.Voornaam,
                        Achternaam = student.Achternaam,
                        Opleiding = student.Opleidingset.Naam,
                        EC_Norm_Behaald = student.EC_norm_behaald

                    }).ToList();
            if (list.Count == 0)
            {
                list.Add((Object)new
                {
                    Error = "No occurrences found!"
                });

            }
                GridContents = list;
        }
    }
}
