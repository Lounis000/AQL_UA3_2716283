
using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;
using System.Xml.Linq;

namespace AQL_UA3_2716283
{
    partial class AjAuteur
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
            lblNom = new Label();
            lblPrenom = new Label();
            lblDateNaissance = new Label();
            txtNom = new TextBox();
            txtPrenom = new TextBox();
            dtpDateNaissance = new DateTimePicker();
            btnAjouterAuteur = new Button();
            SuspendLayout();
            // 
            // lblNom
            // 
            lblNom.AutoSize = true;
            lblNom.Location = new Point(50, 50);
            lblNom.Name = "lblNom";
            lblNom.Size = new Size(43, 15);
            lblNom.TabIndex = 0;
            lblNom.Text = "Nom : ";
            // 
            // lblPrenom
            // 
            lblPrenom.AutoSize = true;
            lblPrenom.Location = new Point(50, 100);
            lblPrenom.Name = "lblPrenom";
            lblPrenom.Size = new Size(58, 15);
            lblPrenom.TabIndex = 2;
            lblPrenom.Text = "Prénom : ";
            // 
            // lblDateNaissance
            // 
            lblDateNaissance.AutoSize = true;
            lblDateNaissance.Location = new Point(50, 150);
            lblDateNaissance.Name = "lblDateNaissance";
            lblDateNaissance.Size = new Size(112, 15);
            lblDateNaissance.TabIndex = 4;
            lblDateNaissance.Text = "Date de Naissance : ";
            // 
            // txtNom
            // 
            txtNom.Location = new Point(150, 50);
            txtNom.Name = "txtNom";
            txtNom.Size = new Size(100, 23);
            txtNom.TabIndex = 1;
            // 
            // txtPrenom
            // 
            txtPrenom.Location = new Point(150, 100);
            txtPrenom.Name = "txtPrenom";
            txtPrenom.Size = new Size(100, 23);
            txtPrenom.TabIndex = 3;
            // 
            // dtpDateNaissance
            // 
            dtpDateNaissance.Location = new Point(181, 144);
            dtpDateNaissance.Name = "dtpDateNaissance";
            dtpDateNaissance.Size = new Size(200, 23);
            dtpDateNaissance.TabIndex = 5;
            dtpDateNaissance.ValueChanged += dtpDateNaissance_ValueChanged;
            // 
            // btnAjouterAuteur
            // 
            btnAjouterAuteur.Location = new Point(100, 200);
            btnAjouterAuteur.Name = "btnAjouterAuteur";
            btnAjouterAuteur.Size = new Size(150, 30);
            btnAjouterAuteur.TabIndex = 6;
            btnAjouterAuteur.Text = "Ajouter l'Auteur";
            btnAjouterAuteur.Click += btnAjouterAuteur_Click;
            // 
            // AjAuteur
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(586, 275);
            Controls.Add(lblNom);
            Controls.Add(txtNom);
            Controls.Add(lblPrenom);
            Controls.Add(txtPrenom);
            Controls.Add(lblDateNaissance);
            Controls.Add(dtpDateNaissance);
            Controls.Add(btnAjouterAuteur);
            Name = "AjAuteur";
            Text = "Ajouter un Auteur";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNom;
        private Label lblPrenom;
        private Label lblDateNaissance;
        private TextBox txtNom;
        private TextBox txtPrenom;
        private DateTimePicker dtpDateNaissance;
        private Button btnAjouterAuteur;
    }
}
