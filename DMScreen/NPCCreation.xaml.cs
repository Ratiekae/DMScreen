using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
using DMScreen.DMBusiness;
using DMScreen.DMObjects;

namespace DMScreen
{
    /// <summary>
    /// Interaction logic for NPCCreation.xaml
    /// </summary>
    public partial class NPCCreation : Page
    {
        NPCBusiness biz = new NPCBusiness();
        NPCObjects npc = new NPCObjects();
        Random rand = new Random();
        string applicationTitle = "DMScreen";

        int roll;
        
        public NPCCreation()
        {
            InitializeComponent();

            LoadPage();
        }

        public void LoadPage()
        {
            txtFlawNum.Text = "1";
            txtIdealNum.Text = "1";
        }

        private void BtnBond_Click(object sender, RoutedEventArgs e)
        {
            roll = rand.Next(1, 11);            
            npc.Bond = biz.GetNPCBonds(roll);
            txtBond.Text = npc.Bond;
        }

        private void BtnApp_Click(object sender, RoutedEventArgs e)
        {
            roll = rand.Next(1, 21);
            npc.Appearance = biz.GetNPCAppearance(roll);
            txtApp.Text = npc.Appearance;
        }

        private void BtnIdeals_Click(object sender, RoutedEventArgs e)
        {
            int number = 2;
            number = Convert.ToInt32(txtIdealNum.Text);
            npc.Ideals = biz.GetRandomNPCIdeals(number);
            lstIdeals.ItemsSource = npc.Ideals;
        }

        private void BtnFOrS_Click(object sender, RoutedEventArgs e)
        {
            int number = 1;
            number = Convert.ToInt32(txtFlawNum.Text);
            try
            {
                npc.FlawOrSecret = biz.GetNPCFlawsOrSecrets(number);
                lstFOrS.ItemsSource = npc.FlawOrSecret;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void TxtNumber_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);            
        }

        private void BtnTraits_Click(object sender, RoutedEventArgs e)
        {
            roll = rand.Next(1, 13);
            npc.Trait = biz.GetNPCTrait(roll);
            txtTrait.Text = npc.Trait;
        }

        private void BtnMainMenu_Click(object sender, RoutedEventArgs e)
        {
            //MainWindow mainwin = new MainWindow();
            //this.NavigationService.Navigate(mainwin);
            //this.Title = applicationTitle + " - Main Menu";
            MessageBox.Show("Doesn't work yet. :(");
        }
    }
}
