namespace TP_Tracking.Presentation.UI
{
    partial class ShowWorksByCategoriesControl
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageOrganisation = new System.Windows.Forms.TabPage();
            this.repertoriesRoot = new TP_Tracking.Presentation.UI.RepertoriesControl();
            this.tabControl1.SuspendLayout();
            this.tabPageOrganisation.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageOrganisation);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(471, 362);
            this.tabControl1.TabIndex = 10;
            // 
            // tabPageOrganisation
            // 
            this.tabPageOrganisation.Controls.Add(this.repertoriesRoot);
            this.tabPageOrganisation.Location = new System.Drawing.Point(4, 29);
            this.tabPageOrganisation.Name = "tabPageOrganisation";
            this.tabPageOrganisation.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageOrganisation.Size = new System.Drawing.Size(463, 329);
            this.tabPageOrganisation.TabIndex = 0;
            this.tabPageOrganisation.Text = "Organisation des répertoires";
            this.tabPageOrganisation.UseVisualStyleBackColor = true;
            // 
            // repertoriesRoot
            // 
            this.repertoriesRoot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.repertoriesRoot.Location = new System.Drawing.Point(3, 3);
            this.repertoriesRoot.Name = "repertoriesRoot";
            this.repertoriesRoot.ParentFileData = null;
            this.repertoriesRoot.Size = new System.Drawing.Size(457, 323);
            this.repertoriesRoot.TabIndex = 0;
            // 
            // ShowWorksByCategoriesControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.Name = "ShowWorksByCategoriesControl";
            this.Size = new System.Drawing.Size(471, 362);
            this.tabControl1.ResumeLayout(false);
            this.tabPageOrganisation.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageOrganisation;
        private RepertoriesControl repertoriesRoot;
    }
}
