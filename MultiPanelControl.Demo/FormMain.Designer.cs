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
            this.multiPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // multiPanel1
            // 
            this.multiPanel1.Controls.Add(this.Page1);
            this.multiPanel1.Controls.Add(this.Page2);
            this.multiPanel1.Controls.Add(this.Page3);
            this.multiPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.multiPanel1.Location = new System.Drawing.Point(0, 0);
            this.multiPanel1.Name = "multiPanel1";
            this.multiPanel1.SelectedPage = this.Page1;
            this.multiPanel1.Size = new System.Drawing.Size(284, 261);
            this.multiPanel1.TabIndex = 0;
            // 
            // Page1
            // 
            this.Page1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Page1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Page1.Location = new System.Drawing.Point(0, 0);
            this.Page1.Name = "Page1";
            this.Page1.Size = new System.Drawing.Size(284, 261);
            this.Page1.TabIndex = 0;
            this.Page1.Text = "Page1";
            // 
            // Page2
            // 
            this.Page2.BackColor = System.Drawing.SystemColors.Highlight;
            this.Page2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Page2.Location = new System.Drawing.Point(0, 0);
            this.Page2.Name = "Page2";
            this.Page2.Size = new System.Drawing.Size(284, 261);
            this.Page2.TabIndex = 1;
            this.Page2.Text = "Page2";
            // 
            // Page3
            // 
            this.Page3.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Page3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Page3.Location = new System.Drawing.Point(0, 0);
            this.Page3.Name = "Page3";
            this.Page3.Size = new System.Drawing.Size(284, 261);
            this.Page3.TabIndex = 2;
            this.Page3.Text = "Page3";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.multiPanel1);
            this.Name = "FormMain";
            this.Text = "FormMain";
            this.multiPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MultiPanel multiPanel1;
        private MultiPanelPage Page1;
        private MultiPanelPage Page2;
        private MultiPanelPage Page3;
    }
}