﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StageManager.Controllers
{
    public interface IApplicationController
    {
        void ShowKoppel();

        void ShowZoek(String search="");

        void ShowStudenten();

        void ShowStudent();

        void ShowDocent();

        void ShowGegevensOverzicht();

        void ShowProcesOverzicht();

        void ShowBedrijfsbegeleider();
    }
}
