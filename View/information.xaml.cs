using System.Windows;
using System.Windows.Controls;

namespace brouillon_aganda.View
{
    public partial class information : UserControl
    {
        public information()
        {
            InitializeComponent();
        }

        private void GetMoreInfo_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("More Information will be available soon!", "Info",
                            MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}