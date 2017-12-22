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
            this.repertoriesRoot = new TP_Tracking.Presentation.UI.RepertoriesControl();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.errorMessageControl = new TP_Tracking.Presentation.UI.ErrorMessageControl();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.repertoriesTD = new TP_Tracking.Presentation.UI.RepertoriesControl();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.repertoriesTP = new TP_Tracking.Presentation.UI.RepertoriesControl();
            this.bt_refresh = new System.Windows.Forms.Button();
            this.groupBoxRepertories.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxRepertories
            // 
            this.groupBoxRepertories.Controls.Add(this.repertoriesRoot);
            this.groupBoxRepertories.Location = new System.Drawing.Point(12, 12);
            this.groupBoxRepertories.Name = "groupBoxRepertories";
            this.groupBoxRepertories.Size = new System.Drawing.Size(354, 257);
            this.groupBoxRepertories.TabIndex = 1;
            this.groupBoxRepertories.TabStop = false;
            this.groupBoxRepertories.Text = "Organisations des répertoires";
            // 
            // repertoriesRoot
            // 
            this.repertoriesRoot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.repertoriesRoot.ListDirectory = null;
            this.repertoriesRoot.Location = new System.Drawing.Point(3, 16);
            this.repertoriesRoot.Name = "repertoriesRoot";
            this.repertoriesRoot.Size = new System.Drawing.Size(348, 238);
            this.repertoriesRoot.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.errorMessageControl);
            this.groupBox1.Location = new System.Drawing.Point(12, 275);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(357, 172);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Message d\'erreurs";
            // 
            // errorMessageControl
            // 
            this.errorMessageControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.errorMessageControl.Location = new System.Drawing.Point(3, 16);
            this.errorMessageControl.Name = "errorMessageControl";
            this.errorMessageControl.Size = new System.Drawing.Size(351, 153);
            this.errorMessageControl.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.repertoriesTD);
            this.groupBox2.Location = new System.Drawing.Point(730, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(315, 432);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "TD";
            // 
            // repertoriesTD
            // 
            this.repertoriesTD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.repertoriesTD.ListDirectory = null;
            this.repertoriesTD.Location = new System.Drawing.Point(3, 16);
            this.repertoriesTD.Name = "repertoriesTD";
            this.repertoriesTD.Size = new System.Drawing.Size(309, 413);
            this.repertoriesTD.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.repertoriesTP);
            this.groupBox3.Location = new System.Drawing.Point(375, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(349, 432);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "TP";
            // 
            // repertoriesTP
            // 
            this.repertoriesTP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.repertoriesTP.ListDirectory = null;
            this.repertoriesTP.Location = new System.Drawing.Point(3, 16);
            this.repertoriesTP.Name = "repertoriesTP";
            this.repertoriesTP.Size = new System.Drawing.Size(343, 413);
            this.repertoriesTP.TabIndex = 0;
            // 
            // bt_refresh
            // 
            this.bt_refresh.Location = new System.Drawing.Point(1051, 12);
            this.bt_refresh.Name = "bt_refresh";
            this.bt_refresh.Size = new System.Drawing.Size(75, 23);
            this.bt_refresh.TabIndex = 5;
            this.bt_refresh.Text = "Actualiser";
            this.bt_refresh.UseVisualStyleBackColor = true;
            this.bt_refresh.Click += new System.EventHandler(this.bt_refresh_Click);
            // 
            // AppForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1169, 459);
            this.Controls.Add(this.bt_refresh);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxRepertories);
            this.Name = "AppForm";
            this.Text = "Suivi des TD et TP";
            this.Load += new System.EventHandler(this.AppForm_Load);
            this.groupBoxRepertories.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBoxRepertories;
        private UI.RepertoriesControl repertoriesRoot;
        private System.Windows.Forms.GroupBox groupBox1;
        private UI.ErrorMessageControl errorMessageControl;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private UI.RepertoriesControl repertoriesTD;
        private UI.RepertoriesControl repertoriesTP;
        private System.Windows.Forms.Button bt_refresh;
    }
}