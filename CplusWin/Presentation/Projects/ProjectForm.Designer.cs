namespace App.Presentation.Projects
{
    partial class ProjectForm
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
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label descriptionLabel;
            System.Windows.Forms.Label dateModificationLabel;
            System.Windows.Forms.Label dateCreationLabel;
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.dateModificationDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dateCreationDateTimePicker = new System.Windows.Forms.DateTimePicker();
            nameLabel = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            dateModificationLabel = new System.Windows.Forms.Label();
            dateCreationLabel = new System.Windows.Forms.Label();
            this.groupBoxEntity.SuspendLayout();
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
            this.groupBoxEntity.Size = new System.Drawing.Size(621, 287);
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(15, 35);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(38, 13);
            nameLabel.TabIndex = 8;
            nameLabel.Text = "Name:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(114, 32);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(490, 20);
            this.nameTextBox.TabIndex = 9;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Location = new System.Drawing.Point(114, 58);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(490, 142);
            this.descriptionTextBox.TabIndex = 5;
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new System.Drawing.Point(15, 61);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(63, 13);
            descriptionLabel.TabIndex = 4;
            descriptionLabel.Text = "Description:";
            // 
            // dateModificationDateTimePicker
            // 
            this.dateModificationDateTimePicker.Enabled = false;
            this.dateModificationDateTimePicker.Location = new System.Drawing.Point(114, 234);
            this.dateModificationDateTimePicker.Name = "dateModificationDateTimePicker";
            this.dateModificationDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dateModificationDateTimePicker.TabIndex = 3;
            // 
            // dateModificationLabel
            // 
            dateModificationLabel.AutoSize = true;
            dateModificationLabel.Location = new System.Drawing.Point(15, 238);
            dateModificationLabel.Name = "dateModificationLabel";
            dateModificationLabel.Size = new System.Drawing.Size(93, 13);
            dateModificationLabel.TabIndex = 2;
            dateModificationLabel.Text = "Date Modification:";
            // 
            // dateCreationDateTimePicker
            // 
            this.dateCreationDateTimePicker.Enabled = false;
            this.dateCreationDateTimePicker.Location = new System.Drawing.Point(114, 208);
            this.dateCreationDateTimePicker.Name = "dateCreationDateTimePicker";
            this.dateCreationDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dateCreationDateTimePicker.TabIndex = 1;
            // 
            // dateCreationLabel
            // 
            dateCreationLabel.AutoSize = true;
            dateCreationLabel.Location = new System.Drawing.Point(15, 212);
            dateCreationLabel.Name = "dateCreationLabel";
            dateCreationLabel.Size = new System.Drawing.Size(75, 13);
            dateCreationLabel.TabIndex = 0;
            dateCreationLabel.Text = "Date Creation:";
            // 
            // ProjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "ProjectForm";
            this.Size = new System.Drawing.Size(621, 287);
            this.groupBoxEntity.ResumeLayout(false);
            this.groupBoxEntity.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateCreationDateTimePicker;
        private System.Windows.Forms.DateTimePicker dateModificationDateTimePicker;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
    }
}
