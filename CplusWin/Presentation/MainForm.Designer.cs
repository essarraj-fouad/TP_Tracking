namespace App.Presentation
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.etablissementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDesGroupesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDesSpécialitésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDesProjetsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.projetsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tâchesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.etablissementToolStripMenuItem,
            this.gestionDesProjetsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(20, 60);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(796, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // etablissementToolStripMenuItem
            // 
            this.etablissementToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionDesGroupesToolStripMenuItem,
            this.gestionDesSpécialitésToolStripMenuItem});
            this.etablissementToolStripMenuItem.Name = "etablissementToolStripMenuItem";
            this.etablissementToolStripMenuItem.Size = new System.Drawing.Size(92, 20);
            this.etablissementToolStripMenuItem.Text = "Etablissement";
            // 
            // gestionDesGroupesToolStripMenuItem
            // 
            this.gestionDesGroupesToolStripMenuItem.Name = "gestionDesGroupesToolStripMenuItem";
            this.gestionDesGroupesToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.gestionDesGroupesToolStripMenuItem.Text = "Gestion des groupes";
            this.gestionDesGroupesToolStripMenuItem.Click += new System.EventHandler(this.gestionDesGroupesToolStripMenuItem_Click);
            // 
            // gestionDesSpécialitésToolStripMenuItem
            // 
            this.gestionDesSpécialitésToolStripMenuItem.Name = "gestionDesSpécialitésToolStripMenuItem";
            this.gestionDesSpécialitésToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.gestionDesSpécialitésToolStripMenuItem.Text = "Gestion des spécialités";
            this.gestionDesSpécialitésToolStripMenuItem.Click += new System.EventHandler(this.gestionDesSpécialitésToolStripMenuItem_Click);
            // 
            // gestionDesProjetsToolStripMenuItem
            // 
            this.gestionDesProjetsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.projetsToolStripMenuItem,
            this.tâchesToolStripMenuItem});
            this.gestionDesProjetsToolStripMenuItem.Name = "gestionDesProjetsToolStripMenuItem";
            this.gestionDesProjetsToolStripMenuItem.Size = new System.Drawing.Size(119, 20);
            this.gestionDesProjetsToolStripMenuItem.Text = "Gestion des projets";
            // 
            // projetsToolStripMenuItem
            // 
            this.projetsToolStripMenuItem.Name = "projetsToolStripMenuItem";
            this.projetsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.projetsToolStripMenuItem.Text = "Projets";
            this.projetsToolStripMenuItem.Click += new System.EventHandler(this.projetsToolStripMenuItem_Click);
            // 
            // tâchesToolStripMenuItem
            // 
            this.tâchesToolStripMenuItem.Name = "tâchesToolStripMenuItem";
            this.tâchesToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.tâchesToolStripMenuItem.Text = "Tâches";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 388);
            this.Controls.Add(this.menuStrip1);
            this.Location = new System.Drawing.Point(0, 0);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Cplus";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem etablissementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionDesSpécialitésToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionDesGroupesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionDesProjetsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem projetsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tâchesToolStripMenuItem;
    }
}