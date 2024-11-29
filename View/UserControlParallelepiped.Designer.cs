namespace View
{
    partial class UserControlParallelepiped
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
            this._labelLength = new System.Windows.Forms.Label();
            this._labelWidth = new System.Windows.Forms.Label();
            this._labelHeight = new System.Windows.Forms.Label();
            this._labelAngleLengthWidth = new System.Windows.Forms.Label();
            this._labelAngleBaseHeight = new System.Windows.Forms.Label();
            this._textBoxLength = new TextBoxExam();
            this._textBoxWidth = new TextBoxExam();
            this._textBoxHeight = new TextBoxExam();
            this._textBoxAngleLengthWidth = new TextBoxExam();
            this._textBoxAngleBaseHeight = new TextBoxExam();
            this.SuspendLayout();
            // 
            // _labelLength
            // 
            this._labelLength.AutoSize = true;
            this._labelLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._labelLength.Location = new System.Drawing.Point(14, 14);
            this._labelLength.Name = "_labelLength";
            this._labelLength.Size = new System.Drawing.Size(53, 18);
            this._labelLength.TabIndex = 0;
            this._labelLength.Text = "Длина";
            // 
            // _labelWidth
            // 
            this._labelWidth.AutoSize = true;
            this._labelWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._labelWidth.Location = new System.Drawing.Point(14, 42);
            this._labelWidth.Name = "_labelWidth";
            this._labelWidth.Size = new System.Drawing.Size(61, 18);
            this._labelWidth.TabIndex = 1;
            this._labelWidth.Text = "Ширина";
            // 
            // _labelHeight
            // 
            this._labelHeight.AutoSize = true;
            this._labelHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._labelHeight.Location = new System.Drawing.Point(14, 70);
            this._labelHeight.Name = "_labelHeight";
            this._labelHeight.Size = new System.Drawing.Size(61, 18);
            this._labelHeight.TabIndex = 2;
            this._labelHeight.Text = "Высота";
            // 
            // _labelAngleLengthWidth
            // 
            this._labelAngleLengthWidth.AutoSize = true;
            this._labelAngleLengthWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._labelAngleLengthWidth.Location = new System.Drawing.Point(14, 98);
            this._labelAngleLengthWidth.Name = "_labelAngleLengthWidth";
            this._labelAngleLengthWidth.Size = new System.Drawing.Size(199, 18);
            this._labelAngleLengthWidth.TabIndex = 3;
            this._labelAngleLengthWidth.Text = "Угол м/у длиной и шириной";
            // 
            // _labelAngleBaseHeight
            // 
            this._labelAngleBaseHeight.AutoSize = true;
            this._labelAngleBaseHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._labelAngleBaseHeight.Location = new System.Drawing.Point(14, 126);
            this._labelAngleBaseHeight.Name = "_labelAngleBaseHeight";
            this._labelAngleBaseHeight.Size = new System.Drawing.Size(233, 18);
            this._labelAngleBaseHeight.TabIndex = 4;
            this._labelAngleBaseHeight.Text = "Угол м/у основанием и высотой";
            // 
            // _textBoxLength
            // 
            this._textBoxLength.Location = new System.Drawing.Point(321, 13);
            this._textBoxLength.Name = "_textBoxLength";
            this._textBoxLength.Size = new System.Drawing.Size(100, 22);
            this._textBoxLength.TabIndex = 5;
            this._textBoxLength.MaxLength = 5;
            // 
            // _textBoxWidth
            // 
            this._textBoxWidth.Location = new System.Drawing.Point(321, 41);
            this._textBoxWidth.Name = "_textBoxWidth";
            this._textBoxWidth.Size = new System.Drawing.Size(100, 22);
            this._textBoxWidth.TabIndex = 6;
            this._textBoxWidth.MaxLength = 5;
            // 
            // _textBoxHeight
            // 
            this._textBoxHeight.Location = new System.Drawing.Point(321, 69);
            this._textBoxHeight.Name = "_textBoxHeight";
            this._textBoxHeight.Size = new System.Drawing.Size(100, 22);
            this._textBoxHeight.TabIndex = 7;
            this._textBoxHeight.MaxLength = 5;
            // 
            // _textBoxAngleLengthWidth
            // 
            this._textBoxAngleLengthWidth.Location = new System.Drawing.Point(321, 97);
            this._textBoxAngleLengthWidth.Name = "_textBoxAngleLengthWidth";
            this._textBoxAngleLengthWidth.Size = new System.Drawing.Size(100, 22);
            this._textBoxAngleLengthWidth.TabIndex = 8;
            this._textBoxAngleLengthWidth.MaxLength = 5;
            // 
            // _textBoxAngleBaseHeight
            // 
            this._textBoxAngleBaseHeight.Location = new System.Drawing.Point(321, 126);
            this._textBoxAngleBaseHeight.Name = "_textBoxAngleBaseHeight";
            this._textBoxAngleBaseHeight.Size = new System.Drawing.Size(100, 22);
            this._textBoxAngleBaseHeight.TabIndex = 9;
            this._textBoxAngleBaseHeight.MaxLength = 5;
            // 
            // UserControlParallelepiped
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this._textBoxAngleBaseHeight);
            this.Controls.Add(this._textBoxAngleLengthWidth);
            this.Controls.Add(this._textBoxHeight);
            this.Controls.Add(this._textBoxWidth);
            this.Controls.Add(this._textBoxLength);
            this.Controls.Add(this._labelAngleBaseHeight);
            this.Controls.Add(this._labelAngleLengthWidth);
            this.Controls.Add(this._labelHeight);
            this.Controls.Add(this._labelWidth);
            this.Controls.Add(this._labelLength);
            this.Name = "UserControlParallelepiped";
            this.Size = new System.Drawing.Size(438, 159);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label _labelLength;
        internal System.Windows.Forms.Label _labelWidth;
        internal System.Windows.Forms.Label _labelHeight;
        internal System.Windows.Forms.Label _labelAngleLengthWidth;
        internal System.Windows.Forms.Label _labelAngleBaseHeight;
        internal System.Windows.Forms.TextBox _textBoxLength;
        internal System.Windows.Forms.TextBox _textBoxWidth;
        internal System.Windows.Forms.TextBox _textBoxHeight;
        internal System.Windows.Forms.TextBox _textBoxAngleLengthWidth;
        internal System.Windows.Forms.TextBox _textBoxAngleBaseHeight;
    }
}
