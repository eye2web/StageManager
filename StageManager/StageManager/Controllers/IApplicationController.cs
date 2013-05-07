using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StageManager.Controllers
{
    public interface IApplicationController
    {
        void ShowOverzicht();

        void ShowKoppel();

//      void ShowOpleidingen();

        void ShowStudenten();

        void ShowDocenten();

        void ShowBedrijven();
    }
}
