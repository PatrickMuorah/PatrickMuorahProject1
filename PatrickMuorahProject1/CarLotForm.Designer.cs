namespace PatrickMuorahProject1
{
    partial class CarLotForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            addCar_btn = new Button();
            shoppername_label = new Label();
            moneyavailable_label = new Label();
            addShopper_btn = new Button();
            purchaseCar_btn = new Button();
            carListBox = new ListBox();
            inventory_Btn = new Button();
            close_Btn = new Button();
            SuspendLayout();
            // 
            // addCar_btn
            // 
            addCar_btn.Location = new Point(155, 254);
            addCar_btn.Name = "addCar_btn";
            addCar_btn.Size = new Size(88, 35);
            addCar_btn.TabIndex = 0;
            addCar_btn.Text = "Add Car";
            addCar_btn.UseVisualStyleBackColor = true;
            addCar_btn.Click += addCar_btn_Click;
            // 
            // shoppername_label
            // 
            shoppername_label.AutoSize = true;
            shoppername_label.Location = new Point(182, 110);
            shoppername_label.Name = "shoppername_label";
            shoppername_label.Size = new Size(86, 15);
            shoppername_label.TabIndex = 1;
            shoppername_label.Text = "Shopper Name";
            // 
            // moneyavailable_label
            // 
            moneyavailable_label.AutoSize = true;
            moneyavailable_label.Location = new Point(434, 110);
            moneyavailable_label.Name = "moneyavailable_label";
            moneyavailable_label.Size = new Size(95, 15);
            moneyavailable_label.TabIndex = 2;
            moneyavailable_label.Text = "Money Available";
            // 
            // addShopper_btn
            // 
            addShopper_btn.Location = new Point(301, 254);
            addShopper_btn.Name = "addShopper_btn";
            addShopper_btn.Size = new Size(94, 35);
            addShopper_btn.TabIndex = 3;
            addShopper_btn.Text = "Add Shopper";
            addShopper_btn.UseVisualStyleBackColor = true;
            addShopper_btn.Click += addShopper_btn_Click;
            // 
            // purchaseCar_btn
            // 
            purchaseCar_btn.Location = new Point(482, 254);
            purchaseCar_btn.Name = "purchaseCar_btn";
            purchaseCar_btn.Size = new Size(100, 35);
            purchaseCar_btn.TabIndex = 4;
            purchaseCar_btn.Text = "Purchase Car";
            purchaseCar_btn.UseVisualStyleBackColor = true;
            purchaseCar_btn.Click += purchaseCar_btn_Click;
            // 
            // carListBox
            // 
            carListBox.FormattingEnabled = true;
            carListBox.ItemHeight = 15;
            carListBox.Location = new Point(287, 125);
            carListBox.Name = "carListBox";
            carListBox.Size = new Size(120, 94);
            carListBox.TabIndex = 5;
            // 
            // inventory_Btn
            // 
            inventory_Btn.Location = new Point(301, 334);
            inventory_Btn.Name = "inventory_Btn";
            inventory_Btn.Size = new Size(94, 31);
            inventory_Btn.TabIndex = 6;
            inventory_Btn.Text = "View Inventory";
            inventory_Btn.UseVisualStyleBackColor = true;
            inventory_Btn.Click += inventory_Btn_Click;
            // 
            // close_Btn
            // 
            close_Btn.Location = new Point(301, 381);
            close_Btn.Name = "close_Btn";
            close_Btn.Size = new Size(94, 23);
            close_Btn.TabIndex = 7;
            close_Btn.Text = "Close";
            close_Btn.UseVisualStyleBackColor = true;
            close_Btn.Click += close_Btn_Click;
            // 
            // CarLotForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(close_Btn);
            Controls.Add(inventory_Btn);
            Controls.Add(carListBox);
            Controls.Add(purchaseCar_btn);
            Controls.Add(addShopper_btn);
            Controls.Add(moneyavailable_label);
            Controls.Add(shoppername_label);
            Controls.Add(addCar_btn);
            Name = "CarLotForm";
            Text = "CarLotForm";
            Load += CarLotForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button addCar_btn;
        private Label shoppername_label;
        private Label moneyavailable_label;
        private Button addShopper_btn;
        private Button purchaseCar_btn;
        private ListBox carListBox;
        private Button inventory_Btn;
        private Button close_Btn;
    }
}
