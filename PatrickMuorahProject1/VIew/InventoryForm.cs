﻿using PatrickMuorahProject1.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace PatrickMuorahProject1.VIew
{
    public partial class InventoryForm : Form
    {
        private CarLot carLot;

        private List<Car> inventory;
        public InventoryForm(List<Car> carList)
        {
            this.inventory = carList;
            carLot = new CarLot();
            InitializeComponent();
            DisplayInventory();
        }

        private void DisplayInventory()
        {
            string inventoryReport = "Inventory of " + carLot.Inventory.Count + " cars:\n";

            Car? bestMpgCar = null;
            Car? worstMpgCar = null;

            foreach (var car in carLot.Inventory)
            {
                inventoryReport += car.Make + " " + car.Model + "\n";
                inventoryReport += "$" + car.Price.ToString("F2") + " " + car.Mpg + "mpg\n";

                if (bestMpgCar == null || car.Mpg > bestMpgCar.Mpg)
                {
                    bestMpgCar = car;
                }

                if (worstMpgCar == null || car.Mpg < worstMpgCar.Mpg)
                {
                    worstMpgCar = car;
                }
            }

            if (bestMpgCar != null)
            {
                inventoryReport += "Best MPG:\n" + bestMpgCar.Make + " " + bestMpgCar.Model +
                                   " $" + bestMpgCar.Price.ToString("F2") + " " + bestMpgCar.Mpg + "mpg\n";
            }

            if (worstMpgCar != null)
            {
                inventoryReport += "Worst MPG:\n" + worstMpgCar.Make + " " + worstMpgCar.Model +
                                   " $" + worstMpgCar.Price.ToString("F2") + " " + worstMpgCar.Mpg + "mpg\n";
            }

            inventory_textBox.Text = inventoryReport;
        }

        private void close_Btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
