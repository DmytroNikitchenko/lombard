namespace lombard.View
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
            comboBoxCategories = new ComboBox();
            label7 = new Label();
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
            AddItemButton.Text = "Додати запис";
            AddItemButton.UseVisualStyleBackColor = true;
            AddItemButton.Click += AdditemButton_Click;
            // 
            // textBoxItemName
            // 
            textBoxItemName.Location = new Point(158, 9);
            textBoxItemName.MaxLength = 255;
            textBoxItemName.Name = "textBoxItemName";
            textBoxItemName.Size = new Size(100, 23);
            textBoxItemName.TabIndex = 1;
            // 
            // textBoxFullName
            // 
            textBoxFullName.Location = new Point(158, 38);
            textBoxFullName.MaxLength = 255;
            textBoxFullName.Name = "textBoxFullName";
            textBoxFullName.Size = new Size(100, 23);
            textBoxFullName.TabIndex = 2;
            textBoxFullName.KeyPress += textBoxFullName_KeyPress;
            // 
            // textBoxEstimatedValue
            // 
            textBoxEstimatedValue.Location = new Point(158, 67);
            textBoxEstimatedValue.Name = "textBoxEstimatedValue";
            textBoxEstimatedValue.Size = new Size(100, 23);
            textBoxEstimatedValue.TabIndex = 3;
            textBoxEstimatedValue.KeyPress += textBoxEstimatedValue_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(97, 15);
            label1.TabIndex = 4;
            label1.Text = "Назва предмету:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 38);
            label2.Name = "label2";
            label2.Size = new Size(31, 15);
            label2.TabIndex = 5;
            label2.Text = "ФІО:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 67);
            label3.Name = "label3";
            label3.Size = new Size(140, 15);
            label3.TabIndex = 6;
            label3.Text = "Оціночна вартість (грн):";
            // 
            // textBoxLoanAmount
            // 
            textBoxLoanAmount.Location = new Point(158, 96);
            textBoxLoanAmount.Name = "textBoxLoanAmount";
            textBoxLoanAmount.Size = new Size(100, 23);
            textBoxLoanAmount.TabIndex = 7;
            textBoxLoanAmount.KeyPress += textBoxLoanAmount_KeyPress;
            // 
            // textBoxStoragePeriodDays
            // 
            textBoxStoragePeriodDays.Location = new Point(158, 125);
            textBoxStoragePeriodDays.Name = "textBoxStoragePeriodDays";
            textBoxStoragePeriodDays.Size = new Size(100, 23);
            textBoxStoragePeriodDays.TabIndex = 8;
            textBoxStoragePeriodDays.KeyPress += textBoxStoragePeriodDays_KeyPress;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 96);
            label4.Name = "label4";
            label4.Size = new Size(118, 15);
            label4.TabIndex = 9;
            label4.Text = "Сума кредиту (грн.):";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 125);
            label5.Name = "label5";
            label5.Size = new Size(132, 15);
            label5.TabIndex = 10;
            label5.Text = "Строк зберігання (дн.):";
            // 
            // textBoxPhone
            // 
            textBoxPhone.Location = new Point(158, 154);
            textBoxPhone.MaxLength = 10;
            textBoxPhone.Name = "textBoxPhone";
            textBoxPhone.Size = new Size(100, 23);
            textBoxPhone.TabIndex = 11;
            textBoxPhone.KeyPress += textBoxPhone_KeyPress;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 154);
            label6.Name = "label6";
            label6.Size = new Size(104, 15);
            label6.TabIndex = 12;
            label6.Text = "Номер телефону:";
            // 
            // comboBoxCategories
            // 
            comboBoxCategories.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxCategories.FormattingEnabled = true;
            comboBoxCategories.Items.AddRange(new object[] { "Золото", "Срібло", "Коштовності", "Годинники", "Електроніка", "Автомобілі", "Побутова техніка", "Музичні інструменти", "Колекційні предмети", "Зброя", "Предмети мистецтва", "Меблі", "Гроші, монети, банкноти", "Одяг", "Інше" });
            comboBoxCategories.Location = new Point(356, 9);
            comboBoxCategories.Name = "comboBoxCategories";
            comboBoxCategories.Size = new Size(156, 23);
            comboBoxCategories.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(288, 12);
            label7.Name = "label7";
            label7.Size = new Size(62, 15);
            label7.TabIndex = 14;
            label7.Text = "Категорія:";
            // 
            // ItemAddForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label7);
            Controls.Add(comboBoxCategories);
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
            MinimumSize = new Size(548, 237);
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
        private ComboBox comboBoxCategories;
        private Label label7;
    }
}