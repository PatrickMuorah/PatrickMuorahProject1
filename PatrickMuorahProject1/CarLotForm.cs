using PatrickMuorahProject1.Model;
using PatrickMuorahProject1.VIew;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace PatrickMuorahProject1
{
    public partial class CarLotForm : Form
    {
        /// <summary>
        /// The car lot object 
        /// </summary>
        private CarLot carLot;

        /// <summary>
        /// The shopper object
        /// </summary>
        private Shopper? shopper;

        /// <summary>
        /// The inventory list
        /// </summary>
        private List<Car>? InventoryList;

        public CarLotForm()
        {
            InitializeComponent();
            carLot = new CarLot();
            UpdateInventoryDisplay();
        }

        private void CarLotForm_Load(object sender, EventArgs e)
        {
            UpdateInventoryDisplay();
        }

        /// <summary>
        /// Adds the car to inventory.
        /// </summary>
        /// <param name="car">The car.</param>
        public void AddCarToInventory(Car car)
        {
            if (car != null)
            {
                carLot.Inventory.Add(car);
                UpdateInventoryDisplay();
            }
        }

        /// <summary>
        /// Handles the Click event of the addCar_btn control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void addCar_btn_Click(object sender, EventArgs e)
        {
            AddCarForm addCarForm = new AddCarForm();

            DialogResult result = addCarForm.ShowDialog();

            if (result == DialogResult.OK)
            {
                string make = addCarForm.Make;
                string model = addCarForm.Model;
                decimal mpg = addCarForm.Mpg;
                decimal price = addCarForm.Price;

                carLot.AddCar(make, model, mpg, price);
                UpdateInventoryDisplay();
            }
        }

        /// <summary>
        /// Handles the Click event of the addShopper_btn control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void addShopper_btn_Click(object sender, EventArgs e)
        {
            ShopperForm shopperForm = new ShopperForm(carLot);

            if (shopperForm.ShowDialog() == DialogResult.OK)
            {
                Shopper? shopper = shopperForm.Shopper;
                UpdateShopperInfo(shopper);
            }
        }

        /// <summary>
        /// Handles the Click event of the purchaseCar_btn control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void purchaseCar_btn_Click(object sender, EventArgs e)
        {
            if (carListBox == null)
            {
                throw new ArgumentNullException("Car list box cannot be null");
            }

            if (carListBox.SelectedItem == null)
            {
                MessageBox.Show("Please select a car to purchase.");
                return;
            }

            var selectedCarDetails = carListBox.SelectedItem.ToString().Split('-')[0];
            var selectedCarParts = selectedCarDetails.Trim().Split(' ');

            string make = selectedCarParts[0];
            string model = selectedCarParts[1];

            Car? selectedCar = carLot.Inventory.FirstOrDefault(c => c.Make == make && c.Model == model);

            if (selectedCar == null)
            {
                MessageBox.Show("Selected car not found.");
                return;
            }

            if (shopper.MoneyAvailable >= selectedCar.Price)
            {

                shopper.MoneyAvailable -= selectedCar.Price;

                carLot.Inventory.Remove(selectedCar);

                UpdateInventoryDisplay();

                MessageBox.Show($"You have successfully purchased the {selectedCar.Make} {selectedCar.Model}.");
            }
            else
            {
                MessageBox.Show("You do not have enough money to purchase this car.");
            }
        }

        /// <summary>
        /// Purchases a car.
        /// </summary>
        /// <param name="car">The car.</param>
        private void PurchaseCar(Car car)
        {
            if (shopper == null)
            {
                MessageBox.Show("Shopper information unavailable, Enter correct information.");
                return;
            }

            if (shopper.MoneyAvailable >= car.Price)
            {
                shopper.MoneyAvailable -= car.Price;

                MessageBox.Show($"Yayy! You just purchased the {car.Make} {car.Model} for {car.Price:C}. Money left: {shopper.MoneyAvailable:C}");

                moneyavailable_label.Text = $"Money Available: {shopper.MoneyAvailable:C}";
            }
            else
            {
                MessageBox.Show("Sorry, You do not have enough money to purchase this car.");
            }
        }

        /// <summary>
        /// Updates the inventory display.
        /// </summary>
        private void UpdateInventoryDisplay()
        {
            carListBox.Items.Clear();
            foreach (Car car in carLot.Inventory)
            {
                carListBox.Items.Add(car.ToString());
            }
        }

        /// <summary>
        /// Updates the shopper information.
        /// </summary>
        /// <param name="shopper">The shopper.</param>
        private void UpdateShopperInfo(Shopper? shopper)
        {
            shoppername_label.Text = shopper.Name;
            moneyavailable_label.Text = $"${shopper.MoneyAvailable:0.00}";
        }

    }
}
