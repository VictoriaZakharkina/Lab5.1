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
            this.groupBoxParametrs = new System.Windows.Forms.GroupBox();
            this.userControlParallelepiped1 = new View.UserControlParallelepiped();
            this.groupBoxFigure = new System.Windows.Forms.GroupBox();
            this.checkBoxPyramid = new System.Windows.Forms.CheckBox();
            this.checkBoxParallelepiped = new System.Windows.Forms.CheckBox();
            this.checkBoxSphere = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBoxParametrs.SuspendLayout();
            this.groupBoxFigure.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxParametrs
            // 
            this.groupBoxParametrs.Controls.Add(this.userControlParallelepiped1);
            this.groupBoxParametrs.Location = new System.Drawing.Point(12, 78);
            this.groupBoxParametrs.Name = "groupBoxParametrs";
            this.groupBoxParametrs.Size = new System.Drawing.Size(384, 190);
            this.groupBoxParametrs.TabIndex = 1;
            this.groupBoxParametrs.TabStop = false;
            this.groupBoxParametrs.Text = "Параметры (см, град)";
            this.groupBoxParametrs.Visible = false;
            // 
            // userControlParallelepiped1
            // 
            this.userControlParallelepiped1.Location = new System.Drawing.Point(7, 23);
            this.userControlParallelepiped1.Name = "userControlParallelepiped1";
            this.userControlParallelepiped1.Size = new System.Drawing.Size(369, 159);
            this.userControlParallelepiped1.TabIndex = 0;
            this.userControlParallelepiped1.Visible = false;
            // 
            // groupBoxFigure
            // 
            this.groupBoxFigure.Controls.Add(this.checkBoxPyramid);
            this.groupBoxFigure.Controls.Add(this.checkBoxParallelepiped);
            this.groupBoxFigure.Controls.Add(this.checkBoxSphere);
            this.groupBoxFigure.Location = new System.Drawing.Point(12, 12);
            this.groupBoxFigure.Name = "groupBoxFigure";
            this.groupBoxFigure.Size = new System.Drawing.Size(384, 60);
            this.groupBoxFigure.TabIndex = 2;
            this.groupBoxFigure.TabStop = false;
            this.groupBoxFigure.Text = "Фигура";
            // 
            // checkBoxPyramid
            // 
            this.checkBoxPyramid.AutoSize = true;
            this.checkBoxPyramid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxPyramid.Location = new System.Drawing.Point(277, 26);
            this.checkBoxPyramid.Name = "checkBoxPyramid";
            this.checkBoxPyramid.Size = new System.Drawing.Size(101, 22);
            this.checkBoxPyramid.TabIndex = 2;
            this.checkBoxPyramid.Text = "Пирамида";
            this.checkBoxPyramid.UseVisualStyleBackColor = true;
            // 
            // checkBoxParallelepiped
            // 
            this.checkBoxParallelepiped.AutoSize = true;
            this.checkBoxParallelepiped.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxParallelepiped.Location = new System.Drawing.Point(104, 26);
            this.checkBoxParallelepiped.Name = "checkBoxParallelepiped";
            this.checkBoxParallelepiped.Size = new System.Drawing.Size(149, 22);
            this.checkBoxParallelepiped.TabIndex = 1;
            this.checkBoxParallelepiped.Text = "Параллелепипед";
            this.checkBoxParallelepiped.UseVisualStyleBackColor = true;
            // 
            // checkBoxSphere
            // 
            this.checkBoxSphere.AutoSize = true;
            this.checkBoxSphere.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxSphere.Location = new System.Drawing.Point(16, 26);
            this.checkBoxSphere.Name = "checkBoxSphere";
            this.checkBoxSphere.Size = new System.Drawing.Size(59, 22);
            this.checkBoxSphere.TabIndex = 0;
            this.checkBoxSphere.Text = "Шар";
            this.checkBoxSphere.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(12, 274);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 33);
            this.button1.TabIndex = 3;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(116, 274);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(92, 33);
            this.button2.TabIndex = 4;
            this.button2.Text = "Закрыть";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 315);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBoxFigure);
            this.Controls.Add(this.groupBoxParametrs);
            this.Name = "AddForm";
            this.Text = "Добавление";
            this.groupBoxParametrs.ResumeLayout(false);
            this.groupBoxFigure.ResumeLayout(false);
            this.groupBoxFigure.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBoxFigure;
        internal System.Windows.Forms.CheckBox checkBoxPyramid;
        internal System.Windows.Forms.CheckBox checkBoxParallelepiped;
        internal System.Windows.Forms.CheckBox checkBoxSphere;
        internal System.Windows.Forms.UserControl userControlSphere;
        internal System.Windows.Forms.GroupBox groupBoxParametrs;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private UserControlParallelepiped userControlParallelepiped1;
    }
}