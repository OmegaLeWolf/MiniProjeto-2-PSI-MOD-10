using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniProjeto_2_PSI_MOD_10
{
    public class owner : users
    {
        private const int permissionLevel = 3;
        public owner(string uName, string uPassword, string uEmail) : base(uName, uPassword, uEmail)
        {
            this.uName = uName;
            this.uPassword = uPassword;
            this.uEmail = uEmail;
        }

        public int PermissionLevel { get { return permissionLevel; } }

        public override void purchasePainting(int paintingId)
        {
            MessageBox.Show("You can not purchase any paintings!", "Error!");
        }

        public override void sellPainting(int paintingId)
        {
            if (uPaintingsPurchased.Contains(paintingId))
            {
                uPaintingsPurchased.Remove(paintingId);
            }
            else
            {
                MessageBox.Show("You do not own this painting!", "Error!");
            }
        }
    }
}
