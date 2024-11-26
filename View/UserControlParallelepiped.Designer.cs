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
            this.labelLength = new System.Windows.Forms.Label();
            this.labelWidth = new System.Windows.Forms.Label();
            this.labelHeight = new System.Windows.Forms.Label();
            this.labelAngleLengthWidth = new System.Windows.Forms.Label();
            this.labelAngleBaseHeight = new System.Windows.Forms.Label();
            this.textBoxLength = new System.Windows.Forms.TextBox();
            this.textBoxWidth = new System.Windows.Forms.TextBox();
            this.textBoxHeight = new System.Windows.Forms.TextBox();
            this.textBoxAngleLengthWidth = new System.Windows.Forms.TextBox();
            this.textBoxAngleBaseHeight = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelLength
            // 
            this.labelLength.AutoSize = true;
            this.labelLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLength.Location = new System.Drawing.Point(12, 14);
            this.labelLength.Name = "labelLength";
            this.labelLength.Size = new System.Drawing.Size(53, 18);
            this.labelLength.TabIndex = 0;
            this.labelLength.Text = "Длина";
            this.labelLength.Click += new System.EventHandler(this.labelLength_Click);
            // 
            // labelWidth
            // 
            this.labelWidth.AutoSize = true;
            this.labelWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelWidth.Location = new System.Drawing.Point(12, 42);
            this.labelWidth.Name = "labelWidth";
            this.labelWidth.Size = new System.Drawing.Size(61, 18);
            this.labelWidth.TabIndex = 1;
            this.labelWidth.Text = "Ширина";
            // 
            // labelHeight
            // 
            this.labelHeight.AutoSize = true;
            this.labelHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelHeight.Location = new System.Drawing.Point(12, 70);
            this.labelHeight.Name = "labelHeight";
            this.labelHeight.Size = new System.Drawing.Size(61, 18);
            this.labelHeight.TabIndex = 2;
            this.labelHeight.Text = "Высота";
            // 
            // labelAngleLengthWidth
            // 
            this.labelAngleLengthWidth.AutoSize = true;
            this.labelAngleLengthWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAngleLengthWidth.Location = new System.Drawing.Point(12, 98);
            this.labelAngleLengthWidth.Name = "labelAngleLengthWidth";
            this.labelAngleLengthWidth.Size = new System.Drawing.Size(199, 18);
            this.labelAngleLengthWidth.TabIndex = 3;
            this.labelAngleLengthWidth.Text = "Угол м/у длиной и шириной";
            // 
            // labelAngleBaseHeight
            // 
            this.labelAngleBaseHeight.AutoSize = true;
            this.labelAngleBaseHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAngleBaseHeight.Location = new System.Drawing.Point(12, 126);
            this.labelAngleBaseHeight.Name = "labelAngleBaseHeight";
            this.labelAngleBaseHeight.Size = new System.Drawing.Size(233, 18);
            this.labelAngleBaseHeight.TabIndex = 4;
            this.labelAngleBaseHeight.Text = "Угол м/у основанием и высотой";
            // 
            // textBoxLength
            // 
            this.textBoxLength.Location = new System.Drawing.Point(251, 13);
            this.textBoxLength.Name = "textBoxLength";
            this.textBoxLength.Size = new System.Drawing.Size(100, 22);
            this.textBoxLength.TabIndex = 5;
            // 
            // textBoxWidth
            // 
            this.textBoxWidth.Location = new System.Drawing.Point(251, 41);
            this.textBoxWidth.Name = "textBoxWidth";
            this.textBoxWidth.Size = new System.Drawing.Size(100, 22);
            this.textBoxWidth.TabIndex = 6;
            // 
            // textBoxHeight
            // 
            this.textBoxHeight.Location = new System.Drawing.Point(251, 69);
            this.textBoxHeight.Name = "textBoxHeight";
            this.textBoxHeight.Size = new System.Drawing.Size(100, 22);
            this.textBoxHeight.TabIndex = 7;
            // 
            // textBoxAngleLengthWidth
            // 
            this.textBoxAngleLengthWidth.Location = new System.Drawing.Point(251, 97);
            this.textBoxAngleLengthWidth.Name = "textBoxAngleLengthWidth";
            this.textBoxAngleLengthWidth.Size = new System.Drawing.Size(100, 22);
            this.textBoxAngleLengthWidth.TabIndex = 8;
            // 
            // textBoxAngleBaseHeight
            // 
            this.textBoxAngleBaseHeight.Location = new System.Drawing.Point(251, 126);
            this.textBoxAngleBaseHeight.Name = "textBoxAngleBaseHeight";
            this.textBoxAngleBaseHeight.Size = new System.Drawing.Size(100, 22);
            this.textBoxAngleBaseHeight.TabIndex = 9;
            // 
            // UserControlParallelepiped
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBoxAngleBaseHeight);
            this.Controls.Add(this.textBoxAngleLengthWidth);
            this.Controls.Add(this.textBoxHeight);
            this.Controls.Add(this.textBoxWidth);
            this.Controls.Add(this.textBoxLength);
            this.Controls.Add(this.labelAngleBaseHeight);
            this.Controls.Add(this.labelAngleLengthWidth);
            this.Controls.Add(this.labelHeight);
            this.Controls.Add(this.labelWidth);
            this.Controls.Add(this.labelLength);
            this.Name = "UserControlParallelepiped";
            this.Size = new System.Drawing.Size(369, 159);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label labelLength;
        internal System.Windows.Forms.Label labelWidth;
        internal System.Windows.Forms.Label labelHeight;
        internal System.Windows.Forms.Label labelAngleLengthWidth;
        internal System.Windows.Forms.Label labelAngleBaseHeight;
        internal System.Windows.Forms.TextBox textBoxLength;
        internal System.Windows.Forms.TextBox textBoxWidth;
        internal System.Windows.Forms.TextBox textBoxHeight;
        internal System.Windows.Forms.TextBox textBoxAngleLengthWidth;
        internal System.Windows.Forms.TextBox textBoxAngleBaseHeight;
    }
}
