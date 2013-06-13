using Caliburn.Micro;
using StageManager.Models;
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

        private Dictionary<Object, WStudent> list;
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

        private List<WStudent> selectedStudents;
        public List<Object> SelectedStudents
        {
            get
            {
                return (from s in selectedStudents select (Object)s).ToList();
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Count; i++)
                    {
                        WStudent s = null;
                        List.TryGetValue(value[i], out s);
                        selectedStudents.Add(s);
                    }
                    NotifyOfPropertyChange(() => SelectedStudents);
                }
            }
        }

        public ProcesOverzichtViewModel()
        {
            selectedStudents = new List<WStudent>();
            List = new Dictionary<object, WStudent>();
            List = new WStored().SearchStudentSet("", "").ToDictionary(t => (Object)new
                            {
                                Email = t.Email,
                                EmailURL = "mailto:" + t.Email,
                                StudentNaam = t.Achternaam + ", " + t.Voornaam,
                                Gegevens = "Adres komt hier",
                                Stageopdracht = true,
                                Feedback = "Geen",
                                Docent = "Docent"
                            }, t => t);
        }
    }
}

