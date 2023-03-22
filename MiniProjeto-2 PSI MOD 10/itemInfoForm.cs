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
    public partial class itemInfoForm : Form
    {
        private string _itemName;
        private int _itemPrice;
        private string _itemPicturePath;


        public itemInfoForm(string iName, int iPrice)
        {
            InitializeComponent();
            _itemName = iName;
            _itemPrice = iPrice;
        }

        private void itemInfoForm_Load(object sender, EventArgs e)
        {
            itemName.Text = _itemName;
            itemPrice.Text = _itemPrice.ToString();

            if (_itemName == "Bamboo Easel")
            {
                _itemPicturePath = "/bin/easel-bamboo.jpg";
            }

            itemPicture.ImageLocation = _itemPicturePath;
        }
    }
}
