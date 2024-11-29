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
#if DEBUG
            this._randomButton = new System.Windows.Forms.Button();
#endif
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
            // _toolStrip
            // 
            this._toolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this._toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._toolStripDropDownButton});
            this._toolStrip.Location = new System.Drawing.Point(0, 0);
            this._toolStrip.Name = "_toolStrip";
            this._toolStrip.Size = new System.Drawing.Size(760, 27);
            this._toolStrip.TabIndex = 0;
            this._toolStrip.Text = "toolStrip";
            // 
            // _toolStripDropDownButton
            // 
            this._toolStripDropDownButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this._toolStripDropDownButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._saveToolStripMenuItem,
            this._openToolStripMenuItem});
            this._toolStripDropDownButton.Image = ((System.Drawing.Image)(resources.GetObject("_toolStripDropDownButton.Image")));
            this._toolStripDropDownButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._toolStripDropDownButton.Name = "_toolStripDropDownButton";
            this._toolStripDropDownButton.Size = new System.Drawing.Size(59, 24);
            this._toolStripDropDownButton.Text = "Файл";
            // 
            // _saveToolStripMenuItem
            // 
            this._saveToolStripMenuItem.Name = "_saveToolStripMenuItem";
            this._saveToolStripMenuItem.Size = new System.Drawing.Size(166, 26);
            this._saveToolStripMenuItem.Text = "Сохранить";
            this._saveToolStripMenuItem.Click += new System.EventHandler(this.SaveToolStripMenuItem);
            // 
            // _openToolStripMenuItem
            // 
            this._openToolStripMenuItem.Name = "_openToolStripMenuItem";
            this._openToolStripMenuItem.Size = new System.Drawing.Size(166, 26);
            this._openToolStripMenuItem.Text = "Загрузить";
            this._openToolStripMenuItem.Click += new System.EventHandler(this.OpenToolStripMenuItem);
#if DEBUG
            // 
            // _randomButton
            // 
            this._randomButton.Location = new System.Drawing.Point(602, 5);
            this._randomButton.Name = "_randomButton";
            this._randomButton.Size = new System.Drawing.Size(140, 30);
            this._randomButton.TabIndex = 1;
            this._randomButton.Text = "Рандомайзер";
            this._randomButton.UseVisualStyleBackColor = true;
            this._randomButton.Click += new System.EventHandler(this.RandomButton);
#endif
            // 
            // _groupBoxCalculation
            // 
            this._groupBoxCalculation.Controls.Add(this._dataGridViewSpace);
            this._groupBoxCalculation.Location = new System.Drawing.Point(12, 35);
            this._groupBoxCalculation.Name = "_groupBoxCalculation";
            this._groupBoxCalculation.Size = new System.Drawing.Size(736, 314);
            this._groupBoxCalculation.TabIndex = 2;
            this._groupBoxCalculation.TabStop = false;
            this._groupBoxCalculation.Text = "Расчет объема";
            // 
            // _dataGridViewSpace
            // 
            this._dataGridViewSpace.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._dataGridViewSpace.Location = new System.Drawing.Point(6, 21);
            this._dataGridViewSpace.Name = "_dataGridViewSpace";
            this._dataGridViewSpace.RowHeadersWidth = 51;
            this._dataGridViewSpace.RowTemplate.Height = 24;
            this._dataGridViewSpace.Size = new System.Drawing.Size(724, 287);
            this._dataGridViewSpace.TabIndex = 0;
            // 
            // _groupBoxEdit
            // 
            this._groupBoxEdit.Controls.Add(this._clearButton);
            this._groupBoxEdit.Controls.Add(this._deleteButton);
            this._groupBoxEdit.Controls.Add(this._resetFilterButton);
            this._groupBoxEdit.Controls.Add(this._filterButton);
            this._groupBoxEdit.Controls.Add(this._addButton);
            this._groupBoxEdit.Location = new System.Drawing.Point(12, 355);
            this._groupBoxEdit.Name = "_groupBoxEdit";
            this._groupBoxEdit.Size = new System.Drawing.Size(736, 60);
            this._groupBoxEdit.TabIndex = 3;
            this._groupBoxEdit.TabStop = false;
            this._groupBoxEdit.Text = "Редактирование списка";
            // 
            // _clearButton
            // 
            this._clearButton.Location = new System.Drawing.Point(590, 21);
            this._clearButton.Name = "_clearButton";
            this._clearButton.Size = new System.Drawing.Size(140, 30);
            this._clearButton.TabIndex = 6;
            this._clearButton.Text = "Очистить";
            this._clearButton.UseVisualStyleBackColor = true;
            this._clearButton.Click += new System.EventHandler(this.ClearButton);
            // 
            // _deleteButton
            // 
            this._deleteButton.Location = new System.Drawing.Point(444, 21);
            this._deleteButton.Name = "_deleteButton";
            this._deleteButton.Size = new System.Drawing.Size(140, 30);
            this._deleteButton.TabIndex = 5;
            this._deleteButton.Text = "Удалить";
            this._deleteButton.UseVisualStyleBackColor = true;
            this._deleteButton.Click += new System.EventHandler(this.DeleteButton);
            // 
            // _resetFilterButton
            // 
            this._resetFilterButton.Location = new System.Drawing.Point(298, 21);
            this._resetFilterButton.Name = "_resetFilterButton";
            this._resetFilterButton.Size = new System.Drawing.Size(140, 30);
            this._resetFilterButton.TabIndex = 4;
            this._resetFilterButton.Text = "Сбросить фильтр";
            this._resetFilterButton.UseVisualStyleBackColor = true;
            this._resetFilterButton.Click += new System.EventHandler(this.ResetFilterButton);
            // 
            // _filterButton
            // 
            this._filterButton.Location = new System.Drawing.Point(152, 21);
            this._filterButton.Name = "_filterButton";
            this._filterButton.Size = new System.Drawing.Size(140, 30);
            this._filterButton.TabIndex = 3;
            this._filterButton.Text = "Фильтр";
            this._filterButton.UseVisualStyleBackColor = true;
            this._filterButton.Click += new System.EventHandler(this.FilterButton);
            // 
            // _addButton
            // 
            this._addButton.Location = new System.Drawing.Point(6, 21);
            this._addButton.Name = "_addButton";
            this._addButton.Size = new System.Drawing.Size(140, 30);
            this._addButton.TabIndex = 2;
            this._addButton.Text = "Добавить фигуру";
            this._addButton.UseVisualStyleBackColor = true;
            this._addButton.Click += new System.EventHandler(this.AddButton);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 425);
            this.Controls.Add(this._groupBoxEdit);
            this.Controls.Add(this._groupBoxCalculation);
#if DEBUG
            this.Controls.Add(this._randomButton);
#endif
            this.Controls.Add(this._toolStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Программа";
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
#if DEBUG
        private System.Windows.Forms.Button _randomButton;
#endif
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

