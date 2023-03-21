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
    public partial class aboutForm : Form
    {
        public aboutForm()
        {
            InitializeComponent();
        }
        private void openHomeForm(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();


        }

        private void openAboutForm(object sender, EventArgs e)
        {
            this.Hide();
            aboutForm form1 = new aboutForm();
            form1.Show();
        }

        private void openShopForm(object sender, EventArgs e)
        {
            this.Hide();
            othersShopForm form1 = new othersShopForm();
            form1.Show();
        }

        

       
        private void aboutForm_Load(object sender, EventArgs e)
        {

        }
    }
}
