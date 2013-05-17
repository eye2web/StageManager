using StageManager.MVVM;
using StageManager.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StageManager.Models
{
    class WAcedemie : acedemieset, ISave
    {
        public WAcedemie()
            :base()
        {
        }

        private void save()
        {
            ISave.Entities.acedemiesets.Add(this);
        }
    }
}
