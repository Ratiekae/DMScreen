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

            TestMethod();
        }

        public void LoadPage()
        {
            //MessageBox.Show("NPCCreation Works!");
        }

        public void TestMethod()
        {
            npc.Bond = biz.GetNPCBonds();
            MessageBox.Show(npc.Bond);
        }
    }
}
