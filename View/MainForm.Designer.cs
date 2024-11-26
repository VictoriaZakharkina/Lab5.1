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
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.randomButton = new System.Windows.Forms.Button();
            this.groupBoxCalculation = new System.Windows.Forms.GroupBox();
            this.dataGridViewSpace = new System.Windows.Forms.DataGridView();
            this.groupBoxEdit = new System.Windows.Forms.GroupBox();
            this.clearButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.resetFilterButton = new System.Windows.Forms.Button();
            this.filterButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.toolStrip.SuspendLayout();
            this.groupBoxCalculation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSpace)).BeginInit();
            this.groupBoxEdit.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip
            // 
            this.toolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(575, 27);
            this.toolStrip.TabIndex = 0;
            this.toolStrip.Text = "toolStrip";
            // 
            // toolStripDropDownButton
            // 
            this.toolStripDropDownButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.openToolStripMenuItem});
            this.toolStripDropDownButton.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton.Image")));
            this.toolStripDropDownButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton.Name = "toolStripDropDownButton";
            this.toolStripDropDownButton.Size = new System.Drawing.Size(59, 24);
            this.toolStripDropDownButton.Text = "Файл";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(166, 26);
            this.saveToolStripMenuItem.Text = "Сохранить";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.SaveToolStripMenuItem);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(166, 26);
            this.openToolStripMenuItem.Text = "Загрузить";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.OpenToolStripMenuItem);
            // 
            // randomButton
            // 
            this.randomButton.Location = new System.Drawing.Point(446, 8);
            this.randomButton.Name = "randomButton";
            this.randomButton.Size = new System.Drawing.Size(117, 25);
            this.randomButton.TabIndex = 1;
            this.randomButton.Text = "Рандомайзер";
            this.randomButton.UseVisualStyleBackColor = true;
            this.randomButton.Click += new System.EventHandler(this.RandomButton);
            // 
            // groupBoxCalculation
            // 
            this.groupBoxCalculation.Controls.Add(this.dataGridViewSpace);
            this.groupBoxCalculation.Location = new System.Drawing.Point(12, 34);
            this.groupBoxCalculation.Name = "groupBoxCalculation";
            this.groupBoxCalculation.Size = new System.Drawing.Size(551, 255);
            this.groupBoxCalculation.TabIndex = 2;
            this.groupBoxCalculation.TabStop = false;
            this.groupBoxCalculation.Text = "Расчет объема";
            // 
            // dataGridViewSpace
            // 
            this.dataGridViewSpace.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSpace.Location = new System.Drawing.Point(6, 21);
            this.dataGridViewSpace.Name = "dataGridViewSpace";
            this.dataGridViewSpace.RowHeadersWidth = 51;
            this.dataGridViewSpace.RowTemplate.Height = 24;
            this.dataGridViewSpace.Size = new System.Drawing.Size(539, 228);
            this.dataGridViewSpace.TabIndex = 0;
            // 
            // groupBoxEdit
            // 
            this.groupBoxEdit.Controls.Add(this.clearButton);
            this.groupBoxEdit.Controls.Add(this.deleteButton);
            this.groupBoxEdit.Controls.Add(this.resetFilterButton);
            this.groupBoxEdit.Controls.Add(this.filterButton);
            this.groupBoxEdit.Controls.Add(this.addButton);
            this.groupBoxEdit.Location = new System.Drawing.Point(12, 295);
            this.groupBoxEdit.Name = "groupBoxEdit";
            this.groupBoxEdit.Size = new System.Drawing.Size(551, 71);
            this.groupBoxEdit.TabIndex = 3;
            this.groupBoxEdit.TabStop = false;
            this.groupBoxEdit.Text = "Редактирование списка";
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(468, 21);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(77, 41);
            this.clearButton.TabIndex = 6;
            this.clearButton.Text = "Очистить";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.ClearButton);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(385, 21);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(77, 41);
            this.deleteButton.TabIndex = 5;
            this.deleteButton.Text = "Удалить";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.DeleteButton);
            // 
            // resetFilterButton
            // 
            this.resetFilterButton.Location = new System.Drawing.Point(179, 21);
            this.resetFilterButton.Name = "resetFilterButton";
            this.resetFilterButton.Size = new System.Drawing.Size(86, 41);
            this.resetFilterButton.TabIndex = 4;
            this.resetFilterButton.Text = "Сбросить фильтр";
            this.resetFilterButton.UseVisualStyleBackColor = true;
            this.resetFilterButton.Click += new System.EventHandler(this.ResetFilterButton);
            // 
            // filterButton
            // 
            this.filterButton.Location = new System.Drawing.Point(106, 21);
            this.filterButton.Name = "filterButton";
            this.filterButton.Size = new System.Drawing.Size(67, 41);
            this.filterButton.TabIndex = 3;
            this.filterButton.Text = "Фильтр";
            this.filterButton.UseVisualStyleBackColor = true;
            this.filterButton.Click += new System.EventHandler(this.FilterButton);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(6, 21);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(94, 41);
            this.addButton.TabIndex = 2;
            this.addButton.Text = "Добавить фигуру";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.AddButton);
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(575, 375);
            this.Controls.Add(this.groupBoxEdit);
            this.Controls.Add(this.groupBoxCalculation);
            this.Controls.Add(this.randomButton);
            this.Controls.Add(this.toolStrip);
            this.Name = "MainForm";
            this.Load += new System.EventHandler(this.LoadMainForm);
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.groupBoxCalculation.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSpace)).EndInit();
            this.groupBoxEdit.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
      
        private System.Windows.Forms.Button randomButton;
        private System.Windows.Forms.GroupBox groupBoxCalculation;
        private System.Windows.Forms.GroupBox groupBoxEdit;
        private System.Windows.Forms.Button filterButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button resetFilterButton;
        private System.Windows.Forms.DataGridView dataGridViewSpace;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
    }
}

