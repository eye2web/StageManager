using Caliburn.Micro;
using StageManager.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace StageManager.Controllers
{
    class ViewController : PropertyChangedBase
    {
        private Object _CurrentViewModel;
        public Object CurrentViewModel
        {
            get { return _CurrentViewModel; }
            set
            {
                _CurrentViewModel = value;
                NotifyOfPropertyChange(() => CurrentViewModel);
            }
        }

        public ViewController()
        {
            CurrentViewModel = null; // On Startup View
        }

        public void HandleEvent(object sender, EventArgs args)
        {
            MainViewModel mainViewModel = (MainViewModel)sender;
            string objectName = mainViewModel.currentButton + "ViewModel";

            Assembly currAssembly = Assembly.GetExecutingAssembly();
            var currType = currAssembly.GetTypes().SingleOrDefault(t => t.Name == objectName);
            if (currType != null)
            {
                mainViewModel.Contents = null;
                mainViewModel.Contents = Activator.CreateInstance(currType);
            }
        }
    }
}
