using Prism.Commands;
using Prism.Events;
using System.Windows.Input;

namespace StudentModule.ViewModel
{
    public class StudentViewModel: ViewModelBase
    {
        IEventAggregator _eventAggregator;
        public DelegateCommand MessageSent { get; private set; }
        public StudentViewModel(IEventAggregator ea)
        {
            _eventAggregator = ea;
            MessageSent = new DelegateCommand(ShowMessage);

        }
        void ShowMessage()
        {
            _eventAggregator.GetEvent<MessageEventAggregator.MessageEventAggregator>().Publish("THis message send by EA");
        }

        public void MyAction()
        {
            ShowMessage();
        }

        #region Command

        public ICommand ClickCommand { get { return new DelegateCommand(UpdateRenderHeightForMainLayout); } }
        private void UpdateRenderHeightForMainLayout()
        {
            MyAction();
        }
        #endregion

        private string _message = "Student";
        public string Message
        {
            get { return _message; }
            set { SetProperty(ref _message, value); }
        }
    }
}
