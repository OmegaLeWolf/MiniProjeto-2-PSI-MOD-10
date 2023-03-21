using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniProjeto_2_PSI_MOD_10
{
    public class manager : users
    {
        private const int permissionLevel = 2;

        public manager(string uName, string uPassword, string uEmail) : base(uName, uPassword, uEmail)
        {
            this.uName = uName;
            this.uPassword = uPassword;
            this.uEmail = uEmail;
        }

        public int PermissionLevel { get { return permissionLevel; } }

        public override void purchasePainting(int paintingId)
        {
            //Adds painting to list of owned paintings
            uPaintingsPurchased.Add(paintingId);
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
