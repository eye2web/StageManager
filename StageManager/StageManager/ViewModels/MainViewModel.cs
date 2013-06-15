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
            content = new ObservableCollection<object>();
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

        private ObservableCollection<Object> content;
        public ObservableCollection<Object> Contents
        {
            get { return content; }
            set
            {
                content = value;
                NotifyOfPropertyChange(() => Contents);
            }
        }

        public void addContent(Object o)
        {
            Contents.Add(o);
            NotifyOfPropertyChange(() => Contents);
        }

        public void ChangeButton(string name)
        {
            ChangeButton(name, new List<Object>(), Clear.No);
        }

        public void ChangeButton(string name, List<Object> o, Clear c=Clear.No)
        {
            currentButton = name;
            Clear clear= c;
            EventHandler handler = SomethingHappened;
            if (handler != null)
            {
                Object[] a = o.ToArray();
                handler(this, new MainArgs(o, clear));
            }
        }
    }
}
