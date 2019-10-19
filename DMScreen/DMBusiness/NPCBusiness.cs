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
        public string GetNPCBonds(int roll)
        {
            NPCData data = new NPCData();
            return data.GetNPCBond(roll);
        }
        public string GetNPCAppearance(int roll)
        {
            NPCData data = new NPCData();
            return data.GetNPCAppearance(roll);
        }
        public List<string> GetRandomNPCIdeals(int number)
        {
            NPCData data = new NPCData();
            return data.GetRandomNPCIdeals(number);
        }
        public List<string> GetNPCFlawsOrSecrets(int number)
        {
            NPCData data = new NPCData();
            return data.GetNPCFlawsOrSecrets(number);
        }
        public string GetNPCTrait(int roll)
        {
            NPCData data = new NPCData();
            return data.GetNPCTrait(roll);
        }
    }
}
