using Caliburn.Micro;
using StageManager.Models;
using StageManager.Services;
using StageManager.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StageManager.Controllers
{
    class ApplicationController : IApplicationController
    {
        private readonly SimpleContainer container;
        private readonly IService service;
        private readonly ProcesOverzichtViewModel overzichtViewModel;

        public ApplicationController(
            SimpleContainer container,
            IService service,
            ProcesOverzichtViewModel overzichtViewModel)
        {
            this.container = container;
            this.service = service;
            this.overzichtViewModel = overzichtViewModel;
        }

        public void ShowGegevensOverzicht()
        {
            var mainViewModel = container.GetInstance(typeof(MainViewModel), null) as MainViewModel;
            mainViewModel.Contents = container.GetInstance(typeof(GegevensOverzichtViewModel), null) as GegevensOverzichtViewModel;
        }

        public void ShowProcesOverzicht()
        {
            var mainViewModel = container.GetInstance(typeof(MainViewModel), null) as MainViewModel;
            mainViewModel.Contents = container.GetInstance(typeof(ProcesOverzichtViewModel), null) as ProcesOverzichtViewModel;
        }

        public void ShowKoppel()
        {
            var mainViewModel = container.GetInstance(typeof(MainViewModel), null) as MainViewModel;
            mainViewModel.Contents = container.GetInstance(typeof(KoppelViewModel), null) as KoppelViewModel;
        }

        public void ShowStudenten()
        {
            var mainViewModel = container.GetInstance(typeof(MainViewModel), null) as MainViewModel;
            mainViewModel.Contents = container.GetInstance(typeof(DemoNieuwKoppelViewModel), null) as DemoNieuwKoppelViewModel;
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

        public void ShowZoek(String search = "")
        {
            var mainViewModel = container.GetInstance(typeof(MainViewModel), null) as MainViewModel;
            if (mainViewModel.Contents.GetType() != typeof(ZoekViewModel))
            {
                var viewModel = container.GetInstance(typeof(ZoekViewModel), null) as ZoekViewModel;
                mainViewModel.Contents = viewModel;
                if (search != "" && search != null)
                {
                    viewModel.SearchString = search;
                }
            }
            else if (search != "")
            {
                ((ZoekViewModel)mainViewModel.Contents).SearchString = search;
            }

        }

        public void SaveAlgemeenSet()
        {

        }


        public void ShowBedrijfsbegeleider()
        {
            var mainViewModel = container.GetInstance(typeof(MainViewModel), null) as MainViewModel;
            mainViewModel.Contents = container.GetInstance(typeof(BedrijfsbegeleiderViewModel), null) as BedrijfsbegeleiderViewModel;
        }


        public void ShowBedrijf()
        {
            var mainViewModel = container.GetInstance(typeof(MainViewModel), null) as MainViewModel;
            mainViewModel.Contents = container.GetInstance(typeof(BedrijfViewModel), null) as BedrijfViewModel;
        }

        public void ShowStageopdracht()
        {
            var mainViewModel = container.GetInstance(typeof(MainViewModel), null) as MainViewModel;
            mainViewModel.Contents = container.GetInstance(typeof(StageopdrachtViewModel), null) as StageopdrachtViewModel;
        }
    }
}