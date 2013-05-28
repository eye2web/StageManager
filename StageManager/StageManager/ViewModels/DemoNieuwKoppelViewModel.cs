using StageManager.MVVM;
using StageManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StageManager.ViewModels
{
    class DemoNieuwKoppelViewModel : PropertyChangedBase
    {
        private List<Object> studentGridContents;

        public List<Object> StudentGridContents
        {
            get { return studentGridContents; }
            set
            {
                studentGridContents = value;
                OnPropertyChanged("StudentGridContents");
            }
        }

        private List<WDocent> docentGridContents;

        public List<WDocent> DocentGridContents
        {
            get { return docentGridContents; }
            set
            {
                docentGridContents = value;
                OnPropertyChanged("DocentGridContents");
            }
        }

        private List<WDocent> lezerGridContents;

        public List<WDocent> LezerGridContents
        {
            get { return lezerGridContents; }
            set
            {
                lezerGridContents = value;
                OnPropertyChanged("LezerGridContents");
            }
        }

        private String searchString;

        public String SearchString
        {
            get { return searchString; }
            set
            {
                searchString = value;
                StudentGridContents = (from student in WStored.SearchStudentSet(SearchString)
                                       select (Object)new
                                       {
                                           StudentNummer = student.Studentnummer,
                                           Voornaam = student.Voornaam,
                                           Achternaam = student.Achternaam,
                                           Opleiding = student.Opleidingset.Naam,
                                           EC_Norm_Behaald = student.EC_norm_behaald

                                       }).ToList();
            }
        }

        private List<String> opleidingStack;

        public List<String> OpleidingStack
        {
            get { return opleidingStack; }
            set { opleidingStack = value;
            OnPropertyChanged("OpleidingStack");
            }
        }

        public DemoNieuwKoppelViewModel()
        {
            SearchString = "";
            FillView(SearchString);
            OpleidingStack = (from opleiding in WStored.SearchOpleidingSet() select opleiding.Naam).ToList();
        }

        //Vul grid
        public void FillView(String SearchString)
        {
            searchString = "";
            DocentGridContents = WStored.SearchDocentSet();
            LezerGridContents = WStored.SearchDocentSet();
        }
    }
}
