namespace View
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this._toolStrip = new System.Windows.Forms.ToolStrip();
            this._toolStripDropDownButton = new System.Windows.Forms.ToolStripDropDownButton();
            this._saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._randomButton = new System.Windows.Forms.Button();
            this._groupBoxCalculation = new System.Windows.Forms.GroupBox();
            this._dataGridViewSpace = new System.Windows.Forms.DataGridView();
            this._groupBoxEdit = new System.Windows.Forms.GroupBox();
            this._clearButton = new System.Windows.Forms.Button();
            this._deleteButton = new System.Windows.Forms.Button();
            this._resetFilterButton = new System.Windows.Forms.Button();
            this._filterButton = new System.Windows.Forms.Button();
            this._addButton = new System.Windows.Forms.Button();
            this._toolStrip.SuspendLayout();
            this._groupBoxCalculation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._dataGridViewSpace)).BeginInit();
            this._groupBoxEdit.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip
            // 
            this._toolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this._toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._toolStripDropDownButton});
            this._toolStrip.Location = new System.Drawing.Point(0, 0);
            this._toolStrip.Name = "toolStrip";
            this._toolStrip.Size = new System.Drawing.Size(575, 27);
            this._toolStrip.TabIndex = 0;
            this._toolStrip.Text = "toolStrip";
            // 
            // toolStripDropDownButton
            // 
            this._toolStripDropDownButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this._toolStripDropDownButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._saveToolStripMenuItem,
            this._openToolStripMenuItem});
            this._toolStripDropDownButton.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton.Image")));
            this._toolStripDropDownButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._toolStripDropDownButton.Name = "toolStripDropDownButton";
            this._toolStripDropDownButton.Size = new System.Drawing.Size(59, 24);
            this._toolStripDropDownButton.Text = "Файл";
            // 
            // saveToolStripMenuItem
            // 
            this._saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this._saveToolStripMenuItem.Size = new System.Drawing.Size(166, 26);
            this._saveToolStripMenuItem.Text = "Сохранить";
            this._saveToolStripMenuItem.Click += new System.EventHandler(this.SaveToolStripMenuItem);
            // 
            // openToolStripMenuItem
            // 
            this._openToolStripMenuItem.Name = "openToolStripMenuItem";
            this._openToolStripMenuItem.Size = new System.Drawing.Size(166, 26);
            this._openToolStripMenuItem.Text = "Загрузить";
            this._openToolStripMenuItem.Click += new System.EventHandler(this.OpenToolStripMenuItem);
            // 
            // randomButton
            // 
            this._randomButton.Location = new System.Drawing.Point(446, 8);
            this._randomButton.Name = "randomButton";
            this._randomButton.Size = new System.Drawing.Size(117, 25);
            this._randomButton.TabIndex = 1;
            this._randomButton.Text = "Рандомайзер";
            this._randomButton.UseVisualStyleBackColor = true;
            this._randomButton.Click += new System.EventHandler(this.RandomButton);
            // 
            // groupBoxCalculation
            // 
            this._groupBoxCalculation.Controls.Add(this._dataGridViewSpace);
            this._groupBoxCalculation.Location = new System.Drawing.Point(12, 34);
            this._groupBoxCalculation.Name = "groupBoxCalculation";
            this._groupBoxCalculation.Size = new System.Drawing.Size(551, 255);
            this._groupBoxCalculation.TabIndex = 2;
            this._groupBoxCalculation.TabStop = false;
            this._groupBoxCalculation.Text = "Расчет объема";
            // 
            // dataGridViewSpace
            // 
            this._dataGridViewSpace.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._dataGridViewSpace.Location = new System.Drawing.Point(6, 21);
            this._dataGridViewSpace.Name = "dataGridViewSpace";
            this._dataGridViewSpace.RowHeadersWidth = 51;
            this._dataGridViewSpace.RowTemplate.Height = 24;
            this._dataGridViewSpace.Size = new System.Drawing.Size(539, 228);
            this._dataGridViewSpace.TabIndex = 0;
            // 
            // groupBoxEdit
            // 
            this._groupBoxEdit.Controls.Add(this._clearButton);
            this._groupBoxEdit.Controls.Add(this._deleteButton);
            this._groupBoxEdit.Controls.Add(this._resetFilterButton);
            this._groupBoxEdit.Controls.Add(this._filterButton);
            this._groupBoxEdit.Controls.Add(this._addButton);
            this._groupBoxEdit.Location = new System.Drawing.Point(12, 295);
            this._groupBoxEdit.Name = "groupBoxEdit";
            this._groupBoxEdit.Size = new System.Drawing.Size(551, 71);
            this._groupBoxEdit.TabIndex = 3;
            this._groupBoxEdit.TabStop = false;
            this._groupBoxEdit.Text = "Редактирование списка";
            // 
            // clearButton
            // 
            this._clearButton.Location = new System.Drawing.Point(468, 21);
            this._clearButton.Name = "clearButton";
            this._clearButton.Size = new System.Drawing.Size(77, 41);
            this._clearButton.TabIndex = 6;
            this._clearButton.Text = "Очистить";
            this._clearButton.UseVisualStyleBackColor = true;
            this._clearButton.Click += new System.EventHandler(this.ClearButton);
            // 
            // deleteButton
            // 
            this._deleteButton.Location = new System.Drawing.Point(385, 21);
            this._deleteButton.Name = "deleteButton";
            this._deleteButton.Size = new System.Drawing.Size(77, 41);
            this._deleteButton.TabIndex = 5;
            this._deleteButton.Text = "Удалить";
            this._deleteButton.UseVisualStyleBackColor = true;
            this._deleteButton.Click += new System.EventHandler(this.DeleteButton);
            // 
            // resetFilterButton
            // 
            this._resetFilterButton.Location = new System.Drawing.Point(179, 21);
            this._resetFilterButton.Name = "resetFilterButton";
            this._resetFilterButton.Size = new System.Drawing.Size(86, 41);
            this._resetFilterButton.TabIndex = 4;
            this._resetFilterButton.Text = "Сбросить фильтр";
            this._resetFilterButton.UseVisualStyleBackColor = true;
            this._resetFilterButton.Click += new System.EventHandler(this.ResetFilterButton);
            // 
            // filterButton
            // 
            this._filterButton.Location = new System.Drawing.Point(106, 21);
            this._filterButton.Name = "filterButton";
            this._filterButton.Size = new System.Drawing.Size(67, 41);
            this._filterButton.TabIndex = 3;
            this._filterButton.Text = "Фильтр";
            this._filterButton.UseVisualStyleBackColor = true;
            this._filterButton.Click += new System.EventHandler(this.FilterButton);
            // 
            // addButton
            // 
            this._addButton.Location = new System.Drawing.Point(6, 21);
            this._addButton.Name = "addButton";
            this._addButton.Size = new System.Drawing.Size(94, 41);
            this._addButton.TabIndex = 2;
            this._addButton.Text = "Добавить фигуру";
            this._addButton.UseVisualStyleBackColor = true;
            this._addButton.Click += new System.EventHandler(this.AddButton);
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(575, 375);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this._groupBoxEdit);
            this.Controls.Add(this._groupBoxCalculation);
            this.Controls.Add(this._randomButton);
            this.Controls.Add(this._toolStrip);
            this.Name = "MainForm";
            this.Load += new System.EventHandler(this.LoadMainForm);
            this._toolStrip.ResumeLayout(false);
            this._toolStrip.PerformLayout();
            this._groupBoxCalculation.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._dataGridViewSpace)).EndInit();
            this._groupBoxEdit.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
      
        private System.Windows.Forms.Button _randomButton;
        private System.Windows.Forms.GroupBox _groupBoxCalculation;
        private System.Windows.Forms.GroupBox _groupBoxEdit;
        private System.Windows.Forms.Button _filterButton;
        private System.Windows.Forms.Button _addButton;
        private System.Windows.Forms.Button _clearButton;
        private System.Windows.Forms.Button _deleteButton;
        private System.Windows.Forms.Button _resetFilterButton;
        private System.Windows.Forms.DataGridView _dataGridViewSpace;
        private System.Windows.Forms.ToolStrip _toolStrip;
        private System.Windows.Forms.ToolStripDropDownButton _toolStripDropDownButton;
        private System.Windows.Forms.ToolStripMenuItem _saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem _openToolStripMenuItem;
    }
}

