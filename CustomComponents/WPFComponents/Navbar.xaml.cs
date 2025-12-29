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
    /// Interaction logic for Navbar.xaml
    /// </summary>
    public partial class Navbar : System.Windows.Controls.UserControl
    {
        public Action<int> OnNavigationClicked { get; set; }
        public Navbar()
        {
            InitializeComponent();
        }

        private void nav_session_Click(object sender, RoutedEventArgs e)
        {
            OnNavigationClicked?.Invoke(0);
        }

        private void nav_explorer_Click(object sender, RoutedEventArgs e)
        {
            OnNavigationClicked?.Invoke(1);

        }

        private void nav_sessionlogs_Click(object sender, RoutedEventArgs e)
        {
            OnNavigationClicked?.Invoke(2);

        }

        private void nav_class_Click(object sender, RoutedEventArgs e)
        {
            OnNavigationClicked?.Invoke(3);

        }


    }
}
