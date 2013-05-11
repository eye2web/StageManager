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

       public void SaveAlgemeenSet(AlgemeenView aV)
        {
            stagemanagerEntities smE = new stagemanagerEntities();
            algemeenset aS = new algemeenset();
 
            aS.Jaargang = aV.Jaargang;
            aS.Werk_Uren = aV.Werkuren;
            aS.Blokken = aV.AantBlokken;

            smE.algemeensets.Add(aS);
            smE.SaveChanges();
        }
    }
}
