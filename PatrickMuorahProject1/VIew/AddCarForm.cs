using PatrickMuorahProject1.Model;
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
    public partial class AddCarForm : Form
    {
        /// <summary>
        /// Gets the car object.
        /// </summary>
        /// <value>
        /// The car.
        /// </value>
        public Car? Car { get; private set; }

        /// <summary>
        /// Gets the make of the car in the text box.
        /// </summary>
        /// <value>
        /// The make.
        /// </value>
        public string Make
        {
            get { return make_txtbox.Text; }
        }

        /// <summary>
        /// Gets the model of the car in the text box.
        /// </summary>
        /// <value>
        /// The model.
        /// </value>
        public string Model
        {
            get { return model_txtbox.Text; }
        }

        /// <summary>
        /// Gets the MPG of the car in the numeric updown.
        /// </summary>
        /// <value>
        /// The MPG.
        /// </value>
        public decimal Mpg
        {
            get { return mpg_UpDown.Value; }
        }

        /// <summary>
        /// Gets the price of the car in the numeric updown.
        /// </summary>
        /// <value>
        /// The price.
        /// </value>
        public decimal Price
        {
            get { return price_UpDown.Value; }
        }


        public AddCarForm()
        {
            InitializeComponent();
        }

        private void AddCarForm_Load(object sender, EventArgs e)
        {
            
        }

        /// <summary>
        /// Handles the Click event of the save_Btn control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void save_Btn_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrWhiteSpace(Make))
            {
                MessageBox.Show("Please enter a valid car Make.");
                return;
            }

            if (string.IsNullOrWhiteSpace(Model))
            {
                MessageBox.Show("Please enter a valid car Model.");
                return;
            }

            if (Mpg <= 0)
            {
                MessageBox.Show("The MPG must be greater than 0.");
                return;
            }

            if (Price <= 0)
            {
                MessageBox.Show("Price must be greater than 0.");
                return;
            }

            Car = new Car(Make, Model, Mpg, Price);

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        /// <summary>
        /// Handles the Click event of the cancel_Btn control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void cancel_Btn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
