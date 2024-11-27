namespace View
{
    partial class FilterForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this._groupBoxFilter = new System.Windows.Forms.GroupBox();
            this._checkBoxSphere = new System.Windows.Forms.CheckBox();
            this._checkBoxParallelepiped = new System.Windows.Forms.CheckBox();
            this._checkBoxPyramid = new System.Windows.Forms.CheckBox();
            this._checkBoxValue = new System.Windows.Forms.CheckBox();
            this._textBoxValue = new System.Windows.Forms.TextBox();
            this._textBoxValue = new TextBoxExam();
            this._groupBoxFilter.SuspendLayout();
            this.SuspendLayout();
            // 
            // _groupBoxFilter
            // 
            this._groupBoxFilter.Controls.Add(this._textBoxValue);
            this._groupBoxFilter.Controls.Add(this._checkBoxValue);
            this._groupBoxFilter.Controls.Add(this._checkBoxPyramid);
            this._groupBoxFilter.Controls.Add(this._checkBoxParallelepiped);
            this._groupBoxFilter.Controls.Add(this._checkBoxSphere);
            this._groupBoxFilter.Location = new System.Drawing.Point(12, 12);
            this._groupBoxFilter.Name = "_groupBoxFilter";
            this._groupBoxFilter.Size = new System.Drawing.Size(280, 155);
            this._groupBoxFilter.TabIndex = 0;
            this._groupBoxFilter.TabStop = false;
            this._groupBoxFilter.Text = "Параметры фильтрации";
            // 
            // _checkBoxSphere
            // 
            this._checkBoxSphere.AutoSize = true;
            this._checkBoxSphere.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._checkBoxSphere.Location = new System.Drawing.Point(8, 27);
            this._checkBoxSphere.Name = "_checkBoxSphere";
            this._checkBoxSphere.Size = new System.Drawing.Size(59, 22);
            this._checkBoxSphere.TabIndex = 0;
            this._checkBoxSphere.Text = "Шар";
            this._checkBoxSphere.UseVisualStyleBackColor = true;
            // 
            // _checkBoxParallelepiped
            // 
            this._checkBoxParallelepiped.AutoSize = true;
            this._checkBoxParallelepiped.Location = new System.Drawing.Point(8, 61);
            this._checkBoxParallelepiped.Name = "_checkBoxParallelepiped";
            this._checkBoxParallelepiped.Size = new System.Drawing.Size(143, 20);
            this._checkBoxParallelepiped.TabIndex = 1;
            this._checkBoxParallelepiped.Text = "Параллелепипед";
            this._checkBoxParallelepiped.UseVisualStyleBackColor = true;
            // 
            // _checkBoxPyramid
            // 
            this._checkBoxPyramid.AutoSize = true;
            this._checkBoxPyramid.Location = new System.Drawing.Point(8, 91);
            this._checkBoxPyramid.Name = "_checkBoxPyramid";
            this._checkBoxPyramid.Size = new System.Drawing.Size(96, 20);
            this._checkBoxPyramid.TabIndex = 2;
            this._checkBoxPyramid.Text = "Пирамида";
            this._checkBoxPyramid.UseVisualStyleBackColor = true;
            // 
            // _checkBoxValue
            // 
            this._checkBoxValue.AutoSize = true;
            this._checkBoxValue.Location = new System.Drawing.Point(8, 121);
            this._checkBoxValue.Name = "_checkBoxValue";
            this._checkBoxValue.Size = new System.Drawing.Size(157, 20);
            this._checkBoxValue.TabIndex = 3;
            this._checkBoxValue.Text = "Задать объем, см^3";
            this._checkBoxValue.UseVisualStyleBackColor = true;
            // 
            // _textBoxValue
            // 
            this._textBoxValue.Location = new System.Drawing.Point(171, 119);
            this._textBoxValue.Name = "_textBoxValue";
            this._textBoxValue.Size = new System.Drawing.Size(100, 22);
            this._textBoxValue.TabIndex = 4;
            // 
            // FilterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 175);
            this.Controls.Add(this._groupBoxFilter);
            this.MaximizeBox = false;
            this.Name = "FilterForm";
            this.Text = "Фильтер";
            this._groupBoxFilter.ResumeLayout(false);
            this._groupBoxFilter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.GroupBox _groupBoxFilter;
        internal System.Windows.Forms.CheckBox _checkBoxSphere;
        internal System.Windows.Forms.CheckBox _checkBoxParallelepiped;
        internal System.Windows.Forms.CheckBox _checkBoxPyramid;
        internal System.Windows.Forms.CheckBox _checkBoxValue;
        internal System.Windows.Forms.TextBox _textBoxValue;
    }
}