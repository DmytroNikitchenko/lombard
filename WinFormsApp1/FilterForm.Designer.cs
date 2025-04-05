namespace WinFormsApp1
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
            textBoxSearchName = new TextBox();
            comboBoxCategory = new ComboBox();
            comboBoxStatus = new ComboBox();
            numericUpDownMinValue = new NumericUpDown();
            numericUpDownMaxValue = new NumericUpDown();
            dateTimePickerFrom = new DateTimePicker();
            dateTimePickerTo = new DateTimePicker();
            buttonFilter = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDownMinValue).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownMaxValue).BeginInit();
            SuspendLayout();
            // 
            // textBoxSearchName
            // 
            textBoxSearchName.Font = new Font("Segoe UI", 12F);
            textBoxSearchName.Location = new Point(193, 9);
            textBoxSearchName.MaxLength = 255;
            textBoxSearchName.Name = "textBoxSearchName";
            textBoxSearchName.Size = new Size(200, 29);
            textBoxSearchName.TabIndex = 0;
            textBoxSearchName.Text = "comboBoxCategory";
            // 
            // comboBoxCategory
            // 
            comboBoxCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxCategory.Font = new Font("Segoe UI", 12F);
            comboBoxCategory.FormattingEnabled = true;
            comboBoxCategory.Items.AddRange(new object[] { "Усі", "Золото", "Срібло", "Коштовності", "Годинники", "Електроніка", "Автомобілі", "Бутова техніка", "Музичні інструменти", "Колекційні предмети", "Зброя", "Предмети мистецтва", "Меблі", "Гроші монети банкноти", "Одяг", "Інше" });
            comboBoxCategory.Location = new Point(193, 61);
            comboBoxCategory.Name = "comboBoxCategory";
            comboBoxCategory.Size = new Size(200, 29);
            comboBoxCategory.TabIndex = 1;
            // 
            // comboBoxStatus
            // 
            comboBoxStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxStatus.Font = new Font("Segoe UI", 12F);
            comboBoxStatus.FormattingEnabled = true;
            comboBoxStatus.Items.AddRange(new object[] { "Усі", "Зберігається", "Повернено", "Продано" });
            comboBoxStatus.Location = new Point(193, 90);
            comboBoxStatus.Name = "comboBoxStatus";
            comboBoxStatus.Size = new Size(200, 29);
            comboBoxStatus.TabIndex = 2;
            // 
            // numericUpDownMinValue
            // 
            numericUpDownMinValue.Font = new Font("Segoe UI", 12F);
            numericUpDownMinValue.Location = new Point(193, 152);
            numericUpDownMinValue.Name = "numericUpDownMinValue";
            numericUpDownMinValue.Size = new Size(200, 29);
            numericUpDownMinValue.TabIndex = 3;
            // 
            // numericUpDownMaxValue
            // 
            numericUpDownMaxValue.Font = new Font("Segoe UI", 12F);
            numericUpDownMaxValue.Location = new Point(193, 181);
            numericUpDownMaxValue.Maximum = new decimal(new int[] { 100000000, 0, 0, 0 });
            numericUpDownMaxValue.Name = "numericUpDownMaxValue";
            numericUpDownMaxValue.Size = new Size(200, 29);
            numericUpDownMaxValue.TabIndex = 4;
            // 
            // dateTimePickerFrom
            // 
            dateTimePickerFrom.Font = new Font("Segoe UI", 12F);
            dateTimePickerFrom.Location = new Point(193, 226);
            dateTimePickerFrom.Name = "dateTimePickerFrom";
            dateTimePickerFrom.Size = new Size(200, 29);
            dateTimePickerFrom.TabIndex = 5;
            // 
            // dateTimePickerTo
            // 
            dateTimePickerTo.Font = new Font("Segoe UI", 12F);
            dateTimePickerTo.Location = new Point(193, 255);
            dateTimePickerTo.Name = "dateTimePickerTo";
            dateTimePickerTo.Size = new Size(200, 29);
            dateTimePickerTo.TabIndex = 6;
            // 
            // buttonFilter
            // 
            buttonFilter.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonFilter.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonFilter.Location = new Point(653, 388);
            buttonFilter.Name = "buttonFilter";
            buttonFilter.Size = new Size(135, 50);
            buttonFilter.TabIndex = 7;
            buttonFilter.Text = "Фільтрувати";
            buttonFilter.UseVisualStyleBackColor = true;
            buttonFilter.Click += buttonFilter_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(55, 21);
            label1.TabIndex = 8;
            label1.Text = "Назва:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(12, 64);
            label2.Name = "label2";
            label2.Size = new Size(81, 21);
            label2.TabIndex = 9;
            label2.Text = "Категорія:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.Location = new Point(12, 93);
            label3.Name = "label3";
            label3.Size = new Size(60, 21);
            label3.TabIndex = 10;
            label3.Text = "Статус:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label4.Location = new Point(12, 154);
            label4.Name = "label4";
            label4.Size = new Size(131, 21);
            label4.TabIndex = 11;
            label4.Text = "Мін. оц. вартість:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label5.Location = new Point(12, 181);
            label5.Name = "label5";
            label5.Size = new Size(141, 21);
            label5.TabIndex = 12;
            label5.Text = "Макс. оц. вартість:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label6.Location = new Point(12, 232);
            label6.Name = "label6";
            label6.Size = new Size(110, 21);
            label6.TabIndex = 13;
            label6.Text = "Починаючи з:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label7.Location = new Point(12, 261);
            label7.Name = "label7";
            label7.Size = new Size(120, 21);
            label7.TabIndex = 14;
            label7.Text = "Закінчуючи на:";
            // 
            // FilterForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttonFilter);
            Controls.Add(dateTimePickerTo);
            Controls.Add(dateTimePickerFrom);
            Controls.Add(numericUpDownMaxValue);
            Controls.Add(numericUpDownMinValue);
            Controls.Add(comboBoxStatus);
            Controls.Add(comboBoxCategory);
            Controls.Add(textBoxSearchName);
            MinimumSize = new Size(581, 341);
            Name = "FilterForm";
            Text = "Фільтрація";
            ((System.ComponentModel.ISupportInitialize)numericUpDownMinValue).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownMaxValue).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxSearchName;
        private ComboBox comboBoxCategory;
        private ComboBox comboBoxStatus;
        private NumericUpDown numericUpDownMinValue;
        private NumericUpDown numericUpDownMaxValue;
        private DateTimePicker dateTimePickerFrom;
        private DateTimePicker dateTimePickerTo;
        private Button buttonFilter;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
    }
}