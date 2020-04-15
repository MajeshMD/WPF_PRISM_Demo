using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;
using Unity;

namespace EmployeeModule
{
    public class EmployeeModule : IModule
    {
        private readonly IRegionManager _regionManager;
        public EmployeeModule(IRegionManager regionManagerr)
        {
            _regionManager = regionManagerr;
            //_unityContainer = container;
        }

        //public void Initialize()
        //{
        //    regionManager.RegisterViewWithRegion("MainRegion", typeof(View.simpleprismapplicationview));
        //}
        public void OnInitialized(IContainerProvider containerProvider)
        {
            
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            _regionManager.RegisterViewWithRegion("MainRegion", typeof(View.EmployeeView));
        }
        public string MyProperty { get; set; } = "";
    }
}
