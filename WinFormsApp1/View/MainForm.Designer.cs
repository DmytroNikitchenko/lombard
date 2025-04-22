namespace lombard.View
{
    partial class MainForm
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
            ArrayViev = new DataGridView();
            buttonToAddForm = new Button();
            buttonCheckInfo = new Button();
            buttonDeleteItem = new Button();
            buttonRefound = new Button();
            buttonSell = new Button();
            buttonSearch = new Button();
            textBoxSearch = new TextBox();
            buttonSearchClear = new Button();
            buttonFilter = new Button();
            ((System.ComponentModel.ISupportInitialize)ArrayViev).BeginInit();
            SuspendLayout();
            // 
            // ArrayViev
            // 
            ArrayViev.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ArrayViev.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            ArrayViev.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            ArrayViev.BackgroundColor = Color.Lavender;
            ArrayViev.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ArrayViev.Location = new Point(0, 0);
            ArrayViev.MultiSelect = false;
            ArrayViev.Name = "ArrayViev";
            ArrayViev.ReadOnly = true;
            ArrayViev.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ArrayViev.Size = new Size(875, 583);
            ArrayViev.TabIndex = 0;
            ArrayViev.ColumnHeaderMouseClick += ArrayViev_ColumnHeaderMouseClick;
            ArrayViev.KeyDown += ArrayViev_KeyDown;
            // 
            // buttonToAddForm
            // 
            buttonToAddForm.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonToAddForm.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonToAddForm.Location = new Point(880, 212);
            buttonToAddForm.Name = "buttonToAddForm";
            buttonToAddForm.Size = new Size(135, 50);
            buttonToAddForm.TabIndex = 1;
            buttonToAddForm.Text = "Додати запис";
            buttonToAddForm.UseVisualStyleBackColor = true;
            buttonToAddForm.Click += buttonToAddForm_Click;
            // 
            // buttonCheckInfo
            // 
            buttonCheckInfo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonCheckInfo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonCheckInfo.Location = new Point(878, 268);
            buttonCheckInfo.Name = "buttonCheckInfo";
            buttonCheckInfo.Size = new Size(135, 50);
            buttonCheckInfo.TabIndex = 2;
            buttonCheckInfo.Text = "Вся інфо";
            buttonCheckInfo.UseVisualStyleBackColor = true;
            buttonCheckInfo.Click += buttonCheckInfo_Click;
            // 
            // buttonDeleteItem
            // 
            buttonDeleteItem.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonDeleteItem.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonDeleteItem.Location = new Point(881, 521);
            buttonDeleteItem.Name = "buttonDeleteItem";
            buttonDeleteItem.Size = new Size(135, 50);
            buttonDeleteItem.TabIndex = 4;
            buttonDeleteItem.Text = "Видалити";
            buttonDeleteItem.UseVisualStyleBackColor = true;
            buttonDeleteItem.Click += buttonDeleteItem_Click;
            // 
            // buttonRefound
            // 
            buttonRefound.Anchor = AnchorStyles.Right;
            buttonRefound.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonRefound.Location = new Point(881, 369);
            buttonRefound.Name = "buttonRefound";
            buttonRefound.Size = new Size(135, 50);
            buttonRefound.TabIndex = 5;
            buttonRefound.Text = "Повернення";
            buttonRefound.UseVisualStyleBackColor = true;
            buttonRefound.Click += buttonRefound_Click;
            // 
            // buttonSell
            // 
            buttonSell.Anchor = AnchorStyles.Right;
            buttonSell.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonSell.Location = new Point(881, 425);
            buttonSell.Name = "buttonSell";
            buttonSell.Size = new Size(135, 50);
            buttonSell.TabIndex = 6;
            buttonSell.Text = "Продаж ";
            buttonSell.UseVisualStyleBackColor = true;
            buttonSell.Click += buttonSell_Click;
            // 
            // buttonSearch
            // 
            buttonSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonSearch.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonSearch.Location = new Point(881, 41);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(135, 50);
            buttonSearch.TabIndex = 7;
            buttonSearch.Text = "Пошук";
            buttonSearch.UseVisualStyleBackColor = true;
            buttonSearch.Click += buttonSearch_Click;
            // 
            // textBoxSearch
            // 
            textBoxSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBoxSearch.Location = new Point(881, 12);
            textBoxSearch.MaxLength = 255;
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(133, 23);
            textBoxSearch.TabIndex = 8;
            textBoxSearch.KeyDown += textBoxSearch_KeyDown;
            // 
            // buttonSearchClear
            // 
            buttonSearchClear.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonSearchClear.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonSearchClear.Location = new Point(881, 97);
            buttonSearchClear.Name = "buttonSearchClear";
            buttonSearchClear.Size = new Size(135, 30);
            buttonSearchClear.TabIndex = 9;
            buttonSearchClear.Text = "Повернути вид";
            buttonSearchClear.UseVisualStyleBackColor = true;
            buttonSearchClear.Click += buttonSearchClear_Click;
            // 
            // buttonFilter
            // 
            buttonFilter.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonFilter.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonFilter.Location = new Point(880, 133);
            buttonFilter.Name = "buttonFilter";
            buttonFilter.Size = new Size(135, 50);
            buttonFilter.TabIndex = 10;
            buttonFilter.Text = "Фільтрація";
            buttonFilter.UseVisualStyleBackColor = true;
            buttonFilter.Click += buttonFilter_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(1026, 583);
            Controls.Add(buttonFilter);
            Controls.Add(buttonSearchClear);
            Controls.Add(textBoxSearch);
            Controls.Add(buttonSearch);
            Controls.Add(buttonSell);
            Controls.Add(buttonRefound);
            Controls.Add(buttonDeleteItem);
            Controls.Add(buttonCheckInfo);
            Controls.Add(buttonToAddForm);
            Controls.Add(ArrayViev);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            KeyPreview = true;
            MinimumSize = new Size(950, 500);
            Name = "MainForm";
            Text = "Ломбард";
            ((System.ComponentModel.ISupportInitialize)ArrayViev).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView ArrayViev;
        private Button buttonToAddForm;
        private Button buttonCheckInfo;
        private Button buttonDeleteItem;
        private Button buttonRefound;
        private Button buttonSell;
        private Button buttonSearch;
        private TextBox textBoxSearch;
        private Button buttonSearchClear;
        private Button buttonFilter;
    }
}