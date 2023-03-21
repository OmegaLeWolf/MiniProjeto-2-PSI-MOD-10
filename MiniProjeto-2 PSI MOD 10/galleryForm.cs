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
            othersShopForm form1 = new othersShopForm();
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

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == 0)
            {
                //Art Expo 2023 Portimão Arena
            }

            else if (listBox1.SelectedIndex == 1)
            {
                //Art Expo 2022 Marshopping
            }

            else if (listBox1.SelectedIndex == 2)
            {
                //Paintings
            }
        }
    }
}
