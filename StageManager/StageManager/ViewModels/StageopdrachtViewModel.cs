using Caliburn.Micro;
using StageManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StageManager.ViewModels
{
    class StageopdrachtViewModel : PropertyChangedBase
    {
        private static Random random = new Random();
        private WStage stage = new WStored().SearchStageSet()[random.Next(new WStored().SearchStageSet().Count)];

        public DateTime? StartDatum
        {
            get { return stage.Start_datum; }
            set
            {
                stage.Start_datum = value;
                NotifyOfPropertyChange(() => StartDatum);
            }
        }

        public DateTime? EindDatum
        {
            get { return stage.Eind_datum; }
            set
            {
                stage.Eind_datum = value;
                NotifyOfPropertyChange(() => EindDatum);
            }
        }

        public string Omschrijving
        {
            get {  return stage.Stageopdracht_omschijving; }
            set
            {
                stage.Stageopdracht_omschijving = value;
                NotifyOfPropertyChange(() => Omschrijving);
            }
        }

        public string EersteStudent
        {
            get 
            {
                try
                {
                    return stage.studentset2.Voornaam + " " + stage.studentset2.Achternaam;
                }
                catch (NullReferenceException)
                {
                    return "";
                }
            }
            set { }
        }

        public string TweedeStudent
        {
            get 
            {
                try
                {
                    return stage.studentset.Voornaam + " " + stage.studentset.Achternaam;;
                }
                catch (NullReferenceException)
                {
                    return "";
                }
            }
            set { }
        }

        public string Bedrijfsbegeleider
        {
            get
            {
                try
                {
                    return stage.bedrijfsbegeleiderset.Voornaam + " " + stage.bedrijfsbegeleiderset.Achternaam;
                }
                catch (NullReferenceException)
                {
                    return "";
                }
            }
            set { }
        }

        public string Docent
        {
            get
            {
                try
                {
                    return stage.docentsets.Voornaam + " " + stage.docentsets.Achternaam;
                }
                catch (NullReferenceException)
                {
                    return "";
                }
            }
            set { }
        }
    }
}