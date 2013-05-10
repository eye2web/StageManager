using StageManager.Controllers;
using StageManager.MVVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StageManager.Models;
using StageManager.Views;

namespace StageManager.ViewModels
{
    class AlgemeenViewModel : PropertyChangedBase
    {  
        private readonly IApplicationController app;
        private AlgemeenView aV;

        public AlgemeenViewModel(IApplicationController app,  AlgemeenView aV)
        {
            this.app = app;
            this.aV = aV;
        }

        public void SaveAlgemeenSet()
        {
            stagemanagerEntities smE = new stagemanagerEntities();
            algemeenset aS = new algemeenset();

            aS.Jaargang = aV.Jaargang;
            aS.Werk_Uren = aV.Werkuren;
            aS.Blokken = aV.AantBlokken;

            app.SaveAlgemeenSet();
        }
    }
}
