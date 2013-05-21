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
    class Wrapper<T> : IWrapper<T> where T : class
    {
        private T set;
        static private DispatcherTimer timer;
        static private stagemanagerEntities se;
        static private TimeSpan time;


        public Wrapper(T t)
        {
            if (set == null)
            {
                throw new CantBeNullException(typeof(T).Name + " is NULL");
            }
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
            set = t;
        }

        void timer_Tick(object sender, EventArgs e)
        {
            se.SaveChanges();
            timer.Stop();
            se = new stagemanagerEntities();
        }

        public void save(T t)
        {
            stagemanagerEntities se = new stagemanagerEntities();
            se.Set<T>().Add(t);
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
        }

        public void save()
        {
            save(getSet());
        }

        public virtual T getSet()
        {
            return set;
        }


    }
}
