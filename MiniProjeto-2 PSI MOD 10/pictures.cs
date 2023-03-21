using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniProjeto_2_PSI_MOD_10
{
    public class pictures : Items
    {
        public pictures(string iName, int iId, int iPrice, bool iSold) : base(iName, iId, iPrice, iSold)
        {
            this.iName = iName;
            this.iId = iId; 
            this.iPrice = iPrice;
            this.iSold = iSold;
            iSold = false;
        }

        
    }
}
