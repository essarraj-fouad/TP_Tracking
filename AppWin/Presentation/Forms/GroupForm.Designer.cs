namespace TP_Tracking.Presentation.Forms
{
    partial class GroupForm
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
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            nameLabel = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            this.groupBoxEntity.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxEntity
            // 
            this.groupBoxEntity.Controls.Add(descriptionLabel);
            this.groupBoxEntity.Controls.Add(this.descriptionTextBox);
            this.groupBoxEntity.Controls.Add(nameLabel);
            this.groupBoxEntity.Controls.Add(this.nameTextBox);
            this.groupBoxEntity.Size = new System.Drawing.Size(393, 176);
            this.groupBoxEntity.Text = "Group";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(40, 31);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(38, 13);
            nameLabel.TabIndex = 0;
            nameLabel.Text = "Name:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(84, 28);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 20);
            this.nameTextBox.TabIndex = 1;
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new System.Drawing.Point(15, 58);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(63, 13);
            descriptionLabel.TabIndex = 2;
            descriptionLabel.Text = "Description:";
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Location = new System.Drawing.Point(84, 55);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(298, 99);
            this.descriptionTextBox.TabIndex = 3;
            // 
            // GroupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "GroupForm";
            this.Size = new System.Drawing.Size(393, 176);
            this.Title = "Group";
            this.groupBoxEntity.ResumeLayout(false);
            this.groupBoxEntity.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox descriptionTextBox;
    }
}
