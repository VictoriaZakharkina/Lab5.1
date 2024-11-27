namespace View
{
    partial class UserControlSphere
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
            this._textBoxRadius = new System.Windows.Forms.TextBox();
            this._labelRadius = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // _textBoxRadius
            // 
            this._textBoxRadius.Location = new System.Drawing.Point(254, 15);
            this._textBoxRadius.Name = "_textBoxRadius";
            this._textBoxRadius.Size = new System.Drawing.Size(100, 22);
            this._textBoxRadius.TabIndex = 7;
            // 
            // _labelRadius
            // 
            this._labelRadius.AutoSize = true;
            this._labelRadius.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._labelRadius.Location = new System.Drawing.Point(15, 16);
            this._labelRadius.Name = "_labelRadius";
            this._labelRadius.Size = new System.Drawing.Size(58, 18);
            this._labelRadius.TabIndex = 6;
            this._labelRadius.Text = "Радиус";
            // 
            // UserControlSphere
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this._textBoxRadius);
            this.Controls.Add(this._labelRadius);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "UserControlSphere";
            this.Size = new System.Drawing.Size(369, 159);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        
        internal System.Windows.Forms.Label _labelRadius;
        internal System.Windows.Forms.TextBox _textBoxRadius;
    }
}
