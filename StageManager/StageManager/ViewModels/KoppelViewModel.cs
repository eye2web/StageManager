using Caliburn.Micro;
using StageManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StageManager.ViewModels
{
    class KoppelViewModel : PropertyChangedBase
    {
        List<WDocent> DataGrid = new WStored().SearchDocentSet(null);

        public KoppelViewModel(MainViewModel main, WStudent student)
        {
            Main = main;
        }


        public MainViewModel Main { get; set; }
    }
}
