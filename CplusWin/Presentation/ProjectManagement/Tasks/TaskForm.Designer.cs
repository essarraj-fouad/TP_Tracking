namespace App.Presentation.Tasks
{
    partial class TaskForm
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
            System.Windows.Forms.Label dateCreationLabel;
            System.Windows.Forms.Label dateModificationLabel;
            System.Windows.Forms.Label descriptionLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label projectLabel;
            this.dateCreationDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dateModificationDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.projectComboBox = new System.Windows.Forms.ComboBox();
            this.taskBindingSource = new System.Windows.Forms.BindingSource(this.components);
            dateCreationLabel = new System.Windows.Forms.Label();
            dateModificationLabel = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            projectLabel = new System.Windows.Forms.Label();
            this.groupBoxEntity.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.taskBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxEntity
            // 
            this.groupBoxEntity.Controls.Add(dateCreationLabel);
            this.groupBoxEntity.Controls.Add(this.dateCreationDateTimePicker);
            this.groupBoxEntity.Controls.Add(dateModificationLabel);
            this.groupBoxEntity.Controls.Add(this.dateModificationDateTimePicker);
            this.groupBoxEntity.Controls.Add(descriptionLabel);
            this.groupBoxEntity.Controls.Add(this.descriptionTextBox);
            this.groupBoxEntity.Controls.Add(nameLabel);
            this.groupBoxEntity.Controls.Add(this.nameTextBox);
            this.groupBoxEntity.Controls.Add(projectLabel);
            this.groupBoxEntity.Controls.Add(this.projectComboBox);
            this.groupBoxEntity.Size = new System.Drawing.Size(706, 288);
            // 
            // dateCreationLabel
            // 
            dateCreationLabel.AutoSize = true;
            dateCreationLabel.Location = new System.Drawing.Point(16, 222);
            dateCreationLabel.Name = "dateCreationLabel";
            dateCreationLabel.Size = new System.Drawing.Size(75, 13);
            dateCreationLabel.TabIndex = 0;
            dateCreationLabel.Text = "Date Creation:";
            // 
            // dateCreationDateTimePicker
            // 
            this.dateCreationDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.taskBindingSource, "DateCreation", true));
            this.dateCreationDateTimePicker.Location = new System.Drawing.Point(115, 218);
            this.dateCreationDateTimePicker.Name = "dateCreationDateTimePicker";
            this.dateCreationDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dateCreationDateTimePicker.TabIndex = 1;
            // 
            // dateModificationLabel
            // 
            dateModificationLabel.AutoSize = true;
            dateModificationLabel.Location = new System.Drawing.Point(16, 248);
            dateModificationLabel.Name = "dateModificationLabel";
            dateModificationLabel.Size = new System.Drawing.Size(93, 13);
            dateModificationLabel.TabIndex = 2;
            dateModificationLabel.Text = "Date Modification:";
            // 
            // dateModificationDateTimePicker
            // 
            this.dateModificationDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.taskBindingSource, "DateModification", true));
            this.dateModificationDateTimePicker.Location = new System.Drawing.Point(115, 244);
            this.dateModificationDateTimePicker.Name = "dateModificationDateTimePicker";
            this.dateModificationDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dateModificationDateTimePicker.TabIndex = 3;
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new System.Drawing.Point(16, 82);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(63, 13);
            descriptionLabel.TabIndex = 4;
            descriptionLabel.Text = "Description:";
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.taskBindingSource, "Description", true));
            this.descriptionTextBox.Location = new System.Drawing.Point(115, 79);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(571, 133);
            this.descriptionTextBox.TabIndex = 5;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(16, 29);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(38, 13);
            nameLabel.TabIndex = 8;
            nameLabel.Text = "Name:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.taskBindingSource, "Name", true));
            this.nameTextBox.Location = new System.Drawing.Point(115, 26);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(571, 20);
            this.nameTextBox.TabIndex = 9;
            // 
            // projectLabel
            // 
            projectLabel.AutoSize = true;
            projectLabel.Location = new System.Drawing.Point(16, 55);
            projectLabel.Name = "projectLabel";
            projectLabel.Size = new System.Drawing.Size(43, 13);
            projectLabel.TabIndex = 12;
            projectLabel.Text = "Project:";
            // 
            // projectComboBox
            // 
            this.projectComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.taskBindingSource, "Project", true));
            this.projectComboBox.FormattingEnabled = true;
            this.projectComboBox.Location = new System.Drawing.Point(115, 52);
            this.projectComboBox.Name = "projectComboBox";
            this.projectComboBox.Size = new System.Drawing.Size(571, 21);
            this.projectComboBox.TabIndex = 13;
            // 
            // taskBindingSource
            // 
            this.taskBindingSource.DataSource = typeof(App.Entities.Task);
            // 
            // TaskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "TaskForm";
            this.Size = new System.Drawing.Size(706, 288);
            this.groupBoxEntity.ResumeLayout(false);
            this.groupBoxEntity.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.taskBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateCreationDateTimePicker;
        private System.Windows.Forms.BindingSource taskBindingSource;
        private System.Windows.Forms.DateTimePicker dateModificationDateTimePicker;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.ComboBox projectComboBox;
    }
}
