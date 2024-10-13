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
            SuspendLayout();
            // 
            // addCar_btn
            // 
            addCar_btn.Location = new Point(68, 181);
            addCar_btn.Name = "addCar_btn";
            addCar_btn.Size = new Size(88, 35);
            addCar_btn.TabIndex = 0;
            addCar_btn.Text = "Add Car";
            addCar_btn.UseVisualStyleBackColor = true;
            addCar_btn.Click += addCar_btn_Click;
            // 
            // CarLotForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(addCar_btn);
            Name = "CarLotForm";
            Text = "CarLotForm";
            Load += CarLotForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button addCar_btn;
    }
}
