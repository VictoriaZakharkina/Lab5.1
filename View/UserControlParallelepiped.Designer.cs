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
            this._textBoxLength = new System.Windows.Forms.TextBox();
            this._textBoxWidth = new System.Windows.Forms.TextBox();
            this._textBoxHeight = new System.Windows.Forms.TextBox();
            this._textBoxAngleLengthWidth = new System.Windows.Forms.TextBox();
            this._textBoxAngleBaseHeight = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelLength
            // 
            this._labelLength.AutoSize = true;
            this._labelLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._labelLength.Location = new System.Drawing.Point(12, 14);
            this._labelLength.Name = "labelLength";
            this._labelLength.Size = new System.Drawing.Size(53, 18);
            this._labelLength.TabIndex = 0;
            this._labelLength.Text = "Длина";
            this._labelLength.Click += new System.EventHandler(this.labelLength_Click);
            // 
            // labelWidth
            // 
            this._labelWidth.AutoSize = true;
            this._labelWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._labelWidth.Location = new System.Drawing.Point(12, 42);
            this._labelWidth.Name = "labelWidth";
            this._labelWidth.Size = new System.Drawing.Size(61, 18);
            this._labelWidth.TabIndex = 1;
            this._labelWidth.Text = "Ширина";
            // 
            // labelHeight
            // 
            this._labelHeight.AutoSize = true;
            this._labelHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._labelHeight.Location = new System.Drawing.Point(12, 70);
            this._labelHeight.Name = "labelHeight";
            this._labelHeight.Size = new System.Drawing.Size(61, 18);
            this._labelHeight.TabIndex = 2;
            this._labelHeight.Text = "Высота";
            // 
            // labelAngleLengthWidth
            // 
            this._labelAngleLengthWidth.AutoSize = true;
            this._labelAngleLengthWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._labelAngleLengthWidth.Location = new System.Drawing.Point(12, 98);
            this._labelAngleLengthWidth.Name = "labelAngleLengthWidth";
            this._labelAngleLengthWidth.Size = new System.Drawing.Size(199, 18);
            this._labelAngleLengthWidth.TabIndex = 3;
            this._labelAngleLengthWidth.Text = "Угол м/у длиной и шириной";
            // 
            // labelAngleBaseHeight
            // 
            this._labelAngleBaseHeight.AutoSize = true;
            this._labelAngleBaseHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._labelAngleBaseHeight.Location = new System.Drawing.Point(12, 126);
            this._labelAngleBaseHeight.Name = "labelAngleBaseHeight";
            this._labelAngleBaseHeight.Size = new System.Drawing.Size(233, 18);
            this._labelAngleBaseHeight.TabIndex = 4;
            this._labelAngleBaseHeight.Text = "Угол м/у основанием и высотой";
            // 
            // textBoxLength
            // 
            this._textBoxLength.Location = new System.Drawing.Point(251, 13);
            this._textBoxLength.Name = "textBoxLength";
            this._textBoxLength.Size = new System.Drawing.Size(100, 22);
            this._textBoxLength.TabIndex = 5;
            // 
            // textBoxWidth
            // 
            this._textBoxWidth.Location = new System.Drawing.Point(251, 41);
            this._textBoxWidth.Name = "textBoxWidth";
            this._textBoxWidth.Size = new System.Drawing.Size(100, 22);
            this._textBoxWidth.TabIndex = 6;
            // 
            // textBoxHeight
            // 
            this._textBoxHeight.Location = new System.Drawing.Point(251, 69);
            this._textBoxHeight.Name = "textBoxHeight";
            this._textBoxHeight.Size = new System.Drawing.Size(100, 22);
            this._textBoxHeight.TabIndex = 7;
            // 
            // textBoxAngleLengthWidth
            // 
            this._textBoxAngleLengthWidth.Location = new System.Drawing.Point(251, 97);
            this._textBoxAngleLengthWidth.Name = "textBoxAngleLengthWidth";
            this._textBoxAngleLengthWidth.Size = new System.Drawing.Size(100, 22);
            this._textBoxAngleLengthWidth.TabIndex = 8;
            // 
            // textBoxAngleBaseHeight
            // 
            this._textBoxAngleBaseHeight.Location = new System.Drawing.Point(251, 126);
            this._textBoxAngleBaseHeight.Name = "textBoxAngleBaseHeight";
            this._textBoxAngleBaseHeight.Size = new System.Drawing.Size(100, 22);
            this._textBoxAngleBaseHeight.TabIndex = 9;
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
            this.Size = new System.Drawing.Size(369, 159);
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
