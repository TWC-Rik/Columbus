namespace Columbus
{
    partial class MainForm
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
            this.menu = new System.Windows.Forms.MenuStrip();
            this.vluchtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSelectUDP = new System.Windows.Forms.ToolStripMenuItem();
            this.kampioenschappenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.udpPathDialog = new System.Windows.Forms.OpenFileDialog();
            this.ctlRace = new Columbus.Ctrl_Race();
            this.filterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vluchtToolStripMenuItem,
            this.kampioenschappenToolStripMenuItem});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(1198, 24);
            this.menu.TabIndex = 0;
            this.menu.Text = "menuStrip1";
            // 
            // vluchtToolStripMenuItem
            // 
            this.vluchtToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSelectUDP,
            this.filterToolStripMenuItem});
            this.vluchtToolStripMenuItem.Name = "vluchtToolStripMenuItem";
            this.vluchtToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.vluchtToolStripMenuItem.Text = "Vlucht";
            // 
            // btnSelectUDP
            // 
            this.btnSelectUDP.Name = "btnSelectUDP";
            this.btnSelectUDP.Size = new System.Drawing.Size(180, 22);
            this.btnSelectUDP.Text = "Selecteer .UDP";
            this.btnSelectUDP.Click += new System.EventHandler(this.btnSelectUDP_Click);
            // 
            // kampioenschappenToolStripMenuItem
            // 
            this.kampioenschappenToolStripMenuItem.Name = "kampioenschappenToolStripMenuItem";
            this.kampioenschappenToolStripMenuItem.Size = new System.Drawing.Size(124, 20);
            this.kampioenschappenToolStripMenuItem.Text = "Kampioenschappen";
            // 
            // ctlRace
            // 
            this.ctlRace.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctlRace.Location = new System.Drawing.Point(0, 24);
            this.ctlRace.Name = "ctlRace";
            this.ctlRace.Size = new System.Drawing.Size(1198, 524);
            this.ctlRace.TabIndex = 1;
            // 
            // filterToolStripMenuItem
            // 
            this.filterToolStripMenuItem.Name = "filterToolStripMenuItem";
            this.filterToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.filterToolStripMenuItem.Text = "Filter";
            this.filterToolStripMenuItem.Click += new System.EventHandler(this.filterToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1198, 548);
            this.Controls.Add(this.ctlRace);
            this.Controls.Add(this.menu);
            this.MainMenuStrip = this.menu;
            this.Name = "MainForm";
            this.Text = "Columbus";
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem vluchtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kampioenschappenToolStripMenuItem;
        private Ctrl_Race ctlRace;
        private System.Windows.Forms.ToolStripMenuItem btnSelectUDP;
        private System.Windows.Forms.OpenFileDialog udpPathDialog;
        private System.Windows.Forms.ToolStripMenuItem filterToolStripMenuItem;
    }
}

