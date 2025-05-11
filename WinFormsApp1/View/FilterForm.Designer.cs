namespace lombard.View
{
    partial class FilterForm
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
            textBoxName = new TextBox();
            comboBoxCategory = new ComboBox();
            comboBoxStorageStatus = new ComboBox();
            numericMinEstimatedValue = new NumericUpDown();
            numericMaxEstimatedValue = new NumericUpDown();
            datePickerFromDate = new DateTimePicker();
            datePickerToDate = new DateTimePicker();
            buttonApplyFilter = new Button();
            labelName = new Label();
            labelCategory = new Label();
            labelStorageStatus = new Label();
            labelMinEstimatedValue = new Label();
            labelMaxEstimatedValue = new Label();
            labelFromDate = new Label();
            labelToDate = new Label();
            labelStatusForSaleOrReturn = new Label();
            comboBoxStatusForSaleOrReturn = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)numericMinEstimatedValue).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericMaxEstimatedValue).BeginInit();
            SuspendLayout();
            // 
            // textBoxName
            // 
            textBoxName.Font = new Font("Segoe UI", 12F);
            textBoxName.Location = new Point(201, 6);
            textBoxName.MaxLength = 255;
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(200, 29);
            textBoxName.TabIndex = 0;
            // 
            // comboBoxCategory
            // 
            comboBoxCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxCategory.Font = new Font("Segoe UI", 12F);
            comboBoxCategory.FormattingEnabled = true;
            comboBoxCategory.Items.AddRange(new object[] { "Усі", "Золото", "Срібло", "Коштовності", "Годинники", "Електроніка", "Автомобілі", "Побутова техніка", "Музичні інструменти", "Колекційні предмети", "Зброя", "Предмети мистецтва", "Меблі", "Гроші, монети, банкноти", "Одяг", "Інше" });
            comboBoxCategory.Location = new Point(201, 55);
            comboBoxCategory.Name = "comboBoxCategory";
            comboBoxCategory.Size = new Size(200, 29);
            comboBoxCategory.TabIndex = 1;
            // 
            // comboBoxStorageStatus
            // 
            comboBoxStorageStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxStorageStatus.Font = new Font("Segoe UI", 12F);
            comboBoxStorageStatus.FormattingEnabled = true;
            comboBoxStorageStatus.Items.AddRange(new object[] { "Усі", "Зберігається", "Повернено", "Продано" });
            comboBoxStorageStatus.Location = new Point(201, 90);
            comboBoxStorageStatus.Name = "comboBoxStorageStatus";
            comboBoxStorageStatus.Size = new Size(200, 29);
            comboBoxStorageStatus.TabIndex = 2;
            // 
            // numericMinEstimatedValue
            // 
            numericMinEstimatedValue.Font = new Font("Segoe UI", 12F);
            numericMinEstimatedValue.Location = new Point(201, 193);
            numericMinEstimatedValue.Maximum = new decimal(new int[] { 268435455, 1042612833, 542101086, 0 });
            numericMinEstimatedValue.Name = "numericMinEstimatedValue";
            numericMinEstimatedValue.Size = new Size(200, 29);
            numericMinEstimatedValue.TabIndex = 3;
            // 
            // numericMaxEstimatedValue
            // 
            numericMaxEstimatedValue.Font = new Font("Segoe UI", 12F);
            numericMaxEstimatedValue.Location = new Point(201, 222);
            numericMaxEstimatedValue.Maximum = new decimal(new int[] { 268435455, 1042612833, 542101086, 0 });
            numericMaxEstimatedValue.Name = "numericMaxEstimatedValue";
            numericMaxEstimatedValue.Size = new Size(200, 29);
            numericMaxEstimatedValue.TabIndex = 4;
            numericMaxEstimatedValue.Value = new decimal(new int[] { 1000, 0, 0, 0 });
            // 
            // datePickerFromDate
            // 
            datePickerFromDate.Font = new Font("Segoe UI", 12F);
            datePickerFromDate.Location = new Point(201, 267);
            datePickerFromDate.Name = "datePickerFromDate";
            datePickerFromDate.Size = new Size(200, 29);
            datePickerFromDate.TabIndex = 5;
            // 
            // datePickerToDate
            // 
            datePickerToDate.Font = new Font("Segoe UI", 12F);
            datePickerToDate.Location = new Point(201, 296);
            datePickerToDate.Name = "datePickerToDate";
            datePickerToDate.Size = new Size(200, 29);
            datePickerToDate.TabIndex = 6;
            // 
            // buttonApplyFilter
            // 
            buttonApplyFilter.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonApplyFilter.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonApplyFilter.Location = new Point(653, 388);
            buttonApplyFilter.Name = "buttonApplyFilter";
            buttonApplyFilter.Size = new Size(135, 50);
            buttonApplyFilter.TabIndex = 7;
            buttonApplyFilter.Text = "Фільтрувати";
            buttonApplyFilter.UseVisualStyleBackColor = true;
            buttonApplyFilter.Click += buttonFilter_Click;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelName.Location = new Point(12, 9);
            labelName.Name = "labelName";
            labelName.Size = new Size(55, 21);
            labelName.TabIndex = 8;
            labelName.Text = "Назва:";
            // 
            // labelCategory
            // 
            labelCategory.AutoSize = true;
            labelCategory.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelCategory.Location = new Point(12, 58);
            labelCategory.Name = "labelCategory";
            labelCategory.Size = new Size(81, 21);
            labelCategory.TabIndex = 9;
            labelCategory.Text = "Категорія:";
            // 
            // labelStorageStatus
            // 
            labelStorageStatus.AutoSize = true;
            labelStorageStatus.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelStorageStatus.Location = new Point(12, 93);
            labelStorageStatus.Name = "labelStorageStatus";
            labelStorageStatus.Size = new Size(129, 21);
            labelStorageStatus.TabIndex = 10;
            labelStorageStatus.Text = "Статус на складі:";
            // 
            // labelMinEstimatedValue
            // 
            labelMinEstimatedValue.AutoSize = true;
            labelMinEstimatedValue.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelMinEstimatedValue.Location = new Point(12, 195);
            labelMinEstimatedValue.Name = "labelMinEstimatedValue";
            labelMinEstimatedValue.Size = new Size(172, 21);
            labelMinEstimatedValue.TabIndex = 11;
            labelMinEstimatedValue.Text = "Мін. оц. вартість (грн.):";
            // 
            // labelMaxEstimatedValue
            // 
            labelMaxEstimatedValue.AutoSize = true;
            labelMaxEstimatedValue.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelMaxEstimatedValue.Location = new Point(12, 222);
            labelMaxEstimatedValue.Name = "labelMaxEstimatedValue";
            labelMaxEstimatedValue.Size = new Size(182, 21);
            labelMaxEstimatedValue.TabIndex = 12;
            labelMaxEstimatedValue.Text = "Макс. оц. вартість (грн.):";
            // 
            // labelFromDate
            // 
            labelFromDate.AutoSize = true;
            labelFromDate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelFromDate.Location = new Point(12, 273);
            labelFromDate.Name = "labelFromDate";
            labelFromDate.Size = new Size(110, 21);
            labelFromDate.TabIndex = 13;
            labelFromDate.Text = "Починаючи з:";
            // 
            // labelToDate
            // 
            labelToDate.AutoSize = true;
            labelToDate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelToDate.Location = new Point(12, 302);
            labelToDate.Name = "labelToDate";
            labelToDate.Size = new Size(120, 21);
            labelToDate.TabIndex = 14;
            labelToDate.Text = "Закінчуючи на:";
            // 
            // labelStatusForSaleOrReturn
            // 
            labelStatusForSaleOrReturn.AutoSize = true;
            labelStatusForSaleOrReturn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelStatusForSaleOrReturn.Location = new Point(12, 128);
            labelStatusForSaleOrReturn.Name = "labelStatusForSaleOrReturn";
            labelStatusForSaleOrReturn.Size = new Size(157, 21);
            labelStatusForSaleOrReturn.TabIndex = 16;
            labelStatusForSaleOrReturn.Text = "Статус для продажу:";
            // 
            // comboBoxStatusForSaleOrReturn
            // 
            comboBoxStatusForSaleOrReturn.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxStatusForSaleOrReturn.Font = new Font("Segoe UI", 12F);
            comboBoxStatusForSaleOrReturn.FormattingEnabled = true;
            comboBoxStatusForSaleOrReturn.Items.AddRange(new object[] { "Усі", "Продається", "Очікує на повернення", "Продано", "Повернено" });
            comboBoxStatusForSaleOrReturn.Location = new Point(201, 125);
            comboBoxStatusForSaleOrReturn.Name = "comboBoxStatusForSaleOrReturn";
            comboBoxStatusForSaleOrReturn.Size = new Size(200, 29);
            comboBoxStatusForSaleOrReturn.TabIndex = 15;
            // 
            // FilterForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelStatusForSaleOrReturn);
            Controls.Add(comboBoxStatusForSaleOrReturn);
            Controls.Add(labelToDate);
            Controls.Add(labelFromDate);
            Controls.Add(labelMaxEstimatedValue);
            Controls.Add(labelMinEstimatedValue);
            Controls.Add(labelStorageStatus);
            Controls.Add(labelCategory);
            Controls.Add(labelName);
            Controls.Add(buttonApplyFilter);
            Controls.Add(datePickerToDate);
            Controls.Add(datePickerFromDate);
            Controls.Add(numericMaxEstimatedValue);
            Controls.Add(numericMinEstimatedValue);
            Controls.Add(comboBoxStorageStatus);
            Controls.Add(comboBoxCategory);
            Controls.Add(textBoxName);
            MinimumSize = new Size(581, 369);
            Name = "FilterForm";
            Text = "Фільтрація";
            ((System.ComponentModel.ISupportInitialize)numericMinEstimatedValue).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericMaxEstimatedValue).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxName;
        private ComboBox comboBoxCategory;
        private ComboBox comboBoxStorageStatus;
        private NumericUpDown numericMinEstimatedValue;
        private NumericUpDown numericMaxEstimatedValue;
        private DateTimePicker datePickerFromDate;
        private DateTimePicker datePickerToDate;
        private Button buttonApplyFilter;
        private Label labelName;
        private Label labelCategory;
        private Label labelStorageStatus;
        private Label labelMinEstimatedValue;
        private Label labelMaxEstimatedValue;
        private Label labelFromDate;
        private Label labelToDate;
        private Label labelStatusForSaleOrReturn;
        private ComboBox comboBoxStatusForSaleOrReturn;
    }
}