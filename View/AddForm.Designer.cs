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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddForm));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButtonFigure = new System.Windows.Forms.ToolStripDropDownButton();
            this.ballToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.parallelepipedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pyramidToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBoxParametrs = new System.Windows.Forms.GroupBox();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButtonFigure});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(292, 27);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButtonFigure
            // 
            this.toolStripDropDownButtonFigure.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButtonFigure.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ballToolStripMenuItem,
            this.parallelepipedToolStripMenuItem,
            this.pyramidToolStripMenuItem});
            this.toolStripDropDownButtonFigure.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButtonFigure.Image")));
            this.toolStripDropDownButtonFigure.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButtonFigure.Name = "toolStripDropDownButtonFigure";
            this.toolStripDropDownButtonFigure.Size = new System.Drawing.Size(73, 24);
            this.toolStripDropDownButtonFigure.Text = "Фигура";
            // 
            // ballToolStripMenuItem
            // 
            this.ballToolStripMenuItem.Name = "ballToolStripMenuItem";
            this.ballToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.ballToolStripMenuItem.Text = "Шар";
            // 
            // parallelepipedToolStripMenuItem
            // 
            this.parallelepipedToolStripMenuItem.Name = "parallelepipedToolStripMenuItem";
            this.parallelepipedToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.parallelepipedToolStripMenuItem.Text = "Параллелепипед";
            // 
            // pyramidToolStripMenuItem
            // 
            this.pyramidToolStripMenuItem.Name = "pyramidToolStripMenuItem";
            this.pyramidToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.pyramidToolStripMenuItem.Text = "Пирамида";
            // 
            // groupBoxParametrs
            // 
            this.groupBoxParametrs.Location = new System.Drawing.Point(12, 30);
            this.groupBoxParametrs.Name = "groupBoxParametrs";
            this.groupBoxParametrs.Size = new System.Drawing.Size(268, 200);
            this.groupBoxParametrs.TabIndex = 1;
            this.groupBoxParametrs.TabStop = false;
            this.groupBoxParametrs.Text = "Параметры (см, град)";
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 242);
            this.Controls.Add(this.groupBoxParametrs);
            this.Controls.Add(this.toolStrip1);
            this.Name = "AddForm";
            this.Text = "Добавить фигуру";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButtonFigure;
        private System.Windows.Forms.ToolStripMenuItem ballToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem parallelepipedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pyramidToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBoxParametrs;
    }
}