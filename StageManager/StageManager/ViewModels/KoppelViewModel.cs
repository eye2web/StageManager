using StageManager.Models;
using StageManager.MVVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StageManager.ViewModels
{
    public class KoppelViewModel : PropertyChangedBase
    {
        List<WDocent> DataGrid = WStored.SearchDocentSet();

        public KoppelViewModel()
        { }

    }
}
