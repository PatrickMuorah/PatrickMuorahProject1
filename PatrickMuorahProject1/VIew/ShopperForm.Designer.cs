using PatrickMuorahProject1.Model;

namespace PatrickMuorahProject1.VIew
{
    partial class ShopperForm
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
            save_btn = new Button();
            cancel_btn = new Button();
            shoppername_txtbox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            moneyavailable_numUpDown = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)moneyavailable_numUpDown).BeginInit();
            SuspendLayout();
            // 
            // save_btn
            // 
            save_btn.Location = new Point(127, 114);
            save_btn.Name = "save_btn";
            save_btn.Size = new Size(75, 23);
            save_btn.TabIndex = 8;
            save_btn.Text = "SAVE";
            save_btn.UseVisualStyleBackColor = true;
            save_btn.Click += save_btn_Click;
            // 
            // cancel_btn
            // 
            cancel_btn.Location = new Point(287, 114);
            cancel_btn.Name = "cancel_btn";
            cancel_btn.Size = new Size(75, 23);
            cancel_btn.TabIndex = 9;
            cancel_btn.Text = "CANCEL";
            cancel_btn.UseVisualStyleBackColor = true;
            cancel_btn.Click += cancel_btn_Click;
            // 
            // shoppername_txtbox
            // 
            shoppername_txtbox.Location = new Point(242, 37);
            shoppername_txtbox.Name = "shoppername_txtbox";
            shoppername_txtbox.Size = new Size(120, 23);
            shoppername_txtbox.TabIndex = 11;
            shoppername_txtbox.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(127, 69);
            label1.Name = "label1";
            label1.Size = new Size(109, 15);
            label1.TabIndex = 12;
            label1.Text = "MONEY AVAILABLE";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(127, 40);
            label2.Name = "label2";
            label2.Size = new Size(95, 15);
            label2.TabIndex = 13;
            label2.Text = "SHOPPER NAME";
            // 
            // moneyavailable_numUpDown
            // 
            moneyavailable_numUpDown.Location = new Point(242, 66);
            moneyavailable_numUpDown.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            moneyavailable_numUpDown.Name = "moneyavailable_numUpDown";
            moneyavailable_numUpDown.Size = new Size(120, 23);
            moneyavailable_numUpDown.TabIndex = 14;
            moneyavailable_numUpDown.TextAlign = HorizontalAlignment.Center;
            moneyavailable_numUpDown.ThousandsSeparator = true;
            // 
            // ShopperForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(moneyavailable_numUpDown);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(shoppername_txtbox);
            Controls.Add(cancel_btn);
            Controls.Add(save_btn);
            Name = "ShopperForm";
            Text = "ShopperForm";
            Load += ShopperForm_Load;
            ((System.ComponentModel.ISupportInitialize)moneyavailable_numUpDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button save_btn;
        private Button cancel_btn;
        private TextBox shoppername_txtbox;
        private Label label1;
        private Label label2;
        private NumericUpDown moneyavailable_numUpDown;
    }
}