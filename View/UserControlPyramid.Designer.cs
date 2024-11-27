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
            this._textBoxLength = new System.Windows.Forms.TextBox();
            this._labelAreaOfBase = new System.Windows.Forms.Label();
            this._textBox1 = new System.Windows.Forms.TextBox();
            this._labelHeight = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxLength
            // 
            this._textBoxLength.Location = new System.Drawing.Point(253, 14);
            this._textBoxLength.Name = "textBoxLength";
            this._textBoxLength.Size = new System.Drawing.Size(100, 22);
            this._textBoxLength.TabIndex = 7;
            // 
            // labelAreaOfBase
            // 
            this._labelAreaOfBase.AutoSize = true;
            this._labelAreaOfBase.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._labelAreaOfBase.Location = new System.Drawing.Point(14, 15);
            this._labelAreaOfBase.Name = "labelAreaOfBase";
            this._labelAreaOfBase.Size = new System.Drawing.Size(151, 18);
            this._labelAreaOfBase.TabIndex = 6;
            this._labelAreaOfBase.Text = "Площадь основания";
            // 
            // textBox1
            // 
            this._textBox1.Location = new System.Drawing.Point(253, 42);
            this._textBox1.Name = "textBox1";
            this._textBox1.Size = new System.Drawing.Size(100, 22);
            this._textBox1.TabIndex = 9;
            // 
            // labelHeight
            // 
            this._labelHeight.AutoSize = true;
            this._labelHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._labelHeight.Location = new System.Drawing.Point(14, 43);
            this._labelHeight.Name = "labelHeight";
            this._labelHeight.Size = new System.Drawing.Size(61, 18);
            this._labelHeight.TabIndex = 8;
            this._labelHeight.Text = "Высота";
            // 
            // UserControlPyramid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this._textBox1);
            this.Controls.Add(this._labelHeight);
            this.Controls.Add(this._textBoxLength);
            this.Controls.Add(this._labelAreaOfBase);
            this.Name = "UserControlPyramid";
            this.Size = new System.Drawing.Size(369, 159);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        internal System.Windows.Forms.Label _labelAreaOfBase;
        internal System.Windows.Forms.Label _labelHeight;
        internal System.Windows.Forms.TextBox _textBoxLength;
        internal System.Windows.Forms.TextBox _textBox1;
    }
}
