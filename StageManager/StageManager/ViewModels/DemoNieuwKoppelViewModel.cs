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
                searchStudent();                
                OnPropertyChanged("SearchString");
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
                OnPropertyChanged("SearchOpleiding");
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

        private WStudent selectedStudent;
        public Object SelectedStudent
        {

            get { return selectedStudent; }
            set
            {
                selectedStudent = WStored.SearchStudentSet(value.GetType().GetProperty("StudentNummer").GetMethod.Invoke(value, null).ToString(), "").First();
                KoppelStudent = selectedStudent;
                OnPropertyChanged("SelectedStudent");
            }
        }

        private WStudent koppelStudent;
        public WStudent KoppelStudent
        {

            get { return koppelStudent; }
            set
            {
                koppelStudent = value;
                KoppelStudentNaam = koppelStudent.Achternaam + ", " + koppelStudent.Voornaam;
                OnPropertyChanged("KoppelStudent");
            }
        }

        private String koppelStudentNaam = "<geselecteerde student>";
        public String KoppelStudentNaam
        {

            get { return koppelStudentNaam; }
            set
            {
                koppelStudentNaam = value;
                OnPropertyChanged("KoppelStudentNaam");
            }
        }

        private WDocent selectedDocent;
        public Object SelectedDocent
        {

            get { return selectedDocent; }
            set
            {
                selectedDocent = WStored.SearchDocentSet(value.GetType().GetProperty("Voornaam").GetMethod.Invoke(value, null).ToString()).First();
                KoppelDocent = selectedDocent;
                OnPropertyChanged("SelectedDocent");
            }
        }

        private WDocent koppelDocent;
        public WDocent KoppelDocent
        {

            get { return koppelDocent; }
            set
            {
                koppelDocent = value;
                KoppelDocentNaam = koppelDocent.Achternaam + ", " + koppelDocent.Voornaam;
                OnPropertyChanged("KoppelDocent");
            }
        }

        private String koppelDocentNaam = "<geselecteerde docent>";
        public String KoppelDocentNaam
        {

            get { return koppelDocentNaam; }
            set {
                koppelDocentNaam = value;
                OnPropertyChanged("KoppelDocentNaam");
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
            DocentGridContents = WStored.SearchDocentSet(null);
            LezerGridContents = WStored.SearchDocentSet(null);
        }

        public void searchStudent()
        {
            StudentGridContents = (from student in WStored.SearchStudentSet(searchString, searchOpleiding)
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
}
