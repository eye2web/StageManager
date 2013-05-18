using Caliburn.Micro;
using StageManager.Services;
using StageManager.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StageManager.Controllers
{
    public class ApplicationController : IApplicationController
    {
        private readonly SimpleContainer container;
        private readonly IService service;
        private readonly OverzichtViewModel overzichtViewModel;

        public ApplicationController(
            SimpleContainer container,
            IService service,
            OverzichtViewModel overzichtViewModel)
        {
            this.container = container;
            this.service = service;
            this.overzichtViewModel = overzichtViewModel;
        }

        public void ShowOverzicht()
        {
            var mainViewModel = container.GetInstance(typeof(MainViewModel), null) as MainViewModel;
            mainViewModel.Contents = container.GetInstance(typeof(OverzichtViewModel), null) as OverzichtViewModel;
        }

        public void ShowGegevensOverzicht()
        {
            var mainViewModel = container.GetInstance(typeof(MainViewModel), null) as MainViewModel;
            mainViewModel.Contents = container.GetInstance(typeof(GegevensOverzichtViewModel), null) as GegevensOverzichtViewModel;
        }

        public void ShowKoppel()
        {
            var mainViewModel = container.GetInstance(typeof(MainViewModel), null) as MainViewModel;
            mainViewModel.Contents = container.GetInstance(typeof(KoppelViewModel), null) as KoppelViewModel;
        }

        public void ShowStudenten()
        {
            var mainViewModel = container.GetInstance(typeof(MainViewModel), null) as MainViewModel;
            mainViewModel.Contents = container.GetInstance(typeof(StudentSelectieViewModel), null) as StudentSelectieViewModel;
        }

        public void ShowStudent()
        {
            var mainViewModel = container.GetInstance(typeof(MainViewModel), null) as MainViewModel;
            mainViewModel.Contents = container.GetInstance(typeof(StudentViewModel), null) as StudentViewModel;
        }

        public void ShowDocent()
        {
            var mainViewModel = container.GetInstance(typeof(MainViewModel), null) as MainViewModel;
            mainViewModel.Contents = container.GetInstance(typeof(DocentViewModel), null) as DocentViewModel;
        }

        public void ShowZoek()
        {
            var mainViewModel = container.GetInstance(typeof(MainViewModel), null) as MainViewModel;
            mainViewModel.Contents = container.GetInstance(typeof(ZoekViewModel), null) as ZoekViewModel;
        }

        public void SaveAlgemeenSet()
        {

        }
    }
}
