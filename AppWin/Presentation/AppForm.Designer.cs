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
            this.bt_refresh = new System.Windows.Forms.Button();
            this.groupBoxAction = new System.Windows.Forms.GroupBox();
            this.bt_save_repport = new System.Windows.Forms.Button();
            this.configurationFileDeviceControl1 = new TP_Tracking.Presentation.UI.ConfigurationFileDeviceControl();
            this.showWorksByCategoriesControl1 = new TP_Tracking.Presentation.UI.ShowWorksByCategoriesControl();
            this.bt_edit_profile = new System.Windows.Forms.Button();
            this.groupBoxAction.SuspendLayout();
            this.SuspendLayout();
            // 
            // bt_refresh
            // 
            this.bt_refresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_refresh.Location = new System.Drawing.Point(443, 19);
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
            this.groupBoxAction.Controls.Add(this.bt_edit_profile);
            this.groupBoxAction.Controls.Add(this.bt_save_repport);
            this.groupBoxAction.Controls.Add(this.configurationFileDeviceControl1);
            this.groupBoxAction.Controls.Add(this.bt_refresh);
            this.groupBoxAction.Location = new System.Drawing.Point(12, 12);
            this.groupBoxAction.Name = "groupBoxAction";
            this.groupBoxAction.Size = new System.Drawing.Size(569, 100);
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
            // configurationFileDeviceControl1
            // 
            this.configurationFileDeviceControl1.Location = new System.Drawing.Point(23, 25);
            this.configurationFileDeviceControl1.Name = "configurationFileDeviceControl1";
            this.configurationFileDeviceControl1.Size = new System.Drawing.Size(77, 69);
            this.configurationFileDeviceControl1.TabIndex = 6;
            // 
            // showWorksByCategoriesControl1
            // 
            this.showWorksByCategoriesControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.showWorksByCategoriesControl1.Location = new System.Drawing.Point(12, 118);
            this.showWorksByCategoriesControl1.Name = "showWorksByCategoriesControl1";
            this.showWorksByCategoriesControl1.Size = new System.Drawing.Size(563, 241);
            this.showWorksByCategoriesControl1.TabIndex = 10;
            // 
            // bt_edit_profile
            // 
            this.bt_edit_profile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_edit_profile.Location = new System.Drawing.Point(317, 19);
            this.bt_edit_profile.Name = "bt_edit_profile";
            this.bt_edit_profile.Size = new System.Drawing.Size(120, 69);
            this.bt_edit_profile.TabIndex = 8;
            this.bt_edit_profile.Text = "Editer profile";
            this.bt_edit_profile.UseVisualStyleBackColor = true;
            this.bt_edit_profile.Click += new System.EventHandler(this.bt_edit_profile_Click);
            // 
            // AppForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 371);
            this.Controls.Add(this.showWorksByCategoriesControl1);
            this.Controls.Add(this.groupBoxAction);
            this.MinimumSize = new System.Drawing.Size(600, 400);
            this.Name = "AppForm";
            this.Text = "Suivi des TD et TP";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AppForm_Load);
            this.groupBoxAction.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button bt_refresh;
        private UI.ConfigurationFileDeviceControl configurationFileDeviceControl1;
        private System.Windows.Forms.GroupBox groupBoxAction;
        private System.Windows.Forms.Button bt_save_repport;
        private UI.ShowWorksByCategoriesControl showWorksByCategoriesControl1;
        private System.Windows.Forms.Button bt_edit_profile;
    }
}