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

namespace DMScreen
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string applicationTitle = "DMScreen";
        public MainWindow()
        {
            InitializeComponent();
            this.Loaded += MainWindow_Loaded;
            this.DataContext = this;
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void BtnNPCCreator_Click(object sender, RoutedEventArgs e)
        {
            NPCCreation create = new NPCCreation();
            mainFrame.NavigationService.Navigate(create);
            this.Title = applicationTitle + " - NPC Creation";
        }

        private void BtnPCCreator_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("This feature still in development. :(");
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("This feature still in development. :(");
        }
    }
}
