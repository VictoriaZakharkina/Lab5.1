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
            this._groupBoxFigure = new System.Windows.Forms.GroupBox();
            this._radioButtonPyramid = new System.Windows.Forms.RadioButton();
            this._radioButtonParallelepiped = new System.Windows.Forms.RadioButton();
            this._radioButtonSphere = new System.Windows.Forms.RadioButton();
            this._buttonAdd = new System.Windows.Forms.Button();
            this._buttonClose = new System.Windows.Forms.Button();
            this._userControlSphere = new View.UserControlSphere();
            this._userControlPyramid = new View.UserControlPyramid();
            this._userControlParallelepiped = new View.UserControlParallelepiped();
            this._groupBoxParametrs.SuspendLayout();
            this._groupBoxFigure.SuspendLayout();
            this.SuspendLayout();
            // 
            // _groupBoxParametrs
            // 
            this._groupBoxParametrs.Controls.Add(this._userControlSphere);
            this._groupBoxParametrs.Controls.Add(this._userControlPyramid);
            this._groupBoxParametrs.Controls.Add(this._userControlParallelepiped);
            this._groupBoxParametrs.Location = new System.Drawing.Point(12, 78);
            this._groupBoxParametrs.Name = "_groupBoxParametrs";
            this._groupBoxParametrs.Size = new System.Drawing.Size(451, 190);
            this._groupBoxParametrs.TabIndex = 1;
            this._groupBoxParametrs.TabStop = false;
            this._groupBoxParametrs.Text = "Параметры (см, град)";
            // 
            // _groupBoxFigure
            // 
            this._groupBoxFigure.Controls.Add(this._radioButtonPyramid);
            this._groupBoxFigure.Controls.Add(this._radioButtonParallelepiped);
            this._groupBoxFigure.Controls.Add(this._radioButtonSphere);
            this._groupBoxFigure.Location = new System.Drawing.Point(12, 12);
            this._groupBoxFigure.Name = "_groupBoxFigure";
            this._groupBoxFigure.Size = new System.Drawing.Size(451, 60);
            this._groupBoxFigure.TabIndex = 2;
            this._groupBoxFigure.TabStop = false;
            this._groupBoxFigure.Text = "Фигура";
            // 
            // _radioButtonPyramid
            // 
            this._radioButtonPyramid.AutoSize = true;
            this._radioButtonPyramid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._radioButtonPyramid.Location = new System.Drawing.Point(321, 24);
            this._radioButtonPyramid.Name = "_radioButtonPyramid";
            this._radioButtonPyramid.Size = new System.Drawing.Size(100, 22);
            this._radioButtonPyramid.TabIndex = 2;
            this._radioButtonPyramid.TabStop = true;
            this._radioButtonPyramid.Text = "Пирамида";
            this._radioButtonPyramid.UseVisualStyleBackColor = true;
            this._radioButtonPyramid.CheckedChanged += new System.EventHandler(this.PyramidButtonAdd);
            // 
            // _radioButtonParallelepiped
            // 
            this._radioButtonParallelepiped.AutoSize = true;
            this._radioButtonParallelepiped.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._radioButtonParallelepiped.Location = new System.Drawing.Point(126, 24);
            this._radioButtonParallelepiped.Name = "_radioButtonParallelepiped";
            this._radioButtonParallelepiped.Size = new System.Drawing.Size(148, 22);
            this._radioButtonParallelepiped.TabIndex = 1;
            this._radioButtonParallelepiped.TabStop = true;
            this._radioButtonParallelepiped.Text = "Параллелепипед";
            this._radioButtonParallelepiped.UseVisualStyleBackColor = true;
            this._radioButtonParallelepiped.CheckedChanged += new System.EventHandler(this.ParallelepipedButtonAdd);
            // 
            // _radioButtonSphere
            // 
            this._radioButtonSphere.AutoSize = true;
            this._radioButtonSphere.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._radioButtonSphere.Location = new System.Drawing.Point(24, 24);
            this._radioButtonSphere.Name = "_radioButtonSphere";
            this._radioButtonSphere.Size = new System.Drawing.Size(58, 22);
            this._radioButtonSphere.TabIndex = 0;
            this._radioButtonSphere.TabStop = true;
            this._radioButtonSphere.Text = "Шар";
            this._radioButtonSphere.UseVisualStyleBackColor = true;
            this._radioButtonSphere.CheckedChanged += new System.EventHandler(this.SphereButtonAdd);
            // 
            // _buttonAdd
            // 
            this._buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._buttonAdd.Location = new System.Drawing.Point(12, 274);
            this._buttonAdd.Name = "_buttonAdd";
            this._buttonAdd.Size = new System.Drawing.Size(92, 33);
            this._buttonAdd.TabIndex = 3;
            this._buttonAdd.Text = "Добавить";
            this._buttonAdd.UseVisualStyleBackColor = true;
            this._buttonAdd.Click += new System.EventHandler(this.ButtonAdd);
            // 
            // _buttonClose
            // 
            this._buttonClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._buttonClose.Location = new System.Drawing.Point(116, 274);
            this._buttonClose.Name = "_buttonClose";
            this._buttonClose.Size = new System.Drawing.Size(92, 33);
            this._buttonClose.TabIndex = 4;
            this._buttonClose.Text = "Закрыть";
            this._buttonClose.UseVisualStyleBackColor = true;
            this._buttonClose.Click += new System.EventHandler(this.CloseButton);
            // 
            // _userControlSphere
            // 
            this._userControlSphere.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this._userControlSphere.BackColor = System.Drawing.SystemColors.Control;
            this._userControlSphere.ForeColor = System.Drawing.SystemColors.ControlText;
            this._userControlSphere.Location = new System.Drawing.Point(6, 22);
            this._userControlSphere.Name = "_userControlSphere";
            this._userControlSphere.Size = new System.Drawing.Size(438, 159);
            this._userControlSphere.TabIndex = 1;
            this._userControlSphere.Visible = false;
            // 
            // _userControlPyramid
            // 
            this._userControlPyramid.Location = new System.Drawing.Point(6, 21);
            this._userControlPyramid.Name = "_userControlPyramid";
            this._userControlPyramid.Size = new System.Drawing.Size(438, 159);
            this._userControlPyramid.TabIndex = 2;
            this._userControlPyramid.Visible = false;
            // 
            // _userControlParallelepiped
            // 
            this._userControlParallelepiped.Location = new System.Drawing.Point(6, 22);
            this._userControlParallelepiped.Name = "_userControlParallelepiped";
            this._userControlParallelepiped.Size = new System.Drawing.Size(438, 159);
            this._userControlParallelepiped.TabIndex = 0;
            this._userControlParallelepiped.Visible = false;
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 315);
            this.Controls.Add(this._buttonClose);
            this.Controls.Add(this._buttonAdd);
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
        
        internal System.Windows.Forms.GroupBox _groupBoxFigure;
        internal System.Windows.Forms.GroupBox _groupBoxParametrs;
        internal System.Windows.Forms.Button _buttonAdd;
        internal System.Windows.Forms.Button _buttonClose;
        internal UserControlParallelepiped _userControlParallelepiped;
        internal UserControlSphere _userControlSphere;
        internal UserControlPyramid _userControlPyramid;
        internal System.Windows.Forms.RadioButton _radioButtonPyramid;
        internal System.Windows.Forms.RadioButton _radioButtonParallelepiped;
        internal System.Windows.Forms.RadioButton _radioButtonSphere;
    }
}