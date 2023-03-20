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
    public partial class galleryForm : Form
    {
        public galleryForm()
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
            shopForm form1 = new shopForm();
            form1.Show();
        }

        private void openGalleryForm(object sender, EventArgs e)
        {
            this.Hide();
            galleryForm form1 = new galleryForm();
            form1.Show();
        }

        
        private void galleryForm_Load(object sender, EventArgs e)
        {

        }
    }
}
