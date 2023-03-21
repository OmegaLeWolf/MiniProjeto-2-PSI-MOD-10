using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniProjeto_2_PSI_MOD_10
{
    public abstract class users
    {
        public string uName;
        public string uPassword;
        public string uEmail;
        public int uId;
        public List<int> uPaintingsPurchased;

        public users(string uName, string uPassword, string uEmail)
        {
            this.uName = uName;
            this.uPassword = uPassword;
            this.uEmail = uEmail;
        }

        public abstract void purchasePainting(int paintingId);
        public abstract void sellPainting(int paintingId);
    }
}
