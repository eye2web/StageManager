using Caliburn.Micro;
using StageManager.Models;
using StageManager.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StageManager.ViewModels
{
    class KoppelViewModel : PropertyChanged
    {
        List<WDocent> DataGrid = new WStored().SearchDocentSet(null);
        private WStage stage;

        public WStage Stage
        {
            get { return stage; }
            set { stage = value; }//TODO Notify
        }

        public KoppelViewModel(MainViewModel main, WStage stage)
        {
            Main = main;
            Stage = stage;
        }


        public MainViewModel Main { get; set; }

        public virtual void update(object[] o)
        {
            try
            {
                Stage = (WStage)o[1];
            }
            catch (Exception)
            {   
                throw;
            }
        }
    }
}
