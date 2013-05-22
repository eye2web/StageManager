using StageManager.MVVM;
using StageManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StageManager.ViewModels
{
    public class DemoNieuwKoppelViewModel : PropertyChangedBase
    {
//private List<WStudent> gritContents;

    /*   public List<WStudent> GritContents
        {
            get { return gritContents; }
            set
            {
                gritContents = value;
                OnPropertyChanged("GritContents");
            }
     }
    */    

        public DemoNieuwKoppelViewModel()
        {            
            FillView();
        }

        //Vul grid
        public void FillView()
        {
            stagemanagerEntities smE = new stagemanagerEntities();
           // GritContents =;
        }
    }
}
