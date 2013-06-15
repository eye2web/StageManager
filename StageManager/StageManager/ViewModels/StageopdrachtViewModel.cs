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
        private WStage Stage = new WStored().SearchStageSet()[random.Next(new WStored().SearchStageSet().Count)];

        public DateTime? StartDatum
        {
            get { return Stage.Start_datum; }
            set
            {
                Stage.Start_datum = value;
                NotifyOfPropertyChange(() => StartDatum);
            }
        }

        public DateTime? EindDatum
        {
            get { return Stage.Eind_datum; }
            set
            {
                Stage.Eind_datum = value;
                NotifyOfPropertyChange(() => EindDatum);
            }
        }

        public string Omschrijving
        {
            get {  return Stage.Stageopdracht_omschijving; }
            set
            {
                Stage.Stageopdracht_omschijving = value;
                NotifyOfPropertyChange(() => Omschrijving);
            }
        }

        public string EersteStudent
        {
            get 
            {
                try
                {
                    return Stage.studentset2.Voornaam + " " + Stage.studentset2.Achternaam;
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
                    return Stage.studentset.Voornaam + " " + Stage.studentset.Achternaam;;
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
                    //return stage.bedrijfsbegeleiderset.Voornaam + " " + stage.bedrijfsbegeleiderset.Achternaam;
                }
                catch (NullReferenceException)
                {
                    return "";
                }
                return "Geen BedrijfsBegeleider gekoppeld";
            }
            set { }
        }

        public string Docent
        {
            get
            {
                try
                {
                    return Stage.docentsets.Voornaam + " " + Stage.docentsets.Achternaam;
                }
                catch (NullReferenceException)
                {
                    return "";
                }
            }
            set { }
        }

        public StageopdrachtViewModel(MainViewModel main, WStage stage)
        {
            Main = main;
            Stage = stage;
        }

        public MainViewModel Main { get; set; }
    }
}