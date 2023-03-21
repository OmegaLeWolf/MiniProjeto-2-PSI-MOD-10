using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniProjeto_2_PSI_MOD_10
{
    public class Items
    {
        public string iName;
        public int iId;
        public int iPrice;
        public bool iSold;
        public Items(string iName, int iId, int iPrice, bool iSold)
        {
            this.iName = iName;
            this.iId = iId;
            this.iPrice = iPrice;
            this.iSold = iSold;
        }
    }
}
