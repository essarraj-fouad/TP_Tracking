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
            this.repertoriesControl1 = new TP_Tracking.Presentation.UI.RepertoriesControl();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBoxRepertories.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxRepertories
            // 
            this.groupBoxRepertories.Controls.Add(this.repertoriesControl1);
            this.groupBoxRepertories.Location = new System.Drawing.Point(12, 12);
            this.groupBoxRepertories.Name = "groupBoxRepertories";
            this.groupBoxRepertories.Size = new System.Drawing.Size(246, 257);
            this.groupBoxRepertories.TabIndex = 1;
            this.groupBoxRepertories.TabStop = false;
            this.groupBoxRepertories.Text = "Organisations des répertoires";
            // 
            // repertoriesControl1
            // 
            this.repertoriesControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.repertoriesControl1.Location = new System.Drawing.Point(3, 16);
            this.repertoriesControl1.Name = "repertoriesControl1";
            this.repertoriesControl1.Size = new System.Drawing.Size(240, 238);
            this.repertoriesControl1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(12, 275);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(246, 172);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Message d\'erreurs";
            // 
            // AppForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 459);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxRepertories);
            this.Name = "AppForm";
            this.Text = "Suivi des TD et TP";
            this.Load += new System.EventHandler(this.AppForm_Load);
            this.groupBoxRepertories.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBoxRepertories;
        private UI.RepertoriesControl repertoriesControl1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}