using StageManager.Models;
using StageManager.MVVM;
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
        private WStage stage = WStored.SearchStageSet()[random.Next(WStored.SearchStageSet().Count)];

        public DateTime? StartDatum
        {
            get { return stage.Start_datum; }
            set
            {
                stage.Start_datum = value;
                //OnPropertyChanged(StartDatum);
            }
        }

        public DateTime? EindDatum
        {
            get { return stage.Eind_datum; }
            set
            {
                stage.Eind_datum = value;
                //OnPropertyChanged(StartDatum);
            }
        }

        public string Omschrijving
        {
            get {  return stage.Stageopdracht_omschijving; }
            set
            {
                stage.Stageopdracht_omschijving = value;
                OnPropertyChanged(Omschrijving);
            }
        }
    }
}