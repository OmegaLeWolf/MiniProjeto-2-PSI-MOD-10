using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniProjeto_2_PSI_MOD_10
{
    public partial class easelsShopForm : Form
    {
        public easelsShopForm()
        {
            InitializeComponent();
        }

        private void easelsShopForm_Load(object sender, EventArgs e)
        {

        }
        private void itemInfoForm_Open(object sender, EventArgs e)
        {
            MessageBox.Show(sender.GetType().ToString());
            //this.Hide();
            //itemInfoForm form1 = new itemInfoForm();
            //form1.Show();
        }
    }
}
