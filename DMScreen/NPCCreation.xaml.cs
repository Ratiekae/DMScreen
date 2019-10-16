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
        
        public NPCCreation()
        {
            InitializeComponent();

            LoadPage();
        }

        public void LoadPage()
        {
            Console.WriteLine("LoadPage works!");
            txtFlawNum.Text = "1";
        }

        private void BtnBond_Click(object sender, RoutedEventArgs e)
        {
            npc.Bond = "Loves their family.";
            //npc.Bond = biz.GetNPCBonds();
            txtBond.Text = npc.Bond;
        }

        private void BtnApp_Click(object sender, RoutedEventArgs e)
        {
            npc.Appearance = biz.GetNPCAppearance();
            txtApp.Text = npc.Appearance;
        }

        private void BtnIdeals_Click(object sender, RoutedEventArgs e)
        {
            int number = 2;
            npc.Ideals = biz.GetNPCIdeals(number);
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

        private void TxtFlawNum_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);            
        }
    }
}
