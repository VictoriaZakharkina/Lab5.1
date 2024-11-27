namespace View
{
    partial class AddForm
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
            this._groupBoxParametrs = new System.Windows.Forms.GroupBox();
            this._userControlPyramid = new View.UserControlPyramid();
            this._userControlSphere = new View.UserControlSphere();
            this._userControlParallelepiped = new View.UserControlParallelepiped();
            this._groupBoxFigure = new System.Windows.Forms.GroupBox();
            this._checkBoxPyramid = new System.Windows.Forms.CheckBox();
            this._checkBoxParallelepiped = new System.Windows.Forms.CheckBox();
            this._checkBoxSphere = new System.Windows.Forms.CheckBox();
            this._button1 = new System.Windows.Forms.Button();
            this._button2 = new System.Windows.Forms.Button();
            this._groupBoxParametrs.SuspendLayout();
            this._groupBoxFigure.SuspendLayout();
            this.SuspendLayout();
            // 
            // _groupBoxParametrs
            // 
            this._groupBoxParametrs.Controls.Add(this._userControlPyramid);
            this._groupBoxParametrs.Controls.Add(this._userControlSphere);
            this._groupBoxParametrs.Controls.Add(this._userControlParallelepiped);
            this._groupBoxParametrs.Location = new System.Drawing.Point(12, 78);
            this._groupBoxParametrs.Name = "_groupBoxParametrs";
            this._groupBoxParametrs.Size = new System.Drawing.Size(384, 190);
            this._groupBoxParametrs.TabIndex = 1;
            this._groupBoxParametrs.TabStop = false;
            this._groupBoxParametrs.Text = "Параметры (см, град)";
            this._groupBoxParametrs.Visible = false;
            // 
            // _userControlPyramid
            // 
            this._userControlPyramid.Location = new System.Drawing.Point(7, 22);
            this._userControlPyramid.Name = "_userControlPyramid";
            this._userControlPyramid.Size = new System.Drawing.Size(369, 159);
            this._userControlPyramid.TabIndex = 2;
            // 
            // _userControlSphere
            // 
            this._userControlSphere.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this._userControlSphere.BackColor = System.Drawing.SystemColors.Control;
            this._userControlSphere.ForeColor = System.Drawing.SystemColors.ControlText;
            this._userControlSphere.Location = new System.Drawing.Point(7, 25);
            this._userControlSphere.Name = "_userControlSphere";
            this._userControlSphere.Size = new System.Drawing.Size(369, 159);
            this._userControlSphere.TabIndex = 1;
            // 
            // _userControlParallelepiped
            // 
            this._userControlParallelepiped.Location = new System.Drawing.Point(7, 22);
            this._userControlParallelepiped.Name = "_userControlParallelepiped";
            this._userControlParallelepiped.Size = new System.Drawing.Size(369, 159);
            this._userControlParallelepiped.TabIndex = 0;
            this._userControlParallelepiped.Visible = false;
            // 
            // _groupBoxFigure
            // 
            this._groupBoxFigure.Controls.Add(this._checkBoxPyramid);
            this._groupBoxFigure.Controls.Add(this._checkBoxParallelepiped);
            this._groupBoxFigure.Controls.Add(this._checkBoxSphere);
            this._groupBoxFigure.Location = new System.Drawing.Point(12, 12);
            this._groupBoxFigure.Name = "_groupBoxFigure";
            this._groupBoxFigure.Size = new System.Drawing.Size(384, 60);
            this._groupBoxFigure.TabIndex = 2;
            this._groupBoxFigure.TabStop = false;
            this._groupBoxFigure.Text = "Фигура";
            // 
            // _checkBoxPyramid
            // 
            this._checkBoxPyramid.AutoSize = true;
            this._checkBoxPyramid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._checkBoxPyramid.Location = new System.Drawing.Point(277, 26);
            this._checkBoxPyramid.Name = "_checkBoxPyramid";
            this._checkBoxPyramid.Size = new System.Drawing.Size(101, 22);
            this._checkBoxPyramid.TabIndex = 2;
            this._checkBoxPyramid.Text = "Пирамида";
            this._checkBoxPyramid.UseVisualStyleBackColor = true;
            // 
            // _checkBoxParallelepiped
            // 
            this._checkBoxParallelepiped.AutoSize = true;
            this._checkBoxParallelepiped.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._checkBoxParallelepiped.Location = new System.Drawing.Point(104, 26);
            this._checkBoxParallelepiped.Name = "_checkBoxParallelepiped";
            this._checkBoxParallelepiped.Size = new System.Drawing.Size(149, 22);
            this._checkBoxParallelepiped.TabIndex = 1;
            this._checkBoxParallelepiped.Text = "Параллелепипед";
            this._checkBoxParallelepiped.UseVisualStyleBackColor = true;
            // 
            // _checkBoxSphere
            // 
            this._checkBoxSphere.AutoSize = true;
            this._checkBoxSphere.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._checkBoxSphere.Location = new System.Drawing.Point(16, 26);
            this._checkBoxSphere.Name = "_checkBoxSphere";
            this._checkBoxSphere.Size = new System.Drawing.Size(59, 22);
            this._checkBoxSphere.TabIndex = 0;
            this._checkBoxSphere.Text = "Шар";
            this._checkBoxSphere.UseVisualStyleBackColor = true;
            // 
            // _button1
            // 
            this._button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._button1.Location = new System.Drawing.Point(12, 274);
            this._button1.Name = "_button1";
            this._button1.Size = new System.Drawing.Size(92, 33);
            this._button1.TabIndex = 3;
            this._button1.Text = "Добавить";
            this._button1.UseVisualStyleBackColor = true;
            this._button1.Click += new System.EventHandler(this.ButtonClick);
            // 
            // _button2
            // 
            this._button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._button2.Location = new System.Drawing.Point(116, 274);
            this._button2.Name = "_button2";
            this._button2.Size = new System.Drawing.Size(92, 33);
            this._button2.TabIndex = 4;
            this._button2.Text = "Закрыть";
            this._button2.UseVisualStyleBackColor = true;
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 315);
            this.Controls.Add(this._button2);
            this.Controls.Add(this._button1);
            this.Controls.Add(this._groupBoxFigure);
            this.Controls.Add(this._groupBoxParametrs);
            this.Name = "AddForm";
            this.Text = "Добавление";
            this._groupBoxParametrs.ResumeLayout(false);
            this._groupBoxFigure.ResumeLayout(false);
            this._groupBoxFigure.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox _groupBoxFigure;
        internal System.Windows.Forms.CheckBox _checkBoxPyramid;
        internal System.Windows.Forms.CheckBox _checkBoxParallelepiped;
        internal System.Windows.Forms.CheckBox _checkBoxSphere;
        internal System.Windows.Forms.GroupBox _groupBoxParametrs;
        private System.Windows.Forms.Button _button1;
        private System.Windows.Forms.Button _button2;
        private UserControlParallelepiped _userControlParallelepiped;
        private UserControlSphere _userControlSphere;
        private UserControlPyramid _userControlPyramid;
    }
}