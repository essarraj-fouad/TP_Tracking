namespace TP_Tracking.Presentation.UI.Trainees
{
    partial class TraineeForm
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
            System.Windows.Forms.Label dateOfBirthLabel;
            System.Windows.Forms.Label firstNameLabel;
            System.Windows.Forms.Label lastNameLabel;
            System.Windows.Forms.Label lbl_tel;
            System.Windows.Forms.Label groupLabel;
            this.dateOfBirthDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.traineeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupComboBox = new System.Windows.Forms.ComboBox();
            dateOfBirthLabel = new System.Windows.Forms.Label();
            firstNameLabel = new System.Windows.Forms.Label();
            lastNameLabel = new System.Windows.Forms.Label();
            lbl_tel = new System.Windows.Forms.Label();
            groupLabel = new System.Windows.Forms.Label();
            this.groupBoxEntity.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.traineeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxEntity
            // 
            this.groupBoxEntity.Controls.Add(groupLabel);
            this.groupBoxEntity.Controls.Add(this.groupComboBox);
            this.groupBoxEntity.Controls.Add(this.txtPhoneNumber);
            this.groupBoxEntity.Controls.Add(lbl_tel);
            this.groupBoxEntity.Controls.Add(dateOfBirthLabel);
            this.groupBoxEntity.Controls.Add(this.dateOfBirthDateTimePicker);
            this.groupBoxEntity.Controls.Add(firstNameLabel);
            this.groupBoxEntity.Controls.Add(this.firstNameTextBox);
            this.groupBoxEntity.Controls.Add(lastNameLabel);
            this.groupBoxEntity.Controls.Add(this.lastNameTextBox);
            this.groupBoxEntity.Size = new System.Drawing.Size(339, 195);
            this.groupBoxEntity.Text = "Stagiaire";
            // 
            // dateOfBirthLabel
            // 
            dateOfBirthLabel.AutoSize = true;
            dateOfBirthLabel.Location = new System.Drawing.Point(13, 80);
            dateOfBirthLabel.Name = "dateOfBirthLabel";
            dateOfBirthLabel.Size = new System.Drawing.Size(84, 13);
            dateOfBirthLabel.TabIndex = 0;
            dateOfBirthLabel.Text = "Date naissance:";
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Location = new System.Drawing.Point(13, 27);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new System.Drawing.Size(32, 13);
            firstNameLabel.TabIndex = 2;
            firstNameLabel.Text = "Nom:";
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Location = new System.Drawing.Point(13, 53);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new System.Drawing.Size(46, 13);
            lastNameLabel.TabIndex = 4;
            lastNameLabel.Text = "Prénom:";
            // 
            // lbl_tel
            // 
            lbl_tel.AutoSize = true;
            lbl_tel.Location = new System.Drawing.Point(13, 112);
            lbl_tel.Name = "lbl_tel";
            lbl_tel.Size = new System.Drawing.Size(28, 13);
            lbl_tel.TabIndex = 6;
            lbl_tel.Text = "Tél :";
            // 
            // dateOfBirthDateTimePicker
            // 
            this.dateOfBirthDateTimePicker.Location = new System.Drawing.Point(103, 76);
            this.dateOfBirthDateTimePicker.Name = "dateOfBirthDateTimePicker";
            this.dateOfBirthDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dateOfBirthDateTimePicker.TabIndex = 1;
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(103, 24);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(200, 20);
            this.firstNameTextBox.TabIndex = 3;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(103, 50);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(200, 20);
            this.lastNameTextBox.TabIndex = 5;
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(103, 109);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(200, 20);
            this.txtPhoneNumber.TabIndex = 7;
            // 
            // traineeBindingSource
            // 
            this.traineeBindingSource.DataSource = typeof(TP_Tracking.Entities.Trainee);
            // 
            // groupLabel
            // 
            groupLabel.AutoSize = true;
            groupLabel.Location = new System.Drawing.Point(58, 147);
            groupLabel.Name = "groupLabel";
            groupLabel.Size = new System.Drawing.Size(39, 13);
            groupLabel.TabIndex = 8;
            groupLabel.Text = "Group:";
            // 
            // groupComboBox
            // 
            this.groupComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.traineeBindingSource, "Group", true));
            this.groupComboBox.FormattingEnabled = true;
            this.groupComboBox.Location = new System.Drawing.Point(103, 144);
            this.groupComboBox.Name = "groupComboBox";
            this.groupComboBox.Size = new System.Drawing.Size(121, 21);
            this.groupComboBox.TabIndex = 9;
            // 
            // TraineeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "TraineeForm";
            this.Size = new System.Drawing.Size(339, 195);
            this.Title = "Stagiaire";
            this.groupBoxEntity.ResumeLayout(false);
            this.groupBoxEntity.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.traineeBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateOfBirthDateTimePicker;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.ComboBox groupComboBox;
        private System.Windows.Forms.BindingSource traineeBindingSource;
    }
}
