using StageManager.Controllers;
using StageManager.MVVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StageManager.Models;
using StageManager.Views;
using System.Windows;
using StageManager.Services;

namespace StageManager.ViewModels
{
    class AlgemeenViewModel : PropertyChangedBase
    {  
        private readonly IApplicationController app;
        private AlgemeenView aV;
        private readonly RelayCommand saveCommand;

        public AlgemeenViewModel()
        {
            aV = new AlgemeenView();
            this.saveCommand = new RelayCommand(Save);
        }

        public RelayCommand SaveCommand { get { return saveCommand; } }

        public void Save(object commandParam)
        {
            Console.WriteLine("hoi");
        }

        public void SaveAlgemeenSet()
        {
            stagemanagerEntities smE = new stagemanagerEntities();
            algemeenset aS = new algemeenset();

            aS.Jaargang = aV.Jaargang;
            aS.Werk_Uren = aV.Werkuren;
            aS.Blokken = aV.AantBlokken;

            smE.algemeensets.Add(aS);
            smE.SaveChanges();
        }


        public void Opslaan(object sender, RoutedEventArgs e)
        {
            Console.WriteLine("hoi");
        }
    }
}
