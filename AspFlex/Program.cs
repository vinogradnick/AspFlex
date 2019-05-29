using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using AspFlex.Controllers;
using AspFlex.PassiveView;
using AspFlex.RepositoryManager_;
using Unity;
using Unity.Lifetime;

namespace AspFlex
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var container = new UnityContainer();
            container.RegisterType(typeof(MainController), new ContainerControlledLifetimeManager());            container.RegisterType(typeof(MainController), new ContainerControlledLifetimeManager());
            container.RegisterType(typeof(CodeGeneratorController), new ContainerControlledLifetimeManager());
            container.RegisterType(typeof(CreateObjectController), new ContainerControlledLifetimeManager());
            container.RegisterType(typeof(ChangeObjectController), new ContainerControlledLifetimeManager());
            container.RegisterType(typeof(RemoveObjectController), new ContainerControlledLifetimeManager());
            container.RegisterType<IRepositoryManager,RepositoryManager>(new ContainerControlledLifetimeManager());
            container.RegisterType(typeof(RequestPageController), new ContainerControlledLifetimeManager());
            container.RegisterType<IRequestPage, RequestPage>(new ContainerControlledLifetimeManager());
            container.RegisterType<IMainForm, Form1>(new ContainerControlledLifetimeManager());
            container.RegisterType<IAddObjectView, AddObject>(new ContainerControlledLifetimeManager());
            container.RegisterType<IRemoveObjectView, RemoveObject>(new ContainerControlledLifetimeManager());
            container.RegisterType<ICodeGeneratorView, CodeGeneratorPage>(new ContainerControlledLifetimeManager());
            Application.Run((Form1) container.Resolve<MainController>().View);
        }
    }
}
