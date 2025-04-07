using System.Windows;

namespace brouillon_aganda
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            ContentArea.Content = new View.Home(); // Page d'accueil par défaut
        }

        private void Home_Click(object sender, RoutedEventArgs e)
        {
            ContentArea.Content = new View.Home(); // Charge la page d'accueil
        }

        private void todo_Click(object sender, RoutedEventArgs e)
        {
            ContentArea.Content = new View.information(); // Charge la page To Do List
        }

        private void calendar_Click(object sender, RoutedEventArgs e)
        {
            ContentArea.Content = new View.settings(); // Charge la page des paramètres
        }

        private void contact_Click(object sender, RoutedEventArgs e)
        {
            ContentArea.Content = new View.gestion(); // Accède à la page de gestion
        }
    }
}