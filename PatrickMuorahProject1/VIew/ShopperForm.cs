using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PatrickMuorahProject1.VIew
{
    public partial class ShopperForm : Form
    {
        public string ShopperName { get; set; }
        public decimal MoneyAvailable { get; set; }
        public ShopperForm()
        {
            InitializeComponent();
        }

        private void ShopperForm_Load(object sender, EventArgs e)
        {

        }
    }
}
