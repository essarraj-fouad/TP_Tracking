namespace TP_Tracking.Presentation.UI.Trainees
{
    partial class TraineeUpdate
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
            this.traineeForm1 = new TP_Tracking.Presentation.UI.Trainees.TraineeForm();
            this.buttonSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // traineeForm1
            // 
            this.traineeForm1.Location = new System.Drawing.Point(3, 3);
            this.traineeForm1.Name = "traineeForm1";
            this.traineeForm1.Size = new System.Drawing.Size(324, 128);
            this.traineeForm1.TabIndex = 0;
            this.traineeForm1.Title = "Stagiaire";
            this.traineeForm1.Value = null;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(3, 137);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 1;
            this.buttonSave.Text = "Enregistrer";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // TraineeUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.traineeForm1);
            this.Name = "TraineeUpdate";
            this.Size = new System.Drawing.Size(352, 167);
            this.ResumeLayout(false);

        }

        #endregion

        private TraineeForm traineeForm1;
        private System.Windows.Forms.Button buttonSave;
    }
}
