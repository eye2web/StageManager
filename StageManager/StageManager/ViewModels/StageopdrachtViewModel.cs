﻿using Caliburn.Micro;
using StageManager.Models;
using StageManager.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StageManager.ViewModels
{
    class StageopdrachtViewModel : PropertyChanged
    {
        private static Random random = new Random();
        private WStage stage = new WStored().SearchStageSet()[random.Next(new WStored().SearchStageSet().Count)];

        internal WStage Stage
        {
            get { return stage; }
            set
            {
                stage = value;
                NotifyOfPropertyChange(() => StartDatum);
                NotifyOfPropertyChange(() => Bedrijfsbegeleider);
                NotifyOfPropertyChange(() => Docent);
                NotifyOfPropertyChange(() => EersteStudent);
                NotifyOfPropertyChange(() => EindDatum);
                NotifyOfPropertyChange(() => Omschrijving);
                NotifyOfPropertyChange(() => TweedeStudent);
            }
        }

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
                    return stage.docentsets.Voornaam + " " + stage.docentsets.Achternaam;
                }
                catch (NullReferenceException)
                {
                    return "";
                }
            }
            set { }
        }

        public StageopdrachtViewModel(MainViewModel main)
            :base(main)
        {
        }

        public StageopdrachtViewModel(MainViewModel main, WStage stage)
            : this(main)
        {
            Stage = stage;
        }

        public override void update(object[] o)
        {
            try
            {
                Stage = (WStage)o[1];
            }
            catch (Exception)
            {
                
                throw;
            }
        }
    }
}