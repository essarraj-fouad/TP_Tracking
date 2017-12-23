namespace TP_Tracking.Presentation
{
    partial class AppForm
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
            this.groupBoxRepertories = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.bt_refresh = new System.Windows.Forms.Button();
            this.groupBoxAction = new System.Windows.Forms.GroupBox();
            this.bt_save_repport = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageOrganisation = new System.Windows.Forms.TabPage();
            this.tabPageTD = new System.Windows.Forms.TabPage();
            this.tabPageTP = new System.Windows.Forms.TabPage();
            this.tabPageCours = new System.Windows.Forms.TabPage();
            this.tabPageRecherches = new System.Windows.Forms.TabPage();
            this.repertoriesRoot = new TP_Tracking.Presentation.UI.RepertoriesControl();
            this.repertoriesTD = new TP_Tracking.Presentation.UI.RepertoriesControl();
            this.repertoriesTP = new TP_Tracking.Presentation.UI.RepertoriesControl();
            this.configurationFileDeviceControl1 = new TP_Tracking.Presentation.UI.ConfigurationFileDeviceControl();
            this.repertoriesControl1 = new TP_Tracking.Presentation.UI.RepertoriesControl();
            this.repertoriesControl2 = new TP_Tracking.Presentation.UI.RepertoriesControl();
            this.btEditeProfile = new System.Windows.Forms.Button();
            this.groupBoxRepertories.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBoxAction.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPageOrganisation.SuspendLayout();
            this.tabPageTD.SuspendLayout();
            this.tabPageTP.SuspendLayout();
            this.tabPageCours.SuspendLayout();
            this.tabPageRecherches.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxRepertories
            // 
            this.groupBoxRepertories.Controls.Add(this.repertoriesRoot);
            this.groupBoxRepertories.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxRepertories.Location = new System.Drawing.Point(3, 3);
            this.groupBoxRepertories.Name = "groupBoxRepertories";
            this.groupBoxRepertories.Size = new System.Drawing.Size(546, 199);
            this.groupBoxRepertories.TabIndex = 1;
            this.groupBoxRepertories.TabStop = false;
            this.groupBoxRepertories.Text = "Organisations des répertoires";
            this.groupBoxRepertories.Enter += new System.EventHandler(this.groupBoxRepertories_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.repertoriesTD);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(546, 199);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "TD";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.repertoriesTP);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(3, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(546, 199);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "TP";
            // 
            // bt_refresh
            // 
            this.bt_refresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_refresh.Location = new System.Drawing.Point(485, 19);
            this.bt_refresh.Name = "bt_refresh";
            this.bt_refresh.Size = new System.Drawing.Size(120, 69);
            this.bt_refresh.TabIndex = 5;
            this.bt_refresh.Text = "Actualiser";
            this.bt_refresh.UseVisualStyleBackColor = true;
            this.bt_refresh.Click += new System.EventHandler(this.bt_refresh_Click);
            // 
            // groupBoxAction
            // 
            this.groupBoxAction.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxAction.Controls.Add(this.btEditeProfile);
            this.groupBoxAction.Controls.Add(this.bt_save_repport);
            this.groupBoxAction.Controls.Add(this.configurationFileDeviceControl1);
            this.groupBoxAction.Controls.Add(this.bt_refresh);
            this.groupBoxAction.Location = new System.Drawing.Point(12, 12);
            this.groupBoxAction.Name = "groupBoxAction";
            this.groupBoxAction.Size = new System.Drawing.Size(611, 100);
            this.groupBoxAction.TabIndex = 7;
            this.groupBoxAction.TabStop = false;
            this.groupBoxAction.Text = "Actions";
            // 
            // bt_save_repport
            // 
            this.bt_save_repport.Location = new System.Drawing.Point(106, 19);
            this.bt_save_repport.Name = "bt_save_repport";
            this.bt_save_repport.Size = new System.Drawing.Size(107, 75);
            this.bt_save_repport.TabIndex = 7;
            this.bt_save_repport.Text = "Enregistrer l\'état";
            this.bt_save_repport.UseVisualStyleBackColor = true;
            this.bt_save_repport.Click += new System.EventHandler(this.bt_save_repport_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPageOrganisation);
            this.tabControl1.Controls.Add(this.tabPageTD);
            this.tabControl1.Controls.Add(this.tabPageTP);
            this.tabControl1.Controls.Add(this.tabPageCours);
            this.tabControl1.Controls.Add(this.tabPageRecherches);
            this.tabControl1.Location = new System.Drawing.Point(12, 118);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(611, 246);
            this.tabControl1.TabIndex = 9;
            // 
            // tabPageOrganisation
            // 
            this.tabPageOrganisation.Controls.Add(this.groupBoxRepertories);
            this.tabPageOrganisation.Location = new System.Drawing.Point(4, 22);
            this.tabPageOrganisation.Name = "tabPageOrganisation";
            this.tabPageOrganisation.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageOrganisation.Size = new System.Drawing.Size(552, 205);
            this.tabPageOrganisation.TabIndex = 0;
            this.tabPageOrganisation.Text = "Organisation des répertoires";
            this.tabPageOrganisation.UseVisualStyleBackColor = true;
            // 
            // tabPageTD
            // 
            this.tabPageTD.Controls.Add(this.groupBox2);
            this.tabPageTD.Location = new System.Drawing.Point(4, 22);
            this.tabPageTD.Name = "tabPageTD";
            this.tabPageTD.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTD.Size = new System.Drawing.Size(552, 205);
            this.tabPageTD.TabIndex = 1;
            this.tabPageTD.Text = "TD";
            this.tabPageTD.UseVisualStyleBackColor = true;
            // 
            // tabPageTP
            // 
            this.tabPageTP.Controls.Add(this.groupBox3);
            this.tabPageTP.Location = new System.Drawing.Point(4, 22);
            this.tabPageTP.Name = "tabPageTP";
            this.tabPageTP.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTP.Size = new System.Drawing.Size(552, 205);
            this.tabPageTP.TabIndex = 2;
            this.tabPageTP.Text = "TP";
            this.tabPageTP.UseVisualStyleBackColor = true;
            // 
            // tabPageCours
            // 
            this.tabPageCours.Controls.Add(this.repertoriesControl1);
            this.tabPageCours.Location = new System.Drawing.Point(4, 22);
            this.tabPageCours.Name = "tabPageCours";
            this.tabPageCours.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCours.Size = new System.Drawing.Size(603, 220);
            this.tabPageCours.TabIndex = 3;
            this.tabPageCours.Text = "Cours";
            this.tabPageCours.UseVisualStyleBackColor = true;
            // 
            // tabPageRecherches
            // 
            this.tabPageRecherches.Controls.Add(this.repertoriesControl2);
            this.tabPageRecherches.Location = new System.Drawing.Point(4, 22);
            this.tabPageRecherches.Name = "tabPageRecherches";
            this.tabPageRecherches.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageRecherches.Size = new System.Drawing.Size(603, 220);
            this.tabPageRecherches.TabIndex = 4;
            this.tabPageRecherches.Text = "tabRecherches";
            this.tabPageRecherches.UseVisualStyleBackColor = true;
            // 
            // repertoriesRoot
            // 
            this.repertoriesRoot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.repertoriesRoot.Location = new System.Drawing.Point(3, 16);
            this.repertoriesRoot.Name = "repertoriesRoot";
            this.repertoriesRoot.ParentFileData = null;
            this.repertoriesRoot.Size = new System.Drawing.Size(540, 180);
            this.repertoriesRoot.TabIndex = 0;
            // 
            // repertoriesTD
            // 
            this.repertoriesTD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.repertoriesTD.Location = new System.Drawing.Point(3, 16);
            this.repertoriesTD.Name = "repertoriesTD";
            this.repertoriesTD.ParentFileData = null;
            this.repertoriesTD.Size = new System.Drawing.Size(540, 180);
            this.repertoriesTD.TabIndex = 0;
            // 
            // repertoriesTP
            // 
            this.repertoriesTP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.repertoriesTP.Location = new System.Drawing.Point(3, 16);
            this.repertoriesTP.Name = "repertoriesTP";
            this.repertoriesTP.ParentFileData = null;
            this.repertoriesTP.Size = new System.Drawing.Size(540, 180);
            this.repertoriesTP.TabIndex = 0;
            // 
            // configurationFileDeviceControl1
            // 
            this.configurationFileDeviceControl1.Location = new System.Drawing.Point(23, 25);
            this.configurationFileDeviceControl1.Name = "configurationFileDeviceControl1";
            this.configurationFileDeviceControl1.Size = new System.Drawing.Size(77, 69);
            this.configurationFileDeviceControl1.TabIndex = 6;
            // 
            // repertoriesControl1
            // 
            this.repertoriesControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.repertoriesControl1.Location = new System.Drawing.Point(3, 3);
            this.repertoriesControl1.Name = "repertoriesControl1";
            this.repertoriesControl1.ParentFileData = null;
            this.repertoriesControl1.Size = new System.Drawing.Size(597, 214);
            this.repertoriesControl1.TabIndex = 0;
            // 
            // repertoriesControl2
            // 
            this.repertoriesControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.repertoriesControl2.Location = new System.Drawing.Point(3, 3);
            this.repertoriesControl2.Name = "repertoriesControl2";
            this.repertoriesControl2.ParentFileData = null;
            this.repertoriesControl2.Size = new System.Drawing.Size(597, 214);
            this.repertoriesControl2.TabIndex = 0;
            // 
            // btEditeProfile
            // 
            this.btEditeProfile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btEditeProfile.Location = new System.Drawing.Point(359, 19);
            this.btEditeProfile.Name = "btEditeProfile";
            this.btEditeProfile.Size = new System.Drawing.Size(120, 69);
            this.btEditeProfile.TabIndex = 8;
            this.btEditeProfile.Text = "Profile";
            this.btEditeProfile.UseVisualStyleBackColor = true;
            this.btEditeProfile.Click += new System.EventHandler(this.btEditeProfile_Click);
            // 
            // AppForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 376);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.groupBoxAction);
            this.MinimumSize = new System.Drawing.Size(600, 400);
            this.Name = "AppForm";
            this.Text = "Suivi des TD et TP";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AppForm_Load);
            this.groupBoxRepertories.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBoxAction.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPageOrganisation.ResumeLayout(false);
            this.tabPageTD.ResumeLayout(false);
            this.tabPageTP.ResumeLayout(false);
            this.tabPageCours.ResumeLayout(false);
            this.tabPageRecherches.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBoxRepertories;
        private UI.RepertoriesControl repertoriesRoot;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private UI.RepertoriesControl repertoriesTD;
        private UI.RepertoriesControl repertoriesTP;
        private System.Windows.Forms.Button bt_refresh;
        private UI.ConfigurationFileDeviceControl configurationFileDeviceControl1;
        private System.Windows.Forms.GroupBox groupBoxAction;
        private System.Windows.Forms.Button bt_save_repport;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageOrganisation;
        private System.Windows.Forms.TabPage tabPageTD;
        private System.Windows.Forms.TabPage tabPageTP;
        private System.Windows.Forms.TabPage tabPageCours;
        private System.Windows.Forms.TabPage tabPageRecherches;
        private UI.RepertoriesControl repertoriesControl1;
        private UI.RepertoriesControl repertoriesControl2;
        private System.Windows.Forms.Button btEditeProfile;
    }
}