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
    public partial class SessionNavbar : System.Windows.Controls.UserControl
    {
        public Action<int> OnNavigationClicked { get; set; }
        public SessionNavbar()
        {
            InitializeComponent();

        }

        private void nav_dashboard_Click(object sender, RoutedEventArgs e)
        {
            OnNavigationClicked?.Invoke(0);
        }


        private void nav_taskeditor_Click(object sender, RoutedEventArgs e)
        {
            OnNavigationClicked?.Invoke(1);

        }

        private void nav_viewusers_Click(object sender, RoutedEventArgs e)
        {
            OnNavigationClicked?.Invoke(2);

        }

        private void nav_submission_Click(object sender, RoutedEventArgs e)
        {
            OnNavigationClicked?.Invoke(3);

        }

        private void nav_save_Click(object sender, RoutedEventArgs e)
        {
            OnNavigationClicked?.Invoke(4);

        }
    }
}
