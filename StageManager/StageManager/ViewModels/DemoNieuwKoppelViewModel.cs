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
        private List<WStudent> studentGridContents;

        public List<WStudent> StudentGridContents
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
            set {
                searchString = value;
                StudentGridContents = WStored.SearchStudentSet(SearchString);
            }
        }

        public DemoNieuwKoppelViewModel()
        {
            SearchString = "";
            FillView(SearchString);
        }

        //Vul grid
        public void FillView(String SearchString)
        {
            StudentGridContents = WStored.SearchStudentSet(SearchString);
            DocentGridContents = WStored.SearchDocentSet();
            LezerGridContents = WStored.SearchDocentSet();
        }
    }
}
