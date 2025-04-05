namespace WinFormsApp1
{
    partial class ItemAddForm
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
            AddItemButton = new Button();
            textBoxItemName = new TextBox();
            textBoxFullName = new TextBox();
            textBoxEstimatedValue = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBoxLoanAmount = new TextBox();
            textBoxStoragePeriodDays = new TextBox();
            label4 = new Label();
            label5 = new Label();
            textBoxPhone = new TextBox();
            label6 = new Label();
            SuspendLayout();
            // 
            // AddItemButton
            // 
            AddItemButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            AddItemButton.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            AddItemButton.Location = new Point(643, 389);
            AddItemButton.Name = "AddItemButton";
            AddItemButton.RightToLeft = RightToLeft.No;
            AddItemButton.Size = new Size(145, 49);
            AddItemButton.TabIndex = 0;
            AddItemButton.Text = "Додати товар";
            AddItemButton.UseVisualStyleBackColor = true;
            AddItemButton.Click += AdditemButton_Click;
            // 
            // textBoxItemName
            // 
            textBoxItemName.Location = new Point(123, 9);
            textBoxItemName.MaxLength = 255;
            textBoxItemName.Name = "textBoxItemName";
            textBoxItemName.Size = new Size(100, 23);
            textBoxItemName.TabIndex = 1;
            textBoxItemName.TextChanged += textBox1_TextChanged;
            // 
            // textBoxFullName
            // 
            textBoxFullName.Location = new Point(123, 38);
            textBoxFullName.MaxLength = 255;
            textBoxFullName.Name = "textBoxFullName";
            textBoxFullName.Size = new Size(100, 23);
            textBoxFullName.TabIndex = 2;
            // 
            // textBoxEstimatedValue
            // 
            textBoxEstimatedValue.Location = new Point(123, 67);
            textBoxEstimatedValue.Name = "textBoxEstimatedValue";
            textBoxEstimatedValue.Size = new Size(100, 23);
            textBoxEstimatedValue.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(94, 15);
            label1.TabIndex = 4;
            label1.Text = "Назва предмету";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 38);
            label2.Name = "label2";
            label2.Size = new Size(28, 15);
            label2.TabIndex = 5;
            label2.Text = "ФІО";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 67);
            label3.Name = "label3";
            label3.Size = new Size(107, 15);
            label3.TabIndex = 6;
            label3.Text = "Оціночна вартість";
            // 
            // textBoxLoanAmount
            // 
            textBoxLoanAmount.Location = new Point(123, 96);
            textBoxLoanAmount.Name = "textBoxLoanAmount";
            textBoxLoanAmount.Size = new Size(100, 23);
            textBoxLoanAmount.TabIndex = 7;
            // 
            // textBoxStoragePeriodDays
            // 
            textBoxStoragePeriodDays.Location = new Point(123, 125);
            textBoxStoragePeriodDays.Name = "textBoxStoragePeriodDays";
            textBoxStoragePeriodDays.Size = new Size(100, 23);
            textBoxStoragePeriodDays.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 96);
            label4.Name = "label4";
            label4.Size = new Size(82, 15);
            label4.TabIndex = 9;
            label4.Text = "Сума кредиту";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 125);
            label5.Name = "label5";
            label5.Size = new Size(102, 15);
            label5.TabIndex = 10;
            label5.Text = "Строк зберігання";
            // 
            // textBoxPhone
            // 
            textBoxPhone.Location = new Point(123, 154);
            textBoxPhone.MaxLength = 13;
            textBoxPhone.Name = "textBoxPhone";
            textBoxPhone.Size = new Size(100, 23);
            textBoxPhone.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 154);
            label6.Name = "label6";
            label6.Size = new Size(101, 15);
            label6.TabIndex = 12;
            label6.Text = "Номер телефону";
            // 
            // ItemAddForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label6);
            Controls.Add(textBoxPhone);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(textBoxStoragePeriodDays);
            Controls.Add(textBoxLoanAmount);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxEstimatedValue);
            Controls.Add(textBoxFullName);
            Controls.Add(textBoxItemName);
            Controls.Add(AddItemButton);
            MinimumSize = new Size(444, 235);
            Name = "ItemAddForm";
            Text = "Додавання предмету";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button AddItemButton;
        private TextBox textBoxItemName;
        private TextBox textBoxFullName;
        private TextBox textBoxEstimatedValue;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBoxLoanAmount;
        private TextBox textBoxStoragePeriodDays;
        private Label label4;
        private Label label5;
        private TextBox textBoxPhone;
        private Label label6;
    }
}