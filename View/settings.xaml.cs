using System.Windows;
using System.Windows.Controls;

namespace brouillon_aganda.View
{
    public partial class settings : UserControl
    {
        public settings()
        {
            InitializeComponent();
        }

        private void SaveSettings_Click(object sender, RoutedEventArgs e)
        {
            // Ici, vous pouvez ajouter le code pour enregistrer les paramètres.
            MessageBox.Show("Settings have been saved!", "Confirmation",
                            MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}