using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DMScreen.DMData;

namespace DMScreen.DMBusiness
{
    public class NPCBusiness
    {
        public string GetNPCBonds()
        {
            NPCData data = new NPCData();
            return data.GetNPCBond();
        }
        public string GetNPCAppearance()
        {
            NPCData data = new NPCData();
            return data.GetNPCAppearance();
        }
        public List<string> GetNPCIdeals(int number)
        {
            NPCData data = new NPCData();
            return data.GetNPCIdeals(number);
        }
        public List<string> GetNPCFlawsOrSecrets(int number)
        {
            NPCData data = new NPCData();
            return data.GetNPCFlawsOrSecrets(number);
        }
    }
}
