namespace TP_Tracking.Presentation.UI
{
    partial class ErrorMessageControl
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
            this.listBoxErrorMessage = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // listBoxErrorMessage
            // 
            this.listBoxErrorMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxErrorMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxErrorMessage.ForeColor = System.Drawing.Color.Maroon;
            this.listBoxErrorMessage.ItemHeight = 20;
            this.listBoxErrorMessage.Location = new System.Drawing.Point(0, 0);
            this.listBoxErrorMessage.Name = "listBoxErrorMessage";
            this.listBoxErrorMessage.Size = new System.Drawing.Size(253, 258);
            this.listBoxErrorMessage.TabIndex = 0;
            // 
            // ErrorMessageControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.listBoxErrorMessage);
            this.Name = "ErrorMessageControl";
            this.Size = new System.Drawing.Size(253, 258);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxErrorMessage;
    }
}
