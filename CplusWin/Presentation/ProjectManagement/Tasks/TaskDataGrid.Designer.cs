namespace App.Presentation.Tasks
{
    partial class TaskDataGrid
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
            this.taskDataGridView = new System.Windows.Forms.DataGridView();
            this.taskBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxEntities.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.taskDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.taskBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // GwinDataGridNavigator
            // 
            this.GwinDataGridNavigator.Size = new System.Drawing.Size(1048, 63);
            // 
            // groupBoxEntities
            // 
            this.groupBoxEntities.Size = new System.Drawing.Size(1054, 361);
            // 
            // splitContainer1
            // 
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.AutoScroll = true;
            this.splitContainer1.Panel1.Controls.Add(this.taskDataGridView);
            this.splitContainer1.Size = new System.Drawing.Size(1048, 342);
            this.splitContainer1.SplitterDistance = 275;
            // 
            // taskDataGridView
            // 
            this.taskDataGridView.AutoGenerateColumns = false;
            this.taskDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.taskDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn8});
            this.taskDataGridView.DataSource = this.taskBindingSource;
            this.taskDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.taskDataGridView.Location = new System.Drawing.Point(0, 0);
            this.taskDataGridView.Name = "taskDataGridView";
            this.taskDataGridView.Size = new System.Drawing.Size(1048, 275);
            this.taskDataGridView.TabIndex = 0;
            // 
            // taskBindingSource
            // 
            this.taskBindingSource.DataSource = typeof(App.Entities.Task);
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 500;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Project";
            this.dataGridViewTextBoxColumn1.HeaderText = "Project";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 400;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "DateModification";
            this.dataGridViewTextBoxColumn8.HeaderText = "DateModification";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // TaskDataGrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BindingSource = this.taskBindingSource;
            this.DataGridViewEntity = this.taskDataGridView;
            this.Name = "TaskDataGrid";
            this.Size = new System.Drawing.Size(1054, 361);
            this.groupBoxEntities.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.taskDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.taskBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView taskDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.BindingSource taskBindingSource;
    }
}
