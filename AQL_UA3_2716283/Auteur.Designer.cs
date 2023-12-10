// Auteur.Designer.cs
namespace AQL_UA3_2716283
{
    partial class Auteur
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.btnAjouterAuteur = new System.Windows.Forms.Button();
            this.btnModifierAuteur = new System.Windows.Forms.Button();
            this.btnAfficherAuteurs = new System.Windows.Forms.Button();
            this.btnSupprimerAuteur = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // btnAjouterAuteur
            this.btnAjouterAuteur.Location = new System.Drawing.Point(293, 95);
            this.btnAjouterAuteur.Name = "btnAjouterAuteur";
            this.btnAjouterAuteur.Size = new System.Drawing.Size(200, 44);
            this.btnAjouterAuteur.TabIndex = 0;
            this.btnAjouterAuteur.Text = "Ajouter Un Auteur";
            this.btnAjouterAuteur.UseVisualStyleBackColor = true;
            this.btnAjouterAuteur.Click += AjouterAuteur_Click;

            // btnModifierAuteur
            this.btnModifierAuteur.Location = new System.Drawing.Point(293, 145);
            this.btnModifierAuteur.Name = "btnModifierAuteur";
            this.btnModifierAuteur.Size = new System.Drawing.Size(200, 44);
            this.btnModifierAuteur.TabIndex = 1;
            this.btnModifierAuteur.Text = "Modifier Un Auteur";
            this.btnModifierAuteur.UseVisualStyleBackColor = true;
            this.btnModifierAuteur.Click += ModifierAuteur_Click;

            // btnAfficherAuteurs
            this.btnAfficherAuteurs.Location = new System.Drawing.Point(293, 195);
            this.btnAfficherAuteurs.Name = "btnAfficherAuteurs";
            this.btnAfficherAuteurs.Size = new System.Drawing.Size(200, 44);
            this.btnAfficherAuteurs.TabIndex = 2;
            this.btnAfficherAuteurs.Text = "Afficher les auteurs";
            this.btnAfficherAuteurs.UseVisualStyleBackColor = true;
            this.btnAfficherAuteurs.Click += AfficherAuteurs_Click;

            // btnSupprimerAuteur
            this.btnSupprimerAuteur.Location = new System.Drawing.Point(293, 245);
            this.btnSupprimerAuteur.Name = "btnSupprimerAuteur";
            this.btnSupprimerAuteur.Size = new System.Drawing.Size(200, 44);
            this.btnSupprimerAuteur.TabIndex = 3;
            this.btnSupprimerAuteur.Text = "Supprimer Un Auteur";
            this.btnSupprimerAuteur.UseVisualStyleBackColor = true;
            this.btnSupprimerAuteur.Click += SupprimerAuteur_Click;

            // Auteur
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSupprimerAuteur);
            this.Controls.Add(this.btnAfficherAuteurs);
            this.Controls.Add(this.btnModifierAuteur);
            this.Controls.Add(this.btnAjouterAuteur);
            this.Name = "Auteur";
            this.Text = "Auteur";
            this.ResumeLayout(false);
        }

        

        #endregion

        private System.Windows.Forms.Button btnAjouterAuteur;
        private System.Windows.Forms.Button btnModifierAuteur;
        private System.Windows.Forms.Button btnAfficherAuteurs;
        private System.Windows.Forms.Button btnSupprimerAuteur;
    }
}
