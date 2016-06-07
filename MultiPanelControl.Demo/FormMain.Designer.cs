namespace MultiPanelControl.Demo
{
    partial class FormMain
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
            this.multiPanel1 = new MultiPanel();
            this.Page1 = new MultiPanelPage();
            this.Page2 = new MultiPanelPage();
            this.Page3 = new MultiPanelPage();
            this.PropertyGrid1 = new System.Windows.Forms.PropertyGrid();
            this.panel1 = new System.Windows.Forms.Panel();
            this.multiPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // multiPanel1
            // 
            this.multiPanel1.Controls.Add(this.Page1);
            this.multiPanel1.Controls.Add(this.Page2);
            this.multiPanel1.Controls.Add(this.Page3);
            this.multiPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.multiPanel1.Location = new System.Drawing.Point(32, 32);
            this.multiPanel1.Name = "multiPanel1";
            this.multiPanel1.SelectedPage = this.Page1;
            this.multiPanel1.Size = new System.Drawing.Size(304, 377);
            this.multiPanel1.TabIndex = 0;
            // 
            // Page1
            // 
            this.Page1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Page1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Page1.Location = new System.Drawing.Point(0, 0);
            this.Page1.Name = "Page1";
            this.Page1.Size = new System.Drawing.Size(304, 377);
            this.Page1.TabIndex = 0;
            this.Page1.Text = "Page1";
            // 
            // Page2
            // 
            this.Page2.BackColor = System.Drawing.SystemColors.Highlight;
            this.Page2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Page2.Location = new System.Drawing.Point(0, 0);
            this.Page2.Name = "Page2";
            this.Page2.Size = new System.Drawing.Size(624, 441);
            this.Page2.TabIndex = 1;
            this.Page2.Text = "Page2";
            // 
            // Page3
            // 
            this.Page3.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Page3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Page3.Location = new System.Drawing.Point(0, 0);
            this.Page3.Name = "Page3";
            this.Page3.Size = new System.Drawing.Size(624, 441);
            this.Page3.TabIndex = 2;
            this.Page3.Text = "Page3";
            // 
            // PropertyGrid1
            // 
            this.PropertyGrid1.Dock = System.Windows.Forms.DockStyle.Right;
            this.PropertyGrid1.Location = new System.Drawing.Point(368, 0);
            this.PropertyGrid1.Name = "PropertyGrid1";
            this.PropertyGrid1.SelectedObject = this.multiPanel1;
            this.PropertyGrid1.Size = new System.Drawing.Size(256, 441);
            this.PropertyGrid1.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.multiPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(32);
            this.panel1.Size = new System.Drawing.Size(368, 441);
            this.panel1.TabIndex = 3;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PropertyGrid1);
            this.Name = "FormMain";
            this.Text = "Main";
            this.multiPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MultiPanel multiPanel1;
        private MultiPanelPage Page1;
        private MultiPanelPage Page2;
        private MultiPanelPage Page3;
        internal System.Windows.Forms.PropertyGrid PropertyGrid1;
        private System.Windows.Forms.Panel panel1;
    }
}