using PatrickMuorahProject1.Model;
using PatrickMuorahProject1.VIew;

namespace PatrickMuorahProject1
{
    public partial class CarLotForm : Form
    {
        public CarLotForm()
        {
            InitializeComponent();
            CarLot carLoat = new CarLot();
        }

        private void CarLotForm_Load(object sender, EventArgs e)
        {

        }

        private void addCar_btn_Click(object sender, EventArgs e)
        {
            ShopperForm shopperForm = new ShopperForm();
            if (shopperForm.ShowDialog() == DialogResult.OK)
            {
                // Create a new shopper and display the shopper information
                Shopper newShopper = new Shopper(shopperForm.ShopperName, shopperForm.MoneyAvailable);
                // Add additional logic for displaying the shopper info, e.g., on the form
                MessageBox.Show("Shopper created.");
            }

        }
    }
}
