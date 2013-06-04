using StageManager.Models;
using StageManager.MVVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StageManager.ViewModels
{
    public class ProcesOverzichtViewModel : PropertyChangedBase
    {
        /*
         * ("", "m.aydin4@student.avans.nl", "Aydin, Murat", "Hyacinthenstraat 15", "Ingeleverd", "In orde", "Bob Bus"))
         */

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

        public ProcesOverzichtViewModel()
        {
            GridContents = (from student in new WStored().SearchStudentSet("", "")
                            select (Object)new
                            {
                                Email = student.Email,
                                EmailURL = "mailto:" + student.Email,
                                StudentNaam = student.Achternaam + ", " + student.Voornaam,
                                Gegevens = "Adres komt hier",
                                Stageopdracht = true,
                                Feedback = "Geen",
                                Docent = "Docent"
                            }).ToList();
        }
    }
}

