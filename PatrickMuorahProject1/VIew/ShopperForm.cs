using PatrickMuorahProject1.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace PatrickMuorahProject1.VIew
{
    public partial class ShopperForm : Form
    {
        /// <summary>
        /// The car lot object
        /// </summary>
        private CarLot? carLot;

        /// <summary>
        /// Gets the shopper.
        /// </summary>
        /// <value>
        /// The shopper.
        /// </value>
        public Shopper? Shopper { get; private set; }

        /// <summary>
        /// Gets the name of the shopper.
        /// </summary>
        /// <value>
        /// The name of the shopper.
        /// </value>
        public string? ShopperName
        {
            get { return shoppername_txtbox.Text; }
        }

        /// <summary>
        /// Gets the money available.
        /// </summary>
        /// <value>
        /// The money available.
        /// </value>
        public decimal MoneyAvailable
        {
            get { return moneyavailable_numUpDown.Value; }
        }

        public ShopperForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ShopperForm"/> class.
        /// </summary>
        /// <param name="carLot">The car lot.</param>
        public ShopperForm(CarLot carLot)
        {
            InitializeComponent();
            this.carLot = carLot;
        }

        /// <summary>
        /// Handles the Click event of the save_btn control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void save_btn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(ShopperName))
            {
                MessageBox.Show("Please enter valid Name.");
                return;
            }

            if (MoneyAvailable <= 0)
            {
                MessageBox.Show("Invalid Money Available value. It must be greater than 0.");
                return;
            }
            Shopper = new Shopper(shoppername_txtbox.Text, moneyavailable_numUpDown.Value);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        /// <summary>
        /// Handles the Click event of the cancel_btn control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void cancel_btn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
        private void ShopperForm_Load(object sender, EventArgs e)
        {

        }
    }
}