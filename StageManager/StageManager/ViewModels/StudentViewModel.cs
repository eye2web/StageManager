using Caliburn.Micro;
using StageManager.Models;
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
        private WStudent student = new WStored().SearchStudentSet("", "")[random.Next(new WStored().SearchStudentSet("", "").Count)];

        public string Voornaam
        {
            get { return student.Voornaam; }
            set
            {
                student.Voornaam = value;
                NotifyOfPropertyChange(() => Voornaam);
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
                NotifyOfPropertyChange(() => Achternaam);
            }
        }

        public int Studentnummer
        {
            get { return student.Studentnummer; }
            set
            {
                student.Studentnummer = value;
                NotifyOfPropertyChange(() => Studentnummer);
            }
        }
        public string Opleiding
        {
            get { return student.Opleidingset.Naam; }
            set
            {
                student.Opleidingset.Naam = value;
                NotifyOfPropertyChange(() => Opleiding);
            }
        }

       
        public string Emailadres
        {
            get { return student.Email; }
            set
            {
                student.Email = value;
                NotifyOfPropertyChange(() => Emailadres);
            }
        }
        public string Telefoonnummer
        {
            get { return student.Telefoonnummer; }
            set
            {
                student.Telefoonnummer = value;
                NotifyOfPropertyChange(() => Telefoonnummer);
            }
        }
    }
}
