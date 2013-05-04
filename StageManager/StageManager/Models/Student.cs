using StageManager.MVVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StageManager.Models
{
    public class Student : PropertyChangedBase
    {
        private Guid id;

        public Student()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id
        {
            get { return id; }
            set
            {
                id = value;
                OnPropertyChanged("Id");
            }
        }
            
    }
}
