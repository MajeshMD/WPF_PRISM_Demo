using EmployeeModule.View;
using Prism.Commands;
using Prism.Events;
using Prism.Ioc;
using Prism.Regions;
using StudentModule.View;
using System.Windows.Input;
using Unity;

namespace WPF_Project.ViewModels
{
    public class RibbonMenuViewModel
    {
        IUnityContainer _unityContainer;
        IRegionManager _regionManager;
        IEventAggregator _eventAggregator;
        public DelegateCommand MessageSent { get; private set; }
        public RibbonMenuViewModel(IEventAggregator eventAggregator, IUnityContainer container, IRegionManager regionManager)
        {
            _eventAggregator = eventAggregator;
            _unityContainer = container;
            _regionManager = regionManager;
            MessageSent = new DelegateCommand(ShowMessage);
        }
        public RibbonMenuViewModel()
        {
        }

        public IRegion Region
        {
            get
            {
                return _regionManager.Regions["MainRegion"];
            }
        }

        public string Message { get; set; }
        void ShowMessage()
        {
            _eventAggregator.GetEvent<MessageEventAggregator.MessageEventAggregator>().Publish("THis message send by EA");
        }

        public void Action()
        {
            ShowMessage();
        }

        #region Command

        public ICommand ClickCommand { get { return new DelegateCommand(UpdateRenderHeightForMainLayout); } }
        private void UpdateRenderHeightForMainLayout()
        {
            Action();
        }

        public ICommand ClickOnEmployeeCommand { get { return new DelegateCommand(ClickOnEmployee); } }
        private void ClickOnEmployee()
        {
            ActivateView(nameof(EmployeeView));
        }

        public ICommand ClickOnStudentCommand { get { return new DelegateCommand(ClickOnStudent); } }
        private void ClickOnStudent()
        {
            ActivateView(nameof(StudentView));
        }

        private void ActivateView(string viewName)
        {
            dynamic view=null;
            switch (viewName)
            {
                case nameof(StudentView):
                     view = _unityContainer.Resolve<StudentView>();
                    break;
                case nameof(EmployeeView):
                    view = _unityContainer.Resolve<EmployeeView>();
                    break;
                default:
                    break;
            }
           
            if (_regionManager.Regions["MainRegion"].GetView(nameof(view)) != null)
            {
                Region.Remove(_regionManager.Regions["MainRegion"].GetView(nameof(view)));
            }
            _regionManager.Regions["MainRegion"].Add(view, nameof(view));
            Region.Activate(view);
        }

        #endregion

    }
}
