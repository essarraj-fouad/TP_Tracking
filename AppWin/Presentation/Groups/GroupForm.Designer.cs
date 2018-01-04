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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label descriptionLabel;
            System.Windows.Forms.Label specialtyLabel;
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.specialtyComboBox = new System.Windows.Forms.ComboBox();
            this.specialtyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            nameLabel = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            specialtyLabel = new System.Windows.Forms.Label();
            this.groupBoxEntity.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.specialtyBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxEntity
            // 
            this.groupBoxEntity.Controls.Add(specialtyLabel);
            this.groupBoxEntity.Controls.Add(this.specialtyComboBox);
            this.groupBoxEntity.Controls.Add(descriptionLabel);
            this.groupBoxEntity.Controls.Add(this.descriptionTextBox);
            this.groupBoxEntity.Controls.Add(nameLabel);
            this.groupBoxEntity.Controls.Add(this.nameTextBox);
            this.groupBoxEntity.Size = new System.Drawing.Size(397, 201);
            this.groupBoxEntity.Text = "Group";
            this.groupBoxEntity.Enter += new System.EventHandler(this.groupBoxEntity_Enter);
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
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new System.Drawing.Point(15, 84);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(63, 13);
            descriptionLabel.TabIndex = 2;
            descriptionLabel.Text = "Description:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(84, 28);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 20);
            this.nameTextBox.TabIndex = 1;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Location = new System.Drawing.Point(84, 81);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(298, 99);
            this.descriptionTextBox.TabIndex = 3;
            // 
            // specialtyLabel
            // 
            specialtyLabel.AutoSize = true;
            specialtyLabel.Location = new System.Drawing.Point(25, 58);
            specialtyLabel.Name = "specialtyLabel";
            specialtyLabel.Size = new System.Drawing.Size(53, 13);
            specialtyLabel.TabIndex = 4;
            specialtyLabel.Text = "Specialty:";
            // 
            // specialtyComboBox
            // 
            this.specialtyComboBox.DataSource = this.specialtyBindingSource;
            this.specialtyComboBox.DisplayMember = "Name";
            this.specialtyComboBox.FormattingEnabled = true;
            this.specialtyComboBox.Location = new System.Drawing.Point(84, 55);
            this.specialtyComboBox.Name = "specialtyComboBox";
            this.specialtyComboBox.Size = new System.Drawing.Size(121, 21);
            this.specialtyComboBox.TabIndex = 5;
            this.specialtyComboBox.ValueMember = "Id";
            // 
            // specialtyBindingSource
            // 
            this.specialtyBindingSource.DataSource = typeof(TP_Tracking.Entities.Specialty);
            // 
            // GroupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "GroupForm";
            this.Size = new System.Drawing.Size(397, 201);
            this.Title = "Group";
            this.groupBoxEntity.ResumeLayout(false);
            this.groupBoxEntity.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.specialtyBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.ComboBox specialtyComboBox;
        private System.Windows.Forms.BindingSource specialtyBindingSource;
    }
}
