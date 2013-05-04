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

        private PropertyChangedBase content;

        public MainViewModel(
            IApplicationController app,
            OverzichtViewModel overzicht)
        {
            this.app = app;
            this.overzicht = overzicht;
        }

        public OverzichtViewModel Overzicht { get { return overzicht; } }

        public PropertyChangedBase Content
        {
            get { return content; }
            set
            {
                content = value;
                OnPropertyChanged("Content");
            }
        }

        public void OpenOverzicht()
        {
            app.ShowOverzicht();
        }

        public void Studenten()
        {
            app.ShowStudenten();
        }
    }
}
