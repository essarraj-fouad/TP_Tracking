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
            this.metroSetTabControl1 = new MetroSet_UI.Controls.MetroSetTabControl();
            this.TabPageEstablishment = new MetroSet_UI.Child.MetroSetTabPage();
            this.TabPageTraining = new MetroSet_UI.Child.MetroSetTabPage();
            this.TaskManagerTabPage = new MetroSet_UI.Child.MetroSetTabPage();
            this.ProjectsTile = new MetroSet_UI.Controls.MetroSetTile();
            this.GroupesTile = new MetroSet_UI.Controls.MetroSetTile();
            this.SpecialityTile = new MetroSet_UI.Controls.MetroSetTile();
            this.TasksTile = new MetroSet_UI.Controls.MetroSetTile();
            this.menuStrip1.SuspendLayout();
            this.metroSetTabControl1.SuspendLayout();
            this.TabPageEstablishment.SuspendLayout();
            this.TaskManagerTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.etablissementToolStripMenuItem,
            this.gestionDesProjetsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(20, 138);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(783, 24);
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
            this.projetsToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.projetsToolStripMenuItem.Text = "Projets";
            this.projetsToolStripMenuItem.Click += new System.EventHandler(this.projetsToolStripMenuItem_Click);
            // 
            // tâchesToolStripMenuItem
            // 
            this.tâchesToolStripMenuItem.Name = "tâchesToolStripMenuItem";
            this.tâchesToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.tâchesToolStripMenuItem.Text = "Tâches";
            this.tâchesToolStripMenuItem.Click += new System.EventHandler(this.tâchesToolStripMenuItem_Click);
            // 
            // metroSetTabControl1
            // 
            this.metroSetTabControl1.Controls.Add(this.TabPageEstablishment);
            this.metroSetTabControl1.Controls.Add(this.TabPageTraining);
            this.metroSetTabControl1.Controls.Add(this.TaskManagerTabPage);
            this.metroSetTabControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.metroSetTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroSetTabControl1.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.metroSetTabControl1.ItemSize = new System.Drawing.Size(100, 38);
            this.metroSetTabControl1.Location = new System.Drawing.Point(20, 162);
            this.metroSetTabControl1.Name = "metroSetTabControl1";
            this.metroSetTabControl1.SelectedIndex = 2;
            this.metroSetTabControl1.Size = new System.Drawing.Size(783, 189);
            this.metroSetTabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.metroSetTabControl1.Speed = 0;
            this.metroSetTabControl1.Style = MetroSet_UI.Design.Style.Light;
            this.metroSetTabControl1.StyleManager = null;
            this.metroSetTabControl1.TabIndex = 1;
            this.metroSetTabControl1.TabStyle = MetroSet_UI.Enums.TabStyle.Style1;
            this.metroSetTabControl1.ThemeAuthor = "Narwin";
            this.metroSetTabControl1.ThemeName = "MetroLite";
            this.metroSetTabControl1.UseAnimation = false;
            // 
            // TabPageEstablishment
            // 
            this.TabPageEstablishment.BaseColor = System.Drawing.Color.White;
            this.TabPageEstablishment.Controls.Add(this.SpecialityTile);
            this.TabPageEstablishment.Controls.Add(this.GroupesTile);
            this.TabPageEstablishment.ImageIndex = 0;
            this.TabPageEstablishment.ImageKey = null;
            this.TabPageEstablishment.Location = new System.Drawing.Point(4, 42);
            this.TabPageEstablishment.Name = "TabPageEstablishment";
            this.TabPageEstablishment.Size = new System.Drawing.Size(775, 143);
            this.TabPageEstablishment.Style = MetroSet_UI.Design.Style.Light;
            this.TabPageEstablishment.StyleManager = null;
            this.TabPageEstablishment.TabIndex = 0;
            this.TabPageEstablishment.Text = "Etablissement";
            this.TabPageEstablishment.ThemeAuthor = "Narwin";
            this.TabPageEstablishment.ThemeName = "MetroLite";
            this.TabPageEstablishment.ToolTipText = null;
            // 
            // TabPageTraining
            // 
            this.TabPageTraining.BaseColor = System.Drawing.Color.White;
            this.TabPageTraining.ImageIndex = 0;
            this.TabPageTraining.ImageKey = null;
            this.TabPageTraining.Location = new System.Drawing.Point(4, 42);
            this.TabPageTraining.Name = "TabPageTraining";
            this.TabPageTraining.Size = new System.Drawing.Size(775, 143);
            this.TabPageTraining.Style = MetroSet_UI.Design.Style.Light;
            this.TabPageTraining.StyleManager = null;
            this.TabPageTraining.TabIndex = 1;
            this.TabPageTraining.Text = "Formation";
            this.TabPageTraining.ThemeAuthor = "Narwin";
            this.TabPageTraining.ThemeName = "MetroLite";
            this.TabPageTraining.ToolTipText = null;
            // 
            // TaskManagerTabPage
            // 
            this.TaskManagerTabPage.BaseColor = System.Drawing.Color.White;
            this.TaskManagerTabPage.Controls.Add(this.TasksTile);
            this.TaskManagerTabPage.Controls.Add(this.ProjectsTile);
            this.TaskManagerTabPage.ImageIndex = 0;
            this.TaskManagerTabPage.ImageKey = null;
            this.TaskManagerTabPage.Location = new System.Drawing.Point(4, 42);
            this.TaskManagerTabPage.Name = "TaskManagerTabPage";
            this.TaskManagerTabPage.Size = new System.Drawing.Size(775, 143);
            this.TaskManagerTabPage.Style = MetroSet_UI.Design.Style.Light;
            this.TaskManagerTabPage.StyleManager = null;
            this.TaskManagerTabPage.TabIndex = 2;
            this.TaskManagerTabPage.Text = "Gestion des tâches";
            this.TaskManagerTabPage.ThemeAuthor = "Narwin";
            this.TaskManagerTabPage.ThemeName = "MetroLite";
            this.TaskManagerTabPage.ToolTipText = null;
            // 
            // ProjectsTile
            // 
            this.ProjectsTile.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.ProjectsTile.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.ProjectsTile.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.ProjectsTile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ProjectsTile.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.ProjectsTile.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.ProjectsTile.HoverTextColor = System.Drawing.Color.White;
            this.ProjectsTile.Location = new System.Drawing.Point(3, 16);
            this.ProjectsTile.Name = "ProjectsTile";
            this.ProjectsTile.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.ProjectsTile.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.ProjectsTile.NormalTextColor = System.Drawing.Color.White;
            this.ProjectsTile.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.ProjectsTile.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.ProjectsTile.PressTextColor = System.Drawing.Color.White;
            this.ProjectsTile.Size = new System.Drawing.Size(122, 50);
            this.ProjectsTile.Style = MetroSet_UI.Design.Style.Light;
            this.ProjectsTile.StyleManager = null;
            this.ProjectsTile.TabIndex = 0;
            this.ProjectsTile.Text = "Projets";
            this.ProjectsTile.ThemeAuthor = "Narwin";
            this.ProjectsTile.ThemeName = "MetroLite";
            this.ProjectsTile.TileAlign = MetroSet_UI.Enums.TileAlign.BottmLeft;
            this.ProjectsTile.Click += new System.EventHandler(this.ProjectsTile_Click);
            // 
            // GroupesTile
            // 
            this.GroupesTile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupesTile.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.GroupesTile.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.GroupesTile.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.GroupesTile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.GroupesTile.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.GroupesTile.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.GroupesTile.HoverTextColor = System.Drawing.Color.White;
            this.GroupesTile.Location = new System.Drawing.Point(-4, 22);
            this.GroupesTile.Name = "GroupesTile";
            this.GroupesTile.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.GroupesTile.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.GroupesTile.NormalTextColor = System.Drawing.Color.White;
            this.GroupesTile.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.GroupesTile.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.GroupesTile.PressTextColor = System.Drawing.Color.White;
            this.GroupesTile.Size = new System.Drawing.Size(182, 79);
            this.GroupesTile.Style = MetroSet_UI.Design.Style.Light;
            this.GroupesTile.StyleManager = null;
            this.GroupesTile.TabIndex = 0;
            this.GroupesTile.Text = "Groupes";
            this.GroupesTile.ThemeAuthor = "Narwin";
            this.GroupesTile.ThemeName = "MetroLite";
            this.GroupesTile.TileAlign = MetroSet_UI.Enums.TileAlign.BottmLeft;
            this.GroupesTile.Click += new System.EventHandler(this.GroupesTile_Click);
            // 
            // SpecialityTile
            // 
            this.SpecialityTile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SpecialityTile.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.SpecialityTile.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.SpecialityTile.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.SpecialityTile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.SpecialityTile.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.SpecialityTile.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.SpecialityTile.HoverTextColor = System.Drawing.Color.White;
            this.SpecialityTile.Location = new System.Drawing.Point(-1, 108);
            this.SpecialityTile.Name = "SpecialityTile";
            this.SpecialityTile.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.SpecialityTile.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.SpecialityTile.NormalTextColor = System.Drawing.Color.White;
            this.SpecialityTile.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.SpecialityTile.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.SpecialityTile.PressTextColor = System.Drawing.Color.White;
            this.SpecialityTile.Size = new System.Drawing.Size(182, 39);
            this.SpecialityTile.Style = MetroSet_UI.Design.Style.Light;
            this.SpecialityTile.StyleManager = null;
            this.SpecialityTile.TabIndex = 1;
            this.SpecialityTile.Text = "Filières";
            this.SpecialityTile.ThemeAuthor = "Narwin";
            this.SpecialityTile.ThemeName = "MetroLite";
            this.SpecialityTile.TileAlign = MetroSet_UI.Enums.TileAlign.BottmLeft;
            this.SpecialityTile.Click += new System.EventHandler(this.SpecialityTile_Click);
            // 
            // TasksTile
            // 
            this.TasksTile.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.TasksTile.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.TasksTile.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.TasksTile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.TasksTile.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.TasksTile.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.TasksTile.HoverTextColor = System.Drawing.Color.White;
            this.TasksTile.Location = new System.Drawing.Point(3, 72);
            this.TasksTile.Name = "TasksTile";
            this.TasksTile.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.TasksTile.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.TasksTile.NormalTextColor = System.Drawing.Color.White;
            this.TasksTile.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.TasksTile.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.TasksTile.PressTextColor = System.Drawing.Color.White;
            this.TasksTile.Size = new System.Drawing.Size(122, 50);
            this.TasksTile.Style = MetroSet_UI.Design.Style.Light;
            this.TasksTile.StyleManager = null;
            this.TasksTile.TabIndex = 1;
            this.TasksTile.Text = "Tâches";
            this.TasksTile.ThemeAuthor = "Narwin";
            this.TasksTile.ThemeName = "MetroLite";
            this.TasksTile.TileAlign = MetroSet_UI.Enums.TileAlign.BottmLeft;
            this.TasksTile.Click += new System.EventHandler(this.TasksTile_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 369);
            this.Controls.Add(this.metroSetTabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Cplus";
            this.Controls.SetChildIndex(this.menuStrip1, 0);
            this.Controls.SetChildIndex(this.metroSetTabControl1, 0);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.metroSetTabControl1.ResumeLayout(false);
            this.TabPageEstablishment.ResumeLayout(false);
            this.TaskManagerTabPage.ResumeLayout(false);
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
        private MetroSet_UI.Controls.MetroSetTabControl metroSetTabControl1;
        private MetroSet_UI.Child.MetroSetTabPage TabPageEstablishment;
        private MetroSet_UI.Controls.MetroSetTile SpecialityTile;
        private MetroSet_UI.Controls.MetroSetTile GroupesTile;
        private MetroSet_UI.Child.MetroSetTabPage TabPageTraining;
        private MetroSet_UI.Child.MetroSetTabPage TaskManagerTabPage;
        private MetroSet_UI.Controls.MetroSetTile ProjectsTile;
        private MetroSet_UI.Controls.MetroSetTile TasksTile;
    }
}