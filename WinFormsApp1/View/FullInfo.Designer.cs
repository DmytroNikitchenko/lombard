namespace lombard.View
{
    partial class FullInfo
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
            labelClientPhone = new Label();
            labelClientName = new Label();
            labelClientId = new Label();
            labelItemStatus = new Label();
            labelStorageDays = new Label();
            labelDepositDate = new Label();
            labelLoanAmount = new Label();
            labelEstimatedValue = new Label();
            labelItemName = new Label();
            labelItemId = new Label();
            labelSaleReturnDate = new Label();
            textItemId = new TextBox();
            textItemName = new TextBox();
            textEstimatedValue = new TextBox();
            textLoanAmount = new TextBox();
            textDepositDate = new TextBox();
            textStorageDays = new TextBox();
            textItemStatus = new TextBox();
            textSaleReturnDate = new TextBox();
            textClientId = new TextBox();
            textClientName = new TextBox();
            textClientPhone = new TextBox();
            textItemCategory = new TextBox();
            labelItemCategory = new Label();
            labelSaleReturnPrice = new Label();
            textSaleReturnPrice = new TextBox();
            SuspendLayout();
            // 
            // label11
            // 
            labelClientPhone.AutoSize = true;
            labelClientPhone.Font = new Font("Segoe UI", 12F);
            labelClientPhone.Location = new Point(12, 367);
            labelClientPhone.Name = "label11";
            labelClientPhone.Size = new Size(188, 21);
            labelClientPhone.TabIndex = 19;
            labelClientPhone.Text = "Номер телефону клієнта:";
            // 
            // label12
            // 
            labelClientName.AutoSize = true;
            labelClientName.Font = new Font("Segoe UI", 12F);
            labelClientName.Location = new Point(12, 346);
            labelClientName.Name = "label12";
            labelClientName.Size = new Size(95, 21);
            labelClientName.TabIndex = 18;
            labelClientName.Text = "Ім'я клієнта:";
            // 
            // label13
            // 
            labelClientId.AutoSize = true;
            labelClientId.Font = new Font("Segoe UI", 12F);
            labelClientId.Location = new Point(12, 325);
            labelClientId.Name = "label13";
            labelClientId.Size = new Size(83, 21);
            labelClientId.TabIndex = 17;
            labelClientId.Text = "ID клієнта:";
            // 
            // label14
            // 
            labelItemStatus.AutoSize = true;
            labelItemStatus.Font = new Font("Segoe UI", 12F);
            labelItemStatus.Location = new Point(12, 156);
            labelItemStatus.Name = "label14";
            labelItemStatus.Size = new Size(60, 21);
            labelItemStatus.TabIndex = 16;
            labelItemStatus.Text = "Статус:";
            // 
            // label15
            // 
            labelStorageDays.AutoSize = true;
            labelStorageDays.Font = new Font("Segoe UI", 12F);
            labelStorageDays.Location = new Point(12, 135);
            labelStorageDays.Name = "label15";
            labelStorageDays.Size = new Size(188, 21);
            labelStorageDays.TabIndex = 15;
            labelStorageDays.Text = "Термін збереження (дн.):";
            // 
            // label16
            // 
            labelDepositDate.AutoSize = true;
            labelDepositDate.Font = new Font("Segoe UI", 12F);
            labelDepositDate.Location = new Point(12, 114);
            labelDepositDate.Name = "label16";
            labelDepositDate.Size = new Size(115, 21);
            labelDepositDate.TabIndex = 14;
            labelDepositDate.Text = "Дата прийому:";
            // 
            // label17
            // 
            labelLoanAmount.AutoSize = true;
            labelLoanAmount.Font = new Font("Segoe UI", 12F);
            labelLoanAmount.Location = new Point(12, 93);
            labelLoanAmount.Name = "label17";
            labelLoanAmount.Size = new Size(153, 21);
            labelLoanAmount.TabIndex = 13;
            labelLoanAmount.Text = "Сума кредиту (грн.):";
            // 
            // label18
            // 
            labelEstimatedValue.AutoSize = true;
            labelEstimatedValue.Font = new Font("Segoe UI", 12F);
            labelEstimatedValue.Location = new Point(12, 72);
            labelEstimatedValue.Name = "label18";
            labelEstimatedValue.Size = new Size(186, 21);
            labelEstimatedValue.TabIndex = 12;
            labelEstimatedValue.Text = "Оціночна вартість (грн.):";
            // 
            // label19
            // 
            labelItemName.AutoSize = true;
            labelItemName.Font = new Font("Segoe UI", 12F);
            labelItemName.Location = new Point(12, 30);
            labelItemName.Name = "label19";
            labelItemName.Size = new Size(108, 21);
            labelItemName.TabIndex = 11;
            labelItemName.Text = "Назва товару:";
            // 
            // label20
            // 
            labelItemId.AutoSize = true;
            labelItemId.Font = new Font("Segoe UI", 12F);
            labelItemId.Location = new Point(12, 9);
            labelItemId.Name = "label20";
            labelItemId.Size = new Size(81, 21);
            labelItemId.TabIndex = 10;
            labelItemId.Text = "ID товару:";
            // 
            // label21
            // 
            labelSaleReturnDate.AutoSize = true;
            labelSaleReturnDate.Font = new Font("Segoe UI", 12F);
            labelSaleReturnDate.Location = new Point(12, 212);
            labelSaleReturnDate.Name = "label21";
            labelSaleReturnDate.Size = new Size(207, 21);
            labelSaleReturnDate.TabIndex = 21;
            labelSaleReturnDate.Text = "Дата продажу/повернення:";
            // 
            // textBox1
            // 
            textItemId.BackColor = SystemColors.Window;
            textItemId.ForeColor = SystemColors.WindowText;
            textItemId.Location = new Point(315, 12);
            textItemId.Name = "textBox1";
            textItemId.ReadOnly = true;
            textItemId.Size = new Size(298, 23);
            textItemId.TabIndex = 22;
            // 
            // textBox2
            // 
            textItemName.BackColor = SystemColors.Window;
            textItemName.ForeColor = SystemColors.WindowText;
            textItemName.Location = new Point(315, 32);
            textItemName.Name = "textBox2";
            textItemName.ReadOnly = true;
            textItemName.Size = new Size(298, 23);
            textItemName.TabIndex = 23;
            // 
            // textBox3
            // 
            textEstimatedValue.BackColor = SystemColors.Window;
            textEstimatedValue.ForeColor = SystemColors.WindowText;
            textEstimatedValue.Location = new Point(315, 74);
            textEstimatedValue.Name = "textBox3";
            textEstimatedValue.ReadOnly = true;
            textEstimatedValue.Size = new Size(298, 23);
            textEstimatedValue.TabIndex = 24;
            // 
            // textBox4
            // 
            textLoanAmount.BackColor = SystemColors.Window;
            textLoanAmount.ForeColor = SystemColors.WindowText;
            textLoanAmount.Location = new Point(315, 95);
            textLoanAmount.Name = "textBox4";
            textLoanAmount.ReadOnly = true;
            textLoanAmount.Size = new Size(298, 23);
            textLoanAmount.TabIndex = 25;
            // 
            // textBox5
            // 
            textDepositDate.BackColor = SystemColors.Window;
            textDepositDate.ForeColor = SystemColors.WindowText;
            textDepositDate.Location = new Point(315, 116);
            textDepositDate.Name = "textBox5";
            textDepositDate.ReadOnly = true;
            textDepositDate.Size = new Size(298, 23);
            textDepositDate.TabIndex = 26;
            // 
            // textBox6
            // 
            textStorageDays.BackColor = SystemColors.Window;
            textStorageDays.ForeColor = SystemColors.WindowText;
            textStorageDays.Location = new Point(315, 137);
            textStorageDays.Name = "textBox6";
            textStorageDays.ReadOnly = true;
            textStorageDays.Size = new Size(298, 23);
            textStorageDays.TabIndex = 27;
            // 
            // textBox7
            // 
            textItemStatus.BackColor = SystemColors.Window;
            textItemStatus.ForeColor = SystemColors.WindowText;
            textItemStatus.Location = new Point(315, 158);
            textItemStatus.Name = "textBox7";
            textItemStatus.ReadOnly = true;
            textItemStatus.Size = new Size(298, 23);
            textItemStatus.TabIndex = 28;
            // 
            // textBox8
            // 
            textSaleReturnDate.BackColor = SystemColors.Window;
            textSaleReturnDate.ForeColor = SystemColors.WindowText;
            textSaleReturnDate.Location = new Point(315, 214);
            textSaleReturnDate.Name = "textBox8";
            textSaleReturnDate.ReadOnly = true;
            textSaleReturnDate.Size = new Size(298, 23);
            textSaleReturnDate.TabIndex = 29;
            // 
            // textBox9
            // 
            textClientId.BackColor = SystemColors.Window;
            textClientId.ForeColor = SystemColors.WindowText;
            textClientId.Location = new Point(315, 327);
            textClientId.Name = "textBox9";
            textClientId.ReadOnly = true;
            textClientId.Size = new Size(298, 23);
            textClientId.TabIndex = 30;
            // 
            // textBox10
            // 
            textClientName.BackColor = SystemColors.Window;
            textClientName.ForeColor = SystemColors.WindowText;
            textClientName.Location = new Point(315, 348);
            textClientName.Name = "textBox10";
            textClientName.ReadOnly = true;
            textClientName.Size = new Size(298, 23);
            textClientName.TabIndex = 31;
            // 
            // textBox11
            // 
            textClientPhone.BackColor = SystemColors.Window;
            textClientPhone.ForeColor = SystemColors.WindowText;
            textClientPhone.Location = new Point(315, 369);
            textClientPhone.Name = "textBox11";
            textClientPhone.ReadOnly = true;
            textClientPhone.Size = new Size(298, 23);
            textClientPhone.TabIndex = 32;
            // 
            // textBox12
            // 
            textItemCategory.BackColor = SystemColors.Window;
            textItemCategory.ForeColor = SystemColors.WindowText;
            textItemCategory.Location = new Point(315, 53);
            textItemCategory.Name = "textBox12";
            textItemCategory.ReadOnly = true;
            textItemCategory.Size = new Size(298, 23);
            textItemCategory.TabIndex = 34;
            // 
            // label1
            // 
            labelItemCategory.AutoSize = true;
            labelItemCategory.Font = new Font("Segoe UI", 12F);
            labelItemCategory.Location = new Point(12, 51);
            labelItemCategory.Name = "label1";
            labelItemCategory.Size = new Size(81, 21);
            labelItemCategory.TabIndex = 33;
            labelItemCategory.Text = "Категорія:";
            // 
            // label2
            // 
            labelSaleReturnPrice.AutoSize = true;
            labelSaleReturnPrice.Font = new Font("Segoe UI", 12F);
            labelSaleReturnPrice.Location = new Point(12, 233);
            labelSaleReturnPrice.Name = "label2";
            labelSaleReturnPrice.Size = new Size(295, 21);
            labelSaleReturnPrice.TabIndex = 35;
            labelSaleReturnPrice.Text = "Ціна, по якій продано/повернено (грн.):";
            // 
            // textBox13
            // 
            textSaleReturnPrice.BackColor = SystemColors.Window;
            textSaleReturnPrice.ForeColor = SystemColors.WindowText;
            textSaleReturnPrice.Location = new Point(315, 236);
            textSaleReturnPrice.Name = "textBox13";
            textSaleReturnPrice.ReadOnly = true;
            textSaleReturnPrice.Size = new Size(298, 23);
            textSaleReturnPrice.TabIndex = 36;
            // 
            // FullInfo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(854, 426);
            Controls.Add(textSaleReturnPrice);
            Controls.Add(labelSaleReturnPrice);
            Controls.Add(textItemCategory);
            Controls.Add(labelItemCategory);
            Controls.Add(textClientPhone);
            Controls.Add(textClientName);
            Controls.Add(textClientId);
            Controls.Add(textSaleReturnDate);
            Controls.Add(textItemStatus);
            Controls.Add(textStorageDays);
            Controls.Add(textDepositDate);
            Controls.Add(textLoanAmount);
            Controls.Add(textEstimatedValue);
            Controls.Add(textItemName);
            Controls.Add(textItemId);
            Controls.Add(labelSaleReturnDate);
            Controls.Add(labelClientPhone);
            Controls.Add(labelClientName);
            Controls.Add(labelClientId);
            Controls.Add(labelItemStatus);
            Controls.Add(labelStorageDays);
            Controls.Add(labelDepositDate);
            Controls.Add(labelLoanAmount);
            Controls.Add(labelEstimatedValue);
            Controls.Add(labelItemName);
            Controls.Add(labelItemId);
            MinimumSize = new Size(569, 368);
            Name = "FullInfo";
            Text = "Повна інформація";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label labelClientPhone;
        private Label labelClientName;
        private Label labelClientId;
        private Label labelItemStatus;
        private Label labelStorageDays;
        private Label labelDepositDate;
        private Label labelLoanAmount;
        private Label labelEstimatedValue;
        private Label labelItemName;
        private Label labelItemId;
        private Label labelSaleReturnDate;
        private TextBox textItemId;
        private TextBox textItemName;
        private TextBox textEstimatedValue;
        private TextBox textLoanAmount;
        private TextBox textDepositDate;
        private TextBox textStorageDays;
        private TextBox textItemStatus;
        private TextBox textSaleReturnDate;
        private TextBox textClientId;
        private TextBox textClientName;
        private TextBox textClientPhone;
        private TextBox textItemCategory;
        private Label labelItemCategory;
        private Label labelSaleReturnPrice;
        private TextBox textSaleReturnPrice;
    }
}