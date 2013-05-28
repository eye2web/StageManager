using StageManager.Models;
using StageManager.MVVM;
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
                OnPropertyChanged("SearchString");
                GridContents = (from student in WStored.SearchStudentSet(SearchString, "")
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
                OnPropertyChanged("GridContents");
            }
        }

        public ZoekViewModel()
        {
            SearchString = "";
            searchString = "Trefwoord(en)";
        }
    }
}
