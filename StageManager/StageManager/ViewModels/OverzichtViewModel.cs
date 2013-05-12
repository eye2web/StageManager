using StageManager.Controllers;
using StageManager.MVVM;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StageManager.ViewModels
{
    public class OverzichtViewModel : PropertyChangedBase
    {
        ObservableCollection<StudentGegevens> _StudentGegevensCollection = new ObservableCollection<StudentGegevens>();

        public OverzichtViewModel()
        {
            TestData();
        }

        private void TestData()
        {
            _StudentGegevensCollection.Add(new StudentGegevens
            {
                StudentNaam = "Bob Janssen",
                Gegevens = "Compleet",
                Stageopdracht = "Aanwezig",
                Email = "bob@avans.nl"
            });
            _StudentGegevensCollection.Add(new StudentGegevens
            {
                StudentNaam = "Henk Willemsen",
                Gegevens = "Incompleet",
                Stageopdracht = "Ontbreekt",
                Email = "henk@avans.nl"
            });
            _StudentGegevensCollection.Add(new StudentGegevens
            {
                StudentNaam = "Jacob Hendriks",
                Gegevens = "Ontbreekt",
                Stageopdracht = "Aanwezig",
                Email = "jacob@avans.nl"
            });
            _StudentGegevensCollection.Add(new StudentGegevens
            {
                StudentNaam = "Karel Noten",
                Gegevens = "Compleet",
                Stageopdracht = "Aanwezig",
                Email = "karel@avans.nl"
            });
        }

        public ObservableCollection<StudentGegevens> StudentGegevensCollection { get { return _StudentGegevensCollection; } }
    }

    public class StudentGegevens 
    {
        public string StudentNaam {get; set;}
        public string Gegevens {get; set;}
        public string Stageopdracht {get; set;}
        public string Email {get; set;}
        public string EmailURL { get; set; }

        public StudentGegevens()
        {
            EmailURL = "mailto:" + Email;
        }
    }
}
