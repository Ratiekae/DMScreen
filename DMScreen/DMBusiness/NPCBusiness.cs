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
    }
}
