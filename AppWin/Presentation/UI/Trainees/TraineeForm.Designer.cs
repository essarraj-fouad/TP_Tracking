﻿namespace TP_Tracking.Presentation.UI.Trainees
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
            System.Windows.Forms.Label dateOfBirthLabel;
            System.Windows.Forms.Label firstNameLabel;
            System.Windows.Forms.Label lastNameLabel;
            System.Windows.Forms.Label lbl_tel;
            this.dateOfBirthDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            dateOfBirthLabel = new System.Windows.Forms.Label();
            firstNameLabel = new System.Windows.Forms.Label();
            lastNameLabel = new System.Windows.Forms.Label();
            lbl_tel = new System.Windows.Forms.Label();
            this.groupBoxEntity.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxEntity
            // 
            this.groupBoxEntity.Controls.Add(this.txtPhoneNumber);
            this.groupBoxEntity.Controls.Add(lbl_tel);
            this.groupBoxEntity.Controls.Add(dateOfBirthLabel);
            this.groupBoxEntity.Controls.Add(this.dateOfBirthDateTimePicker);
            this.groupBoxEntity.Controls.Add(firstNameLabel);
            this.groupBoxEntity.Controls.Add(this.firstNameTextBox);
            this.groupBoxEntity.Controls.Add(lastNameLabel);
            this.groupBoxEntity.Controls.Add(this.lastNameTextBox);
            this.groupBoxEntity.Size = new System.Drawing.Size(332, 147);
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
            // lbl_tel
            // 
            lbl_tel.AutoSize = true;
            lbl_tel.Location = new System.Drawing.Point(13, 112);
            lbl_tel.Name = "lbl_tel";
            lbl_tel.Size = new System.Drawing.Size(28, 13);
            lbl_tel.TabIndex = 6;
            lbl_tel.Text = "Tél :";
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(103, 109);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(200, 20);
            this.txtPhoneNumber.TabIndex = 7;
            // 
            // TraineeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "TraineeForm";
            this.Size = new System.Drawing.Size(332, 147);
            this.Title = "Stagiaire";
            this.groupBoxEntity.ResumeLayout(false);
            this.groupBoxEntity.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateOfBirthDateTimePicker;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox txtPhoneNumber;
    }
}
