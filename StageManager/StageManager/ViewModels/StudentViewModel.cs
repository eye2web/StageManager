using StageManager.Models;
using StageManager.MVVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StageManager.ViewModels
{
    public class StudentViewModel : PropertyChangedBase
    {
        private static Random random = new Random();
        private WStudent student = WStored.SearchStudentSet()[random.Next(WStored.SearchStudentSet().Count)];

        public string Voornaam
        {
            get { return student.Voornaam; }
            set
            {
                student.Voornaam = value;
                OnPropertyChanged("Voornaam");
            }
        }

        public String Achternaam
        {
            get
            {
                return student.Achternaam;
            }
            set
            {
                student.Achternaam = value;
                OnPropertyChanged("Achternaam");
            }
        }

        public int Studentnummer
        {
            get { return student.Studentnummer; }
            set
            {
                student.Studentnummer = value;
                OnPropertyChanged("Studentnummer");
            }
        }
        public string Opleiding
        {
            get { return student.Opleidingset.Naam; }
            set
            {
                student.Opleidingset.Naam = value;
                OnPropertyChanged("Opleiding");
            }
        }

       
        public string Emailadres
        {
            get { return student.Email; }
            set
            {
                student.Email = value;
                OnPropertyChanged("Emailadres");
            }
        }
        public string Telefoonnummer
        {
            get { return student.Telefoonnummer; }
            set
            {
                student.Telefoonnummer = value;
                OnPropertyChanged("Telefoonnummer");
            }
        }
    }
}
