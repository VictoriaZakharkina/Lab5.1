namespace View
{
    partial class UserControlPyramid
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxLength = new System.Windows.Forms.TextBox();
            this.labelAreaOfBase = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelHeight = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxLength
            // 
            this.textBoxLength.Location = new System.Drawing.Point(253, 14);
            this.textBoxLength.Name = "textBoxLength";
            this.textBoxLength.Size = new System.Drawing.Size(100, 22);
            this.textBoxLength.TabIndex = 7;
            // 
            // labelAreaOfBase
            // 
            this.labelAreaOfBase.AutoSize = true;
            this.labelAreaOfBase.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAreaOfBase.Location = new System.Drawing.Point(14, 15);
            this.labelAreaOfBase.Name = "labelAreaOfBase";
            this.labelAreaOfBase.Size = new System.Drawing.Size(151, 18);
            this.labelAreaOfBase.TabIndex = 6;
            this.labelAreaOfBase.Text = "Площадь основания";
            this.labelAreaOfBase.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(253, 42);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 9;
            // 
            // labelHeight
            // 
            this.labelHeight.AutoSize = true;
            this.labelHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelHeight.Location = new System.Drawing.Point(14, 43);
            this.labelHeight.Name = "labelHeight";
            this.labelHeight.Size = new System.Drawing.Size(61, 18);
            this.labelHeight.TabIndex = 8;
            this.labelHeight.Text = "Высота";
            this.labelHeight.Visible = false;
            // 
            // UserControlPyramid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labelHeight);
            this.Controls.Add(this.textBoxLength);
            this.Controls.Add(this.labelAreaOfBase);
            this.Name = "UserControlPyramid";
            this.Size = new System.Drawing.Size(369, 159);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        internal System.Windows.Forms.Label labelAreaOfBase;
        internal System.Windows.Forms.Label labelHeight;
        internal System.Windows.Forms.TextBox textBoxLength;
        internal System.Windows.Forms.TextBox textBox1;
    }
}
