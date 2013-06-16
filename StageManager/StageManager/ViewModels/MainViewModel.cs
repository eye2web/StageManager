using Caliburn.Micro;
using StageManager.Controllers;
using StageManager.Models;
using StageManager.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
            content = new ObservableCollection<PropertyChanged>();
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
                ChangeButton("Zoek", new List<object>() { value }, Clear.All);
            }
        }

        private ObservableCollection<PropertyChanged> content;
        public ObservableCollection<PropertyChanged> Contents
        {
            get { return content; }
            set
            {
                content = value;
                NotifyOfPropertyChange(() => Contents);
            }
        }

        internal void addContent(PropertyChanged o)
        {
            Contents.Add(o);
            NotifyOfPropertyChange(() => Contents);
        }

        public void ChangeButton(string name)
        {
            ChangeButton(name, new List<Object>());
        }

        public void ChangeButton(string name, List<Object> o)
        {
            ChangeButton(name, o, Clear.No);
        }

        public void ChangeButton(string name, List<Object> o, Clear c)
        {
            currentButton = name;
            Clear clear = c;
            EventHandler handler = SomethingHappened;
            if (handler != null)
            {
                handler(this, new MainArgs(o, clear));
            }
        }
    }
}
