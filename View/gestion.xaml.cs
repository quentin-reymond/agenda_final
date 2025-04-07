using System.Windows;
using System.Windows.Controls;

namespace brouillon_aganda.View
{
    public partial class gestion : UserControl
    {
        public gestion()
        {
            InitializeComponent();
        }

        private void ManageItems_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Manage Items Functionality Coming Soon!", "Info",
                            MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}