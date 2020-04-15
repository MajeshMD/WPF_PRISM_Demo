using Prism.Events;
using System.Windows.Controls;
using WPF_Project.ViewModels;

namespace WPF_Project.Views
{
    /// <summary>
    /// Interaction logic for RibbonMenuView.xaml
    /// </summary>
    public partial class RibbonMenu : UserControl
    {
        public RibbonMenu()
        {
            InitializeComponent();
            //DataContext = new RibbonMenuViewModel(eventAggregator);
        }
        
    }
}
