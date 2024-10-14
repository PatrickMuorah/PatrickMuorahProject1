namespace PatrickMuorahProject1.VIew
{
    partial class InventoryForm
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
            inventory_textBox = new TextBox();
            close_Btn = new Button();
            SuspendLayout();
            // 
            // inventory_textBox
            // 
            inventory_textBox.Location = new Point(142, 44);
            inventory_textBox.Multiline = true;
            inventory_textBox.Name = "inventory_textBox";
            inventory_textBox.ReadOnly = true;
            inventory_textBox.Size = new Size(346, 207);
            inventory_textBox.TabIndex = 0;
            inventory_textBox.TextAlign = HorizontalAlignment.Center;
            // 
            // close_Btn
            // 
            close_Btn.Location = new Point(278, 274);
            close_Btn.Name = "close_Btn";
            close_Btn.Size = new Size(75, 23);
            close_Btn.TabIndex = 1;
            close_Btn.Text = "CLOSE";
            close_Btn.UseVisualStyleBackColor = true;
            close_Btn.Click += close_Btn_Click;
            // 
            // InventoryForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(close_Btn);
            Controls.Add(inventory_textBox);
            Name = "InventoryForm";
            Text = "InventoryForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox inventory_textBox;
        private Button close_Btn;
    }
}