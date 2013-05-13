using StageManager.MVVM;
using StageManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StageManager.ViewModels
{
    public class StudentSelectieViewModel : PropertyChangedBase
    {
        private List<studentset> gritContents;
        public List<studentset> GritContents
        {
            get { return gritContents; }
            set
            {
                gritContents = value;
                OnPropertyChanged("GritContents");
            }
        }

        public StudentSelectieViewModel()
        {
            FillView();
        }

        public void FillView()
        {
            stagemanagerEntities smE = new stagemanagerEntities();
            GritContents = smE.studentsets.ToList();
        } 

    }
}
