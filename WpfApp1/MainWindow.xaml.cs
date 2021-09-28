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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnListEntries_Click(object sender, RoutedEventArgs e)
        {
            txtTexBlock.Text = "List Entries will happen";
        }

        private void btnAddEntry_Click(object sender, RoutedEventArgs e)
        {
            txtTexBlock.Text = "Add Entry will happen";
        }

        private void btnUpdateEntry_Click(object sender, RoutedEventArgs e)
        {
            txtTexBlock.Text = "Update Entry will happen";
        }

        private void btnDeleteEntry_Click(object sender, RoutedEventArgs e)
        {
            txtTexBlock.Text = "Delete Entry will happen";

        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
