using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StageManager.Models;
using StageManager.Views;
using StageManager.Controllers;
using Caliburn.Micro;

namespace StageManager.ViewModels
{
    class AlgemeenViewModel : PropertyChangedBase
    {
        private List<algemeensets> gridContents;

        public List<algemeensets> GridContents
        {
            get { return gridContents; }
            set { gridContents = value;
            NotifyOfPropertyChange(() => GridContents);
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
                    NotifyOfPropertyChange(() => Jaargang);
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
                    NotifyOfPropertyChange(() => Werkuren);
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
                    NotifyOfPropertyChange(() => AantBlokken);
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
                NotifyOfPropertyChange(() => SearchText);
            }
        }

        public AlgemeenViewModel()
        {            
            FillView();
        }

        //Vul grid
        public void FillView()
        {
            stagemanagerEntities smE = new stagemanagerEntities();
            GridContents = smE.algemeensets.ToList();
        }

        //Sla een object op
        public void SaveAlgemeenSet()
        {           
            stagemanagerEntities smE = new stagemanagerEntities();
            algemeensets aS = new algemeensets();
 
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
                algemeensets aS = smE.algemeensets.ToList().Where(x => (x.Jaargang == SearchText || x.Werk_Uren == SearchText || x.Blokken == SearchText)).First();
                Jaargang = aS.Jaargang;
                Werkuren = aS.Werk_Uren;
                AantBlokken = aS.Blokken;

                GridContents = smE.SearchAlgemeenSet(SearchText).ToList();
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
                algemeensets aS = smE.algemeensets.ToList().Where(x => (x.Jaargang == SearchText || x.Werk_Uren == SearchText || x.Blokken == SearchText)).First();

                aS.Jaargang = (String)Jaargang;
                aS.Werk_Uren = (String)Werkuren;
                aS.Blokken = (String)AantBlokken;

                int i = smE.SaveChanges();

                FillView();
        }
        
        //Gevonde entry verwijderen
        public void DeleteAlgemeenSet()
        {
            stagemanagerEntities smE = new stagemanagerEntities();
            algemeensets aS = smE.algemeensets.ToList().Where(x => (x.Jaargang == SearchText || x.Werk_Uren == SearchText || x.Blokken == SearchText)).First();
            smE.algemeensets.Remove(aS);

            smE.SaveChanges();

            FillView();
        }
    }
}
