using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StageManager.Services
{
    class MainArgs : EventArgs
    {
        public List<Object> param { get; set; }
        public Clear clear { get; set; }

        public MainArgs(List<Object> param, Clear clearScreen)
        {
            this.param = param;
            clear = clearScreen;
        }
    }
}
