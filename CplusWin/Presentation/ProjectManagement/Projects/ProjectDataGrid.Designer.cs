namespace App.Presentation.Projects
{
    partial class ProjectDataGrid
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
            this.components = new System.ComponentModel.Container();
            this.projectDataGridView = new System.Windows.Forms.DataGridView();
            this.projectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxEntities.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.projectDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // GwinDataGridNavigator
            // 
            this.GwinDataGridNavigator.Size = new System.Drawing.Size(816, 65);
            // 
            // groupBoxEntities
            // 
            this.groupBoxEntities.Size = new System.Drawing.Size(822, 368);
            // 
            // splitContainer1
            // 
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.AutoScroll = true;
            this.splitContainer1.Panel1.Controls.Add(this.projectDataGridView);
            this.splitContainer1.Size = new System.Drawing.Size(816, 349);
            this.splitContainer1.SplitterDistance = 280;
            // 
            // projectDataGridView
            // 
            this.projectDataGridView.AutoGenerateColumns = false;
            this.projectDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.projectDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn7});
            this.projectDataGridView.DataSource = this.projectBindingSource;
            this.projectDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.projectDataGridView.Location = new System.Drawing.Point(0, 0);
            this.projectDataGridView.Name = "projectDataGridView";
            this.projectDataGridView.Size = new System.Drawing.Size(816, 280);
            this.projectDataGridView.TabIndex = 0;
            // 
            // projectBindingSource
            // 
            this.projectBindingSource.DataSource = typeof(App.Entities.Project);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn1.HeaderText = "Name";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 300;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Description";
            this.dataGridViewTextBoxColumn2.HeaderText = "Description";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 300;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "DateModification";
            this.dataGridViewTextBoxColumn7.HeaderText = "DateModification";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 150;
            // 
            // ProjectDataGrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BindingSource = this.projectBindingSource;
            this.DataGridViewEntity = this.projectDataGridView;
            this.Name = "ProjectDataGrid";
            this.Size = new System.Drawing.Size(822, 368);
            this.groupBoxEntities.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.projectDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView projectDataGridView;
        private System.Windows.Forms.BindingSource projectBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
    }
}
