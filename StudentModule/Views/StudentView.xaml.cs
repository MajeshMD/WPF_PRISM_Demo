using Prism.Events;
using StudentModule.ViewModel;
using System.Windows.Controls;

namespace StudentModule.View
{
    /// <summary>
    /// Interaction logic for StudentView.xaml
    /// </summary>
    public partial class StudentView : UserControl
    {
        public StudentView(IEventAggregator eventAggregator)
        {
            InitializeComponent();
            DataContext = new StudentViewModel(eventAggregator);
        }
    }
}
