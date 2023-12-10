namespace AQL_UA3_2716283
{
    public partial class SupAuteur : Form
    {
    

        private void InitializeUI()
        {
            // Mise en place des composants visuels
            this.Text = "Supprimer un Auteur";
            this.Size = new System.Drawing.Size(400, 200);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.StartPosition = FormStartPosition.CenterScreen;

            Label lblAuteurId = new Label();
            lblAuteurId.Text = "ID de l'Auteur :";
            lblAuteurId.Location = new System.Drawing.Point(20, 20);

            TextBox txtAuteurId = new TextBox();
            txtAuteurId.Location = new System.Drawing.Point(150, 20);
            txtAuteurId.Width = 150;

            Button btnSupprimerAuteur = new Button();
            btnSupprimerAuteur.Text = "Supprimer l'Auteur";
            btnSupprimerAuteur.Location = new System.Drawing.Point(150, 60);
            btnSupprimerAuteur.Click += BtnSupprimerAuteur_Click;

            // Ajout des contrôles au formulaire
            this.Controls.Add(lblAuteurId);
            this.Controls.Add(txtAuteurId);
            this.Controls.Add(btnSupprimerAuteur);
        }

       
    }
}
