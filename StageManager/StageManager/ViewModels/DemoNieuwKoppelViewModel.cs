﻿using StageManager.MVVM;
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

        private String searchString;

        public String SearchString
        {
            get { return searchString; }
            set {
                searchString = value;
                FillView(SearchString);
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
            stagemanagerEntities smE = new stagemanagerEntities();
            StudentGridContents = WStored.SearchStudentSet(SearchString);
            DocentGridContents = WStored.SearchDocentSet();
        }
    }
}
