﻿using StageManager.Controllers;
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
        private AlgemeenViewModel aVM;

        private PropertyChangedBase content = new OverzichtViewModel();

        public MainViewModel(
            IApplicationController app,
            OverzichtViewModel overzicht)
        {
            this.app = app;
            this.overzicht = overzicht;
            aVM = new AlgemeenViewModel();

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

        public void OpenKoppel()
        {
            app.ShowKoppel();
        }

        public void OpenStudentSelectie()
        {
            app.ShowStudenten();
        }

/*
        public void Opleidingen()
        {
            app.ShowOpleidingen();
        }
 */

        public void Studenten()
        {
            app.ShowStudenten();
        }

        public void Docenten()
        {
            app.ShowDocenten();
        }

        public void Bedrijven()
        {
            app.ShowBedrijven();
        }
    }
}
