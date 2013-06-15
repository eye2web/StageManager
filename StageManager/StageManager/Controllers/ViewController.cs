using Caliburn.Micro;
using StageManager.Services;
using StageManager.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

        public void HandleEvent(object sender, EventArgs eventArgs)
        {
            MainArgs args = (MainArgs)eventArgs;
            MainViewModel mainViewModel = (MainViewModel)sender;
            string objectName = mainViewModel.currentButton + "ViewModel";
            List<Object> param = new List<object>();
            param.Add(mainViewModel);
            param.AddRange(args.param);

            Assembly currAssembly = Assembly.GetExecutingAssembly();
            var currType = currAssembly.GetTypes().SingleOrDefault(t => t.Name == objectName);
           if (mainViewModel.Contents.Count == 0 || currType != mainViewModel.Contents.Last().GetType())
            {
                if (currType != null)
                {
                    switch (args.clear)
                    {
                        case Clear.All:
                            mainViewModel.Contents.Clear();
                            break;
                        case Clear.After:
                            //TODO;
                            break;
                        case Clear.No:
                            break;
                        default:
                            break;
                    }
                    Type t = currType.BaseType;
                    Type ct = typeof(PropertyChanged);
                    if (currType.BaseType == typeof(PropertyChanged))
                    {
                        Object o = Activator.CreateInstance(currType, param.ToArray());
                        mainViewModel.addContent((PropertyChanged)Activator.CreateInstance(currType, param.ToArray()));
                    }
                }
            }
            else
            {
                mainViewModel.Contents.Last().update(param.ToArray());
            }
        }
    }
}