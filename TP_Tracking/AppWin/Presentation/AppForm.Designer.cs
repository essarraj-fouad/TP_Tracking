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
            this.configurationFileDeviceControl1 = new TP_Tracking.Presentation.UI.ConfigurationFileDeviceControl();
            this.repertoriesTP = new TP_Tracking.Presentation.UI.RepertoriesControl();
            this.repertoriesTD = new TP_Tracking.Presentation.UI.RepertoriesControl();
            this.repertoriesRoot = new TP_Tracking.Presentation.UI.RepertoriesControl();
            this.groupBoxRepertories.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBoxAction.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxRepertories
            // 
            this.groupBoxRepertories.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxRepertories.Controls.Add(this.repertoriesRoot);
            this.groupBoxRepertories.Location = new System.Drawing.Point(12, 131);
            this.groupBoxRepertories.Name = "groupBoxRepertories";
            this.groupBoxRepertories.Size = new System.Drawing.Size(288, 297);
            this.groupBoxRepertories.TabIndex = 1;
            this.groupBoxRepertories.TabStop = false;
            this.groupBoxRepertories.Text = "Organisations des répertoires";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.repertoriesTD);
            this.groupBox2.Location = new System.Drawing.Point(551, 131);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(333, 297);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "TD";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.repertoriesTP);
            this.groupBox3.Location = new System.Drawing.Point(306, 131);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(239, 296);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "TP";
            // 
            // bt_refresh
            // 
            this.bt_refresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_refresh.Location = new System.Drawing.Point(736, 19);
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
            this.groupBoxAction.Controls.Add(this.bt_save_repport);
            this.groupBoxAction.Controls.Add(this.configurationFileDeviceControl1);
            this.groupBoxAction.Controls.Add(this.bt_refresh);
            this.groupBoxAction.Location = new System.Drawing.Point(12, 12);
            this.groupBoxAction.Name = "groupBoxAction";
            this.groupBoxAction.Size = new System.Drawing.Size(862, 100);
            this.groupBoxAction.TabIndex = 7;
            this.groupBoxAction.TabStop = false;
            this.groupBoxAction.Text = "Actions";
            // 
            // bt_save_repport
            // 
            this.bt_save_repport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_save_repport.Location = new System.Drawing.Point(106, 19);
            this.bt_save_repport.Name = "bt_save_repport";
            this.bt_save_repport.Size = new System.Drawing.Size(119, 75);
            this.bt_save_repport.TabIndex = 7;
            this.bt_save_repport.Text = "Enregistrer l\'état";
            this.bt_save_repport.UseVisualStyleBackColor = true;
            this.bt_save_repport.Click += new System.EventHandler(this.bt_save_repport_Click);
            // 
            // configurationFileDeviceControl1
            // 
            this.configurationFileDeviceControl1.Location = new System.Drawing.Point(23, 25);
            this.configurationFileDeviceControl1.Name = "configurationFileDeviceControl1";
            this.configurationFileDeviceControl1.Size = new System.Drawing.Size(77, 69);
            this.configurationFileDeviceControl1.TabIndex = 6;
            // 
            // repertoriesTP
            // 
            this.repertoriesTP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.repertoriesTP.Location = new System.Drawing.Point(3, 16);
            this.repertoriesTP.Name = "repertoriesTP";
            this.repertoriesTP.ParentFileData = null;
            this.repertoriesTP.Size = new System.Drawing.Size(233, 277);
            this.repertoriesTP.TabIndex = 0;
            // 
            // repertoriesTD
            // 
            this.repertoriesTD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.repertoriesTD.Location = new System.Drawing.Point(3, 16);
            this.repertoriesTD.Name = "repertoriesTD";
            this.repertoriesTD.ParentFileData = null;
            this.repertoriesTD.Size = new System.Drawing.Size(327, 278);
            this.repertoriesTD.TabIndex = 0;
            // 
            // repertoriesRoot
            // 
            this.repertoriesRoot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.repertoriesRoot.Location = new System.Drawing.Point(3, 16);
            this.repertoriesRoot.Name = "repertoriesRoot";
            this.repertoriesRoot.ParentFileData = null;
            this.repertoriesRoot.Size = new System.Drawing.Size(282, 278);
            this.repertoriesRoot.TabIndex = 0;
            // 
            // AppForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 439);
            this.Controls.Add(this.groupBoxAction);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBoxRepertories);
            this.Name = "AppForm";
            this.Text = "Suivi des TD et TP";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AppForm_Load);
            this.groupBoxRepertories.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBoxAction.ResumeLayout(false);
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
    }
}