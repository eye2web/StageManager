namespace StageManager
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.Composition;
    using System.ComponentModel.Composition.Hosting;
    using System.ComponentModel.Composition.Primitives;
    using System.Linq;
    using Caliburn.Micro;
    using System.Diagnostics;
    using StageManager.Controllers;
    using StageManager.ViewModels;
    using System.Threading.Tasks;
    using System.Reflection;
    using StageManager.Services;
    using StageManager.Models;

    public class AppBootstrapper : Bootstrapper<IShell>
    {
        private SimpleContainer container;
        private WindowManager windowManager;

        protected override void Configure()
        {
            container = new SimpleContainer();
            container.Instance<SimpleContainer>(container);

            windowManager = new WindowManager();
            container.Instance<WindowManager>(windowManager);

            container.Singleton<IApplicationController, ApplicationController>();

            // services
            container.Singleton<IFactory, DefaultFactory>();
            container.Singleton<IService, EntityService>();
            container.Singleton<stagemanagerEntities>();

            container.PerRequest<OverzichtViewModel>();
            container.PerRequest<KoppelViewModel>();
            container.PerRequest<StudentenViewModel>();
            container.PerRequest<StudentSelectieViewModel>();

            container.Singleton<MainViewModel>();
        }

        protected override object GetInstance(Type serviceType, string key)
        {
            return container.GetInstance(serviceType, key);
        }

        protected override IEnumerable<object> GetAllInstances(Type serviceType)
        {
            return container.GetAllInstances(serviceType);
        }

        protected override void BuildUp(object instance)
        {
            container.BuildUp(instance);
        }

        protected override void OnStartup(object sender, System.Windows.StartupEventArgs e)
        {
            windowManager.ShowWindow(container.GetInstance(typeof(MainViewModel), null));
        }
    }
}
