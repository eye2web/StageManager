using Caliburn.Micro;
using StageManager.Controllers;
using StageManager.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StageManager.ViewModels
{
    public class MainViewModel : PropertyChangedBase
    {
        public event EventHandler SomethingHappened;
        public string currentButton { get; set; }

        public MainViewModel()
        {
        }

        private String search;
        public String Search
        {
            get
            {
                return search;
            }
            set
            {
                search = value;
                NotifyOfPropertyChange(() => Search);
                //OpenZoek(zoek);
            }
        }

        private Object content;
        public Object Contents
        {
            get { return content; }
            set
            {
                content = value;
                NotifyOfPropertyChange(() => Contents);
            }
        }

        public void ChangeButton(string name)
        {
            currentButton = name;

            EventHandler handler = SomethingHappened;
            if (handler != null)
            {
                handler(this, EventArgs.Empty);
            }
        }
    }
}
