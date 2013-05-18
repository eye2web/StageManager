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

        private String searchText;

        public String SearchText
        {
            get { return searchText; }
            set
            {
                searchText = value;
                OnPropertyChanged("SearchText");
            }
        }

        public AlgemeenViewModel()
        {            
            //FillView();
        }

        //Vul grid
        public void FillView()
        {
            stagemanagerEntities smE = new stagemanagerEntities();
            GritContents = smE.algemeensets.ToList();
        }

        //Sla een object op
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

        //Zoek de eerste entry
        public void SearchAlgemeenSet()
        {
            stagemanagerEntities smE = new stagemanagerEntities();
            if (smE.algemeensets.Any(x => (x.Jaargang == SearchText || x.Werk_Uren == SearchText || x.Blokken == SearchText)))
            {
                algemeenset aS = smE.algemeensets.ToList().Where(x => (x.Jaargang == SearchText || x.Werk_Uren == SearchText || x.Blokken == SearchText)).First();
                Jaargang = aS.Jaargang;
                Werkuren = aS.Werk_Uren;
                AantBlokken = aS.Blokken;

                GritContents = smE.SearchAlgemeenSet(SearchText).ToList();
            }
            else
            {
                SearchText = "No Such Records";
                FillView();
            }
        }

        //Gevonde entry aanpassen
        public void UpdateAlgemeenSet()
        {
            stagemanagerEntities smE = new stagemanagerEntities();
                algemeenset aS = smE.algemeensets.ToList().Where(x => (x.Jaargang == SearchText || x.Werk_Uren == SearchText || x.Blokken == SearchText)).First();

                aS.Jaargang = (String)Jaargang;
                aS.Werk_Uren = (String)Werkuren;
                aS.Blokken = (String)AantBlokken;

                smE.SaveChanges();

                FillView();
        }
        
        //Gevonde entry verwijderen
        public void DeleteAlgemeenSet()
        {
            stagemanagerEntities smE = new stagemanagerEntities();
            algemeenset aS = smE.algemeensets.ToList().Where(x => (x.Jaargang == SearchText || x.Werk_Uren == SearchText || x.Blokken == SearchText)).First();
            smE.algemeensets.Remove(aS);

            smE.SaveChanges();

            FillView();
        }
    }
}
