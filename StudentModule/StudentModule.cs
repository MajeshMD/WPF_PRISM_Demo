using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;
using StudentModule.View;

namespace StudentModule
{
    public class StudentModule : IModule
    {
        private readonly IRegionManager _regionManager;
        public StudentModule(IRegionManager regionManager)
        {
            this._regionManager = regionManager;

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
            _regionManager.RegisterViewWithRegion("MainRegion", typeof(View.StudentView));
 

            //_regionManager.Regions["MainRegion"].Add(typeof(View.StudentView), "StudentView");
        }
    }
}
