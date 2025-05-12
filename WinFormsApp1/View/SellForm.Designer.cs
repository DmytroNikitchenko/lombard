namespace lombard.View
{
    partial class SellForm
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
            textBoxFullName = new TextBox();
            buttonSell = new Button();
            labelFullName = new Label();
            labelBuyerNumber = new Label();
            textBoxBuyerNumber = new TextBox();
            SuspendLayout();
            // 
            // textBoxFullName
            // 
            textBoxFullName.Font = new Font("Microsoft Sans Serif", 12F);
            textBoxFullName.Location = new Point(241, 6);
            textBoxFullName.MaxLength = 255;
            textBoxFullName.Name = "textBoxFullName";
            textBoxFullName.Size = new Size(247, 26);
            textBoxFullName.TabIndex = 0;
            textBoxFullName.KeyPress += textBoxFullName_KeyPress;
            // 
            // buttonSell
            // 
            buttonSell.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonSell.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonSell.Location = new Point(518, 113);
            buttonSell.Name = "buttonSell";
            buttonSell.Size = new Size(118, 44);
            buttonSell.TabIndex = 1;
            buttonSell.Text = "Продати";
            buttonSell.UseVisualStyleBackColor = true;
            buttonSell.Click += buttonSell_Click;
            // 
            // labelFullName
            // 
            labelFullName.AutoSize = true;
            labelFullName.Font = new Font("Microsoft Sans Serif", 12F);
            labelFullName.Location = new Point(12, 9);
            labelFullName.Name = "labelFullName";
            labelFullName.Size = new Size(105, 20);
            labelFullName.TabIndex = 2;
            labelFullName.Text = "ПІБ покупця:";
            // 
            // labelBuyerNumber
            // 
            labelBuyerNumber.AutoSize = true;
            labelBuyerNumber.Font = new Font("Microsoft Sans Serif", 12F);
            labelBuyerNumber.Location = new Point(12, 63);
            labelBuyerNumber.Name = "labelBuyerNumber";
            labelBuyerNumber.Size = new Size(208, 20);
            labelBuyerNumber.TabIndex = 4;
            labelBuyerNumber.Text = "Номер телефону покупця:";
            // 
            // textBoxBuyerNumber
            // 
            textBoxBuyerNumber.Font = new Font("Microsoft Sans Serif", 12F);
            textBoxBuyerNumber.Location = new Point(241, 60);
            textBoxBuyerNumber.MaxLength = 10;
            textBoxBuyerNumber.Name = "textBoxBuyerNumber";
            textBoxBuyerNumber.Size = new Size(247, 26);
            textBoxBuyerNumber.TabIndex = 3;
            textBoxBuyerNumber.KeyPress += textBoxBuyerNumber_KeyPress;
            // 
            // SellForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(648, 169);
            Controls.Add(labelBuyerNumber);
            Controls.Add(textBoxBuyerNumber);
            Controls.Add(labelFullName);
            Controls.Add(buttonSell);
            Controls.Add(textBoxFullName);
            MaximumSize = new Size(664, 208);
            MinimumSize = new Size(664, 208);
            Name = "SellForm";
            Text = "Продаж";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxFullName;
        private Button buttonSell;
        private Label labelFullName;
        private Label labelBuyerNumber;
        private TextBox textBoxBuyerNumber;
    }
}