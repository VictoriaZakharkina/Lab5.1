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
            this._textBoxAreaOfBase = new System.Windows.Forms.TextBox();
            this._textBoxAreaOfBase = new TextBoxExam();
            this._labelAreaOfBase = new System.Windows.Forms.Label();
            this._textBoxHeight = new System.Windows.Forms.TextBox();
            this._textBoxHeight = new TextBoxExam();
            this._labelHeight = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // _textBoxAreaOfBase
            // 
            this._textBoxAreaOfBase.Location = new System.Drawing.Point(321, 13);
            this._textBoxAreaOfBase.Name = "_textBoxAreaOfBase";
            this._textBoxAreaOfBase.Size = new System.Drawing.Size(100, 22);
            this._textBoxAreaOfBase.TabIndex = 7;
            // 
            // _labelAreaOfBase
            // 
            this._labelAreaOfBase.AutoSize = true;
            this._labelAreaOfBase.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._labelAreaOfBase.Location = new System.Drawing.Point(14, 14);
            this._labelAreaOfBase.Name = "_labelAreaOfBase";
            this._labelAreaOfBase.Size = new System.Drawing.Size(151, 18);
            this._labelAreaOfBase.TabIndex = 6;
            this._labelAreaOfBase.Text = "Площадь основания";
            // 
            // _textBoxHeight
            // 
            this._textBoxHeight.Location = new System.Drawing.Point(321, 41);
            this._textBoxHeight.Name = "_textBoxHeight";
            this._textBoxHeight.Size = new System.Drawing.Size(100, 22);
            this._textBoxHeight.TabIndex = 9;
            // 
            // _labelHeight
            // 
            this._labelHeight.AutoSize = true;
            this._labelHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._labelHeight.Location = new System.Drawing.Point(14, 42);
            this._labelHeight.Name = "_labelHeight";
            this._labelHeight.Size = new System.Drawing.Size(61, 18);
            this._labelHeight.TabIndex = 8;
            this._labelHeight.Text = "Высота";
            // 
            // UserControlPyramid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this._textBoxHeight);
            this.Controls.Add(this._labelHeight);
            this.Controls.Add(this._textBoxAreaOfBase);
            this.Controls.Add(this._labelAreaOfBase);
            this.Name = "UserControlPyramid";
            this.Size = new System.Drawing.Size(438, 159);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        
        internal System.Windows.Forms.Label _labelAreaOfBase;
        internal System.Windows.Forms.Label _labelHeight;
        internal System.Windows.Forms.TextBox _textBoxAreaOfBase;
        internal System.Windows.Forms.TextBox _textBoxHeight;
    }
}
