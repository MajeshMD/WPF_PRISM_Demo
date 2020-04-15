using Prism.Events;

namespace EmployeeModule.ViewModel
{
    public class EmployeeViewModel : ViewModelBase
    {
        public EmployeeViewModel(IEventAggregator _eventAggregator)
        {
            _eventAggregator.GetEvent<MessageEventAggregator.MessageEventAggregator>().Subscribe(SubscribeMessage);
        }
        void SubscribeMessage(string message)
        {
            Message = message;
        }
        private string _message="Employee";

        public string Message
        {
            get { return _message; }
            set { SetProperty(ref _message, value); }
        }

    }
}
