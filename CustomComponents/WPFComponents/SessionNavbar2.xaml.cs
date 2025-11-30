using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SmartCodeLab.CustomComponents.WPFComponents
{
    /// <summary>
    /// Interaction logic for SessionNavbar.xaml
    /// </summary>
    public partial class SessionNavbar2 : System.Windows.Controls.UserControl
    {
        public Action<int> OnNavigationClicked { get; set; }
        public SessionNavbar2()
        {
            InitializeComponent();

        }

        private void nav_dashboard_Click(object sender, RoutedEventArgs e)
        {
            OnNavigationClicked?.Invoke(0);
        }

        private void nav_monitoring_Click(object sender, RoutedEventArgs e)
        {
            OnNavigationClicked?.Invoke(1);

        }

        private void nav_submission_Click(object sender, RoutedEventArgs e)
        {
            OnNavigationClicked?.Invoke(2);

        }

   

        
    }
}
