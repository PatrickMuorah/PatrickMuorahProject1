namespace PatrickMuorahProject1.VIew
{
    partial class AddCarForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            make_txtbox = new TextBox();
            model_txtbox = new TextBox();
            mpg_UpDown = new NumericUpDown();
            price_UpDown = new NumericUpDown();
            make_lbl = new Label();
            model_lbl = new Label();
            mpg_lbl = new Label();
            price_lbl = new Label();
            save_Btn = new Button();
            cancel_Btn = new Button();
            ((System.ComponentModel.ISupportInitialize)mpg_UpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)price_UpDown).BeginInit();
            SuspendLayout();
            // 
            // make_txtbox
            // 
            make_txtbox.Location = new Point(234, 72);
            make_txtbox.Name = "make_txtbox";
            make_txtbox.Size = new Size(120, 23);
            make_txtbox.TabIndex = 0;
            make_txtbox.TextAlign = HorizontalAlignment.Center;
            // 
            // model_txtbox
            // 
            model_txtbox.Location = new Point(234, 111);
            model_txtbox.Name = "model_txtbox";
            model_txtbox.Size = new Size(120, 23);
            model_txtbox.TabIndex = 1;
            model_txtbox.TextAlign = HorizontalAlignment.Center;
            // 
            // mpg_UpDown
            // 
            mpg_UpDown.Location = new Point(234, 151);
            mpg_UpDown.Name = "mpg_UpDown";
            mpg_UpDown.Size = new Size(120, 23);
            mpg_UpDown.TabIndex = 2;
            mpg_UpDown.TextAlign = HorizontalAlignment.Center;
            mpg_UpDown.ThousandsSeparator = true;
            // 
            // price_UpDown
            // 
            price_UpDown.Location = new Point(234, 194);
            price_UpDown.Maximum = new decimal(new int[] { -727379968, 232, 0, 0 });
            price_UpDown.Name = "price_UpDown";
            price_UpDown.Size = new Size(120, 23);
            price_UpDown.TabIndex = 3;
            price_UpDown.TextAlign = HorizontalAlignment.Center;
            price_UpDown.ThousandsSeparator = true;
            // 
            // make_lbl
            // 
            make_lbl.AutoSize = true;
            make_lbl.Location = new Point(176, 75);
            make_lbl.Name = "make_lbl";
            make_lbl.Size = new Size(39, 15);
            make_lbl.TabIndex = 4;
            make_lbl.Text = "MAKE";
            // 
            // model_lbl
            // 
            model_lbl.AutoSize = true;
            model_lbl.Location = new Point(176, 119);
            model_lbl.Name = "model_lbl";
            model_lbl.Size = new Size(47, 15);
            model_lbl.TabIndex = 5;
            model_lbl.Text = "MODEL";
            // 
            // mpg_lbl
            // 
            mpg_lbl.AutoSize = true;
            mpg_lbl.Location = new Point(176, 153);
            mpg_lbl.Name = "mpg_lbl";
            mpg_lbl.Size = new Size(33, 15);
            mpg_lbl.TabIndex = 6;
            mpg_lbl.Text = "MPG";
            // 
            // price_lbl
            // 
            price_lbl.AutoSize = true;
            price_lbl.Location = new Point(176, 196);
            price_lbl.Name = "price_lbl";
            price_lbl.Size = new Size(38, 15);
            price_lbl.TabIndex = 7;
            price_lbl.Text = "PRICE";
            // 
            // save_Btn
            // 
            save_Btn.Location = new Point(138, 239);
            save_Btn.Name = "save_Btn";
            save_Btn.Size = new Size(75, 23);
            save_Btn.TabIndex = 8;
            save_Btn.Text = "SAVE";
            save_Btn.UseVisualStyleBackColor = true;
            save_Btn.Click += save_Btn_Click;
            // 
            // cancel_Btn
            // 
            cancel_Btn.Location = new Point(354, 239);
            cancel_Btn.Name = "cancel_Btn";
            cancel_Btn.Size = new Size(75, 23);
            cancel_Btn.TabIndex = 9;
            cancel_Btn.Text = "CANCEL";
            cancel_Btn.UseVisualStyleBackColor = true;
            cancel_Btn.Click += cancel_Btn_Click;
            // 
            // AddCarForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cancel_Btn);
            Controls.Add(save_Btn);
            Controls.Add(price_lbl);
            Controls.Add(mpg_lbl);
            Controls.Add(model_lbl);
            Controls.Add(make_lbl);
            Controls.Add(price_UpDown);
            Controls.Add(mpg_UpDown);
            Controls.Add(model_txtbox);
            Controls.Add(make_txtbox);
            Name = "AddCarForm";
            Text = "AddCarForm";
            Load += AddCarForm_Load;
            ((System.ComponentModel.ISupportInitialize)mpg_UpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)price_UpDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox make_txtbox;
        private TextBox model_txtbox;
        private NumericUpDown mpg_UpDown;
        private NumericUpDown price_UpDown;
        private Label make_lbl;
        private Label model_lbl;
        private Label mpg_lbl;
        private Label price_lbl;
        private Button save_Btn;
        private Button cancel_Btn;
    }
}