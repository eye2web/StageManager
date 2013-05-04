using StageManager.MVVM;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StageManager.Models
{
    public class Toewijzing : PropertyChangedBase
    {
        public Toewijzing()
        {
            Id = Guid.NewGuid();
            Docent = new Docent();
            Studenten = new ObservableCollection<Student>();
        }

        public Guid Id { get; set; }

        public virtual Docent Docent { get; private set; }

        public virtual ObservableCollection<Student> Studenten { get; private set; }
    }
}
