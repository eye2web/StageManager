using StageManager.Controllers;
using StageManager.MVVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StageManager.ViewModels
{
    class MainViewModel : PropertyChangedBase
    {
        private readonly IApplicationController app;
        private readonly OverzichtViewModel overzicht;

        private PropertyChangedBase content = new OverzichtViewModel();

        public MainViewModel(
            IApplicationController app,
            OverzichtViewModel overzicht)
        {
            this.app = app;
            this.overzicht = overzicht;
        }

        public OverzichtViewModel Overzicht { get { return overzicht; } }

        public PropertyChangedBase Contents
        {
            get { return content; }
            set
            {
                content = value;
                OnPropertyChanged("Contents");
            }
        }

        public void OpenOverzicht()
        {
            app.ShowOverzicht();
        }

        public void OpenGegevensOverzicht()
        {
            app.ShowGegevensOverzicht();
        }

        public void OpenKoppel()
        {
            app.ShowKoppel();
        }

        public void OpenZoek()
        {
            app.ShowZoek();
        }

        public void OpenStudentSelectie()
        {
            app.ShowStudenten();
        }

        public void OpenStudent()
        {
            app.ShowStudent();
        }

        public void OpenDocent()
        {
            app.ShowDocent();
        }
    }
}
