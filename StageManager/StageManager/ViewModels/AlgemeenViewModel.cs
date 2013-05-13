using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StageManager.Models;
using StageManager.Views;
using StageManager.MVVM;
using StageManager.Controllers;

namespace StageManager.ViewModels
{
    class AlgemeenViewModel : PropertyChangedBase
    {
        private List<algemeenset> gritContents;

        public List<algemeenset> GritContents
        {
            get { return gritContents; }
            set { gritContents = value;
            OnPropertyChanged("GritContents");
            }
        }

        private int jaargang;
        public String Jaargang
        {
            get { return jaargang.ToString(); }
            set
            {
                if (int.TryParse(value, out jaargang))
                {
                    OnPropertyChanged("Jaargang");
                }
            }
        }

        private int werkuren;
        public String Werkuren
        {
            get { return werkuren.ToString(); }
            set
            {
                if (int.TryParse(value, out werkuren))
                {
                    OnPropertyChanged("Werkuren");
                }
            }
        
        }

        private int aantBlokken;

        public String AantBlokken
        {
            get { return aantBlokken.ToString();}
            set
            {
                if (int.TryParse(value, out aantBlokken))
                {
                    OnPropertyChanged("AantBlokken");
                }
            }
        }

        public AlgemeenViewModel()
        {
            Jaargang = "0";
            Werkuren = "0";
            AantBlokken = "0";
            
            FillView();
        }

        public void FillView()
        {
            stagemanagerEntities smE = new stagemanagerEntities();
            GritContents = smE.algemeensets.ToList();
        }    

        public void SaveAlgemeenSet()
        {           
            stagemanagerEntities smE = new stagemanagerEntities();
            algemeenset aS = new algemeenset();
 
            aS.Jaargang = (String)Jaargang;
            aS.Werk_Uren = (String)Werkuren;
            aS.Blokken = (String)AantBlokken;

            smE.algemeensets.Add(aS);
            smE.SaveChanges();

            FillView();
        }
    }
}
