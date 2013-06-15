using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StageManager.ViewModels
{
    public class GegevensOverzichtViewModel : PropertyChangedBase
    {
        public GegevensOverzichtViewModel(MainViewModel main)
        {
            Main = main;
        }

        public MainViewModel Main { get; set; }
    }
}
