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
            textBoxStatusToSaleOrReturn = new TextBox();
            labelStatusToSaleOrReturn = new Label();
            SuspendLayout();
            // 
            // labelClientPhone
            // 
            labelClientPhone.AutoSize = true;
            labelClientPhone.Font = new Font("Segoe UI", 12F);
            labelClientPhone.Location = new Point(12, 367);
            labelClientPhone.Name = "labelClientPhone";
            labelClientPhone.Size = new Size(188, 21);
            labelClientPhone.TabIndex = 19;
            labelClientPhone.Text = "Номер телефону клієнта:";
            // 
            // labelClientName
            // 
            labelClientName.AutoSize = true;
            labelClientName.Font = new Font("Segoe UI", 12F);
            labelClientName.Location = new Point(12, 346);
            labelClientName.Name = "labelClientName";
            labelClientName.Size = new Size(92, 21);
            labelClientName.TabIndex = 18;
            labelClientName.Text = "ПІБ клієнта:";
            // 
            // labelClientId
            // 
            labelClientId.AutoSize = true;
            labelClientId.Font = new Font("Segoe UI", 12F);
            labelClientId.Location = new Point(12, 325);
            labelClientId.Name = "labelClientId";
            labelClientId.Size = new Size(83, 21);
            labelClientId.TabIndex = 17;
            labelClientId.Text = "ID клієнта:";
            // 
            // labelItemStatus
            // 
            labelItemStatus.AutoSize = true;
            labelItemStatus.Font = new Font("Segoe UI", 12F);
            labelItemStatus.Location = new Point(12, 156);
            labelItemStatus.Name = "labelItemStatus";
            labelItemStatus.Size = new Size(129, 21);
            labelItemStatus.TabIndex = 16;
            labelItemStatus.Text = "Статус на складі:";
            // 
            // labelStorageDays
            // 
            labelStorageDays.AutoSize = true;
            labelStorageDays.Font = new Font("Segoe UI", 12F);
            labelStorageDays.Location = new Point(12, 135);
            labelStorageDays.Name = "labelStorageDays";
            labelStorageDays.Size = new Size(188, 21);
            labelStorageDays.TabIndex = 15;
            labelStorageDays.Text = "Термін збереження (дн.):";
            // 
            // labelDepositDate
            // 
            labelDepositDate.AutoSize = true;
            labelDepositDate.Font = new Font("Segoe UI", 12F);
            labelDepositDate.Location = new Point(12, 114);
            labelDepositDate.Name = "labelDepositDate";
            labelDepositDate.Size = new Size(115, 21);
            labelDepositDate.TabIndex = 14;
            labelDepositDate.Text = "Дата прийому:";
            // 
            // labelLoanAmount
            // 
            labelLoanAmount.AutoSize = true;
            labelLoanAmount.Font = new Font("Segoe UI", 12F);
            labelLoanAmount.Location = new Point(12, 93);
            labelLoanAmount.Name = "labelLoanAmount";
            labelLoanAmount.Size = new Size(153, 21);
            labelLoanAmount.TabIndex = 13;
            labelLoanAmount.Text = "Сума кредиту (грн.):";
            // 
            // labelEstimatedValue
            // 
            labelEstimatedValue.AutoSize = true;
            labelEstimatedValue.Font = new Font("Segoe UI", 12F);
            labelEstimatedValue.Location = new Point(12, 72);
            labelEstimatedValue.Name = "labelEstimatedValue";
            labelEstimatedValue.Size = new Size(186, 21);
            labelEstimatedValue.TabIndex = 12;
            labelEstimatedValue.Text = "Оціночна вартість (грн.):";
            // 
            // labelItemName
            // 
            labelItemName.AutoSize = true;
            labelItemName.Font = new Font("Segoe UI", 12F);
            labelItemName.Location = new Point(12, 30);
            labelItemName.Name = "labelItemName";
            labelItemName.Size = new Size(108, 21);
            labelItemName.TabIndex = 11;
            labelItemName.Text = "Назва товару:";
            // 
            // labelItemId
            // 
            labelItemId.AutoSize = true;
            labelItemId.Font = new Font("Segoe UI", 12F);
            labelItemId.Location = new Point(12, 9);
            labelItemId.Name = "labelItemId";
            labelItemId.Size = new Size(81, 21);
            labelItemId.TabIndex = 10;
            labelItemId.Text = "ID товару:";
            // 
            // labelSaleReturnDate
            // 
            labelSaleReturnDate.AutoSize = true;
            labelSaleReturnDate.Font = new Font("Segoe UI", 12F);
            labelSaleReturnDate.Location = new Point(12, 241);
            labelSaleReturnDate.Name = "labelSaleReturnDate";
            labelSaleReturnDate.Size = new Size(207, 21);
            labelSaleReturnDate.TabIndex = 21;
            labelSaleReturnDate.Text = "Дата продажу/повернення:";
            // 
            // textItemId
            // 
            textItemId.BackColor = SystemColors.Window;
            textItemId.ForeColor = SystemColors.WindowText;
            textItemId.Location = new Point(315, 12);
            textItemId.Name = "textItemId";
            textItemId.ReadOnly = true;
            textItemId.Size = new Size(298, 23);
            textItemId.TabIndex = 22;
            // 
            // textItemName
            // 
            textItemName.BackColor = SystemColors.Window;
            textItemName.ForeColor = SystemColors.WindowText;
            textItemName.Location = new Point(315, 32);
            textItemName.Name = "textItemName";
            textItemName.ReadOnly = true;
            textItemName.Size = new Size(298, 23);
            textItemName.TabIndex = 23;
            // 
            // textEstimatedValue
            // 
            textEstimatedValue.BackColor = SystemColors.Window;
            textEstimatedValue.ForeColor = SystemColors.WindowText;
            textEstimatedValue.Location = new Point(315, 74);
            textEstimatedValue.Name = "textEstimatedValue";
            textEstimatedValue.ReadOnly = true;
            textEstimatedValue.Size = new Size(298, 23);
            textEstimatedValue.TabIndex = 24;
            // 
            // textLoanAmount
            // 
            textLoanAmount.BackColor = SystemColors.Window;
            textLoanAmount.ForeColor = SystemColors.WindowText;
            textLoanAmount.Location = new Point(315, 95);
            textLoanAmount.Name = "textLoanAmount";
            textLoanAmount.ReadOnly = true;
            textLoanAmount.Size = new Size(298, 23);
            textLoanAmount.TabIndex = 25;
            // 
            // textDepositDate
            // 
            textDepositDate.BackColor = SystemColors.Window;
            textDepositDate.ForeColor = SystemColors.WindowText;
            textDepositDate.Location = new Point(315, 116);
            textDepositDate.Name = "textDepositDate";
            textDepositDate.ReadOnly = true;
            textDepositDate.Size = new Size(298, 23);
            textDepositDate.TabIndex = 26;
            // 
            // textStorageDays
            // 
            textStorageDays.BackColor = SystemColors.Window;
            textStorageDays.ForeColor = SystemColors.WindowText;
            textStorageDays.Location = new Point(315, 137);
            textStorageDays.Name = "textStorageDays";
            textStorageDays.ReadOnly = true;
            textStorageDays.Size = new Size(298, 23);
            textStorageDays.TabIndex = 27;
            // 
            // textItemStatus
            // 
            textItemStatus.BackColor = SystemColors.Window;
            textItemStatus.ForeColor = SystemColors.WindowText;
            textItemStatus.Location = new Point(315, 158);
            textItemStatus.Name = "textItemStatus";
            textItemStatus.ReadOnly = true;
            textItemStatus.Size = new Size(298, 23);
            textItemStatus.TabIndex = 28;
            // 
            // textSaleReturnDate
            // 
            textSaleReturnDate.BackColor = SystemColors.Window;
            textSaleReturnDate.ForeColor = SystemColors.WindowText;
            textSaleReturnDate.Location = new Point(315, 243);
            textSaleReturnDate.Name = "textSaleReturnDate";
            textSaleReturnDate.ReadOnly = true;
            textSaleReturnDate.Size = new Size(298, 23);
            textSaleReturnDate.TabIndex = 29;
            // 
            // textClientId
            // 
            textClientId.BackColor = SystemColors.Window;
            textClientId.ForeColor = SystemColors.WindowText;
            textClientId.Location = new Point(315, 327);
            textClientId.Name = "textClientId";
            textClientId.ReadOnly = true;
            textClientId.Size = new Size(298, 23);
            textClientId.TabIndex = 30;
            // 
            // textClientName
            // 
            textClientName.BackColor = SystemColors.Window;
            textClientName.ForeColor = SystemColors.WindowText;
            textClientName.Location = new Point(315, 348);
            textClientName.Name = "textClientName";
            textClientName.ReadOnly = true;
            textClientName.Size = new Size(298, 23);
            textClientName.TabIndex = 31;
            // 
            // textClientPhone
            // 
            textClientPhone.BackColor = SystemColors.Window;
            textClientPhone.ForeColor = SystemColors.WindowText;
            textClientPhone.Location = new Point(315, 369);
            textClientPhone.Name = "textClientPhone";
            textClientPhone.ReadOnly = true;
            textClientPhone.Size = new Size(298, 23);
            textClientPhone.TabIndex = 32;
            // 
            // textItemCategory
            // 
            textItemCategory.BackColor = SystemColors.Window;
            textItemCategory.ForeColor = SystemColors.WindowText;
            textItemCategory.Location = new Point(315, 53);
            textItemCategory.Name = "textItemCategory";
            textItemCategory.ReadOnly = true;
            textItemCategory.Size = new Size(298, 23);
            textItemCategory.TabIndex = 34;
            // 
            // labelItemCategory
            // 
            labelItemCategory.AutoSize = true;
            labelItemCategory.Font = new Font("Segoe UI", 12F);
            labelItemCategory.Location = new Point(12, 51);
            labelItemCategory.Name = "labelItemCategory";
            labelItemCategory.Size = new Size(81, 21);
            labelItemCategory.TabIndex = 33;
            labelItemCategory.Text = "Категорія:";
            // 
            // labelSaleReturnPrice
            // 
            labelSaleReturnPrice.AutoSize = true;
            labelSaleReturnPrice.Font = new Font("Segoe UI", 12F);
            labelSaleReturnPrice.Location = new Point(12, 262);
            labelSaleReturnPrice.Name = "labelSaleReturnPrice";
            labelSaleReturnPrice.Size = new Size(295, 21);
            labelSaleReturnPrice.TabIndex = 35;
            labelSaleReturnPrice.Text = "Ціна, по якій продано/повернено (грн.):";
            // 
            // textSaleReturnPrice
            // 
            textSaleReturnPrice.BackColor = SystemColors.Window;
            textSaleReturnPrice.ForeColor = SystemColors.WindowText;
            textSaleReturnPrice.Location = new Point(315, 265);
            textSaleReturnPrice.Name = "textSaleReturnPrice";
            textSaleReturnPrice.ReadOnly = true;
            textSaleReturnPrice.Size = new Size(298, 23);
            textSaleReturnPrice.TabIndex = 36;
            // 
            // textBoxStatusToSaleOrReturn
            // 
            textBoxStatusToSaleOrReturn.BackColor = SystemColors.Window;
            textBoxStatusToSaleOrReturn.ForeColor = SystemColors.WindowText;
            textBoxStatusToSaleOrReturn.Location = new Point(315, 179);
            textBoxStatusToSaleOrReturn.Name = "textBoxStatusToSaleOrReturn";
            textBoxStatusToSaleOrReturn.ReadOnly = true;
            textBoxStatusToSaleOrReturn.Size = new Size(298, 23);
            textBoxStatusToSaleOrReturn.TabIndex = 38;
            // 
            // labelStatusToSaleOrReturn
            // 
            labelStatusToSaleOrReturn.AutoSize = true;
            labelStatusToSaleOrReturn.Font = new Font("Segoe UI", 12F);
            labelStatusToSaleOrReturn.Location = new Point(12, 177);
            labelStatusToSaleOrReturn.Name = "labelStatusToSaleOrReturn";
            labelStatusToSaleOrReturn.Size = new Size(171, 21);
            labelStatusToSaleOrReturn.TabIndex = 37;
            labelStatusToSaleOrReturn.Text = "Статус на до продажу:";
            // 
            // FullInfo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(854, 426);
            Controls.Add(textBoxStatusToSaleOrReturn);
            Controls.Add(labelStatusToSaleOrReturn);
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
            MinimumSize = new Size(653, 444);
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
        private TextBox textBoxStatusToSaleOrReturn;
        private Label labelStatusToSaleOrReturn;
    }
}