using StageManager.MVVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StageManager.ViewModels
{
    class StudentViewModel : PropertyChangedBase
    {
        private string naam;
        private int studentnummer;
        private string opleiding;
        private string adres;
        private string postcode;
        private string woonplaats;
        private string telefoonnummer;
        private string emailadres;

        public string Naam
        {
            get { return naam; }
            set
            {
                naam = value;
                OnPropertyChanged("Naam");
            }
        }
        public int Studentnummer
        {
            get { return studentnummer; }
            set
            {
                studentnummer = value;
                OnPropertyChanged("Studentnummer");
            }
        }
        public string Opleiding
        {
            get { return opleiding; }
            set
            {
                opleiding = value;
                OnPropertyChanged("Opleiding");
            }
        }
        public string Adres
        {
            get { return adres; }
            set
            {
                adres = value;
                OnPropertyChanged("Adres");
            }
        }
        public string Postcode
        {
            get { return postcode; }
            set
            {
                postcode = value;
                OnPropertyChanged("Postcode");
            }
        }
        public string Woonplaats
        {
            get { return woonplaats; }
            set
            {
                woonplaats = value;
                OnPropertyChanged("Woonplaats");
            }
        }
        public string Emailadres
        {
            get { return emailadres; }
            set
            {
                emailadres = value;
                OnPropertyChanged("Emailadres");
            }
        }
        public string Telefoonnummer
        {
            get { return telefoonnummer; }
            set
            {
                telefoonnummer = value;
                OnPropertyChanged("telefoonnummer");
            }
        }
    }
}
