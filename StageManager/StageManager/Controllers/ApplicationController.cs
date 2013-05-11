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

        public void ShowKoppel()
        {
            var mainViewModel = container.GetInstance(typeof(MainViewModel), null) as MainViewModel;
            mainViewModel.Contents = container.GetInstance(typeof(KoppelViewModel), null) as KoppelViewModel;
        }

        public void ShowStudenten()
        {
            var mainViewModel = container.GetInstance(typeof(MainViewModel), null) as MainViewModel;
            mainViewModel.Contents = container.GetInstance(typeof(StudentenViewModel), null) as StudentenViewModel;
        }

        public void ShowDocenten()
        {
        }

        public void ShowBedrijven()
        {
        }

        public void SaveAlgemeenSet()
        {

        }
    }
}
