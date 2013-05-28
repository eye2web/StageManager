using StageManager.Exceptions;
using StageManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Threading;

namespace StageManager.Services
{
    class Wrapper : IWrapper
    {
        static private DispatcherTimer timer;
        static private stagemanagerEntities se;
        static private TimeSpan time;


        public Wrapper()
        {
            if (timer == null)
            {
                timer = new DispatcherTimer();
                time = new TimeSpan(0, 0, 1);
                timer.Interval = time;
                timer.Tick += timer_Tick;
            }
            if (se == null)
            {
                se = new stagemanagerEntities();
            }
        }

        void timer_Tick(object sender, EventArgs e)
        {
            int i = se.SaveChanges();
            timer.Stop();
        }

        public void save(Object o)
        {
            if (timer.IsEnabled)
            {
                timer.Stop();
                timer.Interval = time;
                timer.Start();
            }
            else
            {
                timer.Start();
            }
            se.Set(o.GetType()).Add(o);
        }
    }
}
