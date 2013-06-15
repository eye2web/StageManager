using Caliburn.Micro;
using StageManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StageManager.ViewModels
{
    class StudentViewModel : PropertyChangedBase
    {
        private static Random random = new Random();
        private WStudent Student = new WStored().SearchStudentSet("", "")[random.Next(new WStored().SearchStudentSet("", "").Count)];

        public string Voornaam
        {
            get { return Student.Voornaam; }
            set
            {
                Student.Voornaam = value;
                NotifyOfPropertyChange(() => Voornaam);
            }
        }

        public String Achternaam
        {
            get
            {
                return Student.Achternaam;
            }
            set
            {
                Student.Achternaam = value;
                NotifyOfPropertyChange(() => Achternaam);
            }
        }

        public int Studentnummer
        {
            get { return Student.Studentnummer; }
            set
            {
                Student.Studentnummer = value;
                NotifyOfPropertyChange(() => Studentnummer);
            }
        }
        public string Opleiding
        {
            get { return Student.Opleidingset.Naam; }
            set
            {
                Student.Opleidingset.Naam = value;
                NotifyOfPropertyChange(() => Opleiding);
            }
        }

       
        public string Emailadres
        {
            get { return Student.Email; }
            set
            {
                Student.Email = value;
                NotifyOfPropertyChange(() => Emailadres);
            }
        }
        public string Telefoonnummer
        {
            get { return Student.Telefoonnummer; }
            set
            {
                Student.Telefoonnummer = value;
                NotifyOfPropertyChange(() => Telefoonnummer);
            }
        }

        public StudentViewModel(MainViewModel main, WStudent student)
        {
            Main = main;
            Student = student;
        }

        public MainViewModel Main { get; set; }
    }
}
