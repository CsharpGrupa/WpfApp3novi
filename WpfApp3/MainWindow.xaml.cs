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

namespace ProjektniZadatak
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            GotoLogon();

        }
        public void GotoLogon()
        {
            // Display the logon view and hide the list of students and single student view
            logonPage.Visibility = Visibility.Visible;
            prodajaPage.Visibility = Visibility.Collapsed;
        }

        public void GotoProdajaPage()
        {
            // Display the logon view and hide the list of students and single student view
            logonPage.Visibility = Visibility.Collapsed;
            prodajaPage.Visibility = Visibility.Visible;
        }
        private void Logon_Success(object sender, EventArgs e)
        {
            // Update the display and show the data for the logged on user
            logonPage.Visibility = Visibility.Collapsed;
            prodajaPage.Visibility = Visibility.Visible;

        }

        private void logonPage_Loaded(object sender, RoutedEventArgs e)
        {
            
        }

        internal class GoToProdajaPage
        {
            internal void Show()
            {
                throw new NotImplementedException();

            }
        }
    }
}
