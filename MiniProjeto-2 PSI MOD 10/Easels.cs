using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniProjeto_2_PSI_MOD_10
{
    public class Easels : Items
    {
        public Easels(string iName, int iId, int iPrice, bool iSold) : base(iName, iId, iPrice, iSold)
        {
            this.iName = iName;
            this.iPrice = iPrice;
            this.iSold = iSold;
            this.iId = iId;

            iSold = false;
        }

        public override void sellItem()
        {
            base.sellItem();
            MessageBox.Show("You just purchased an easel!", "Purchase");
        }
    }
}
