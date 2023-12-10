using System;
using System.Windows.Forms;

namespace AQL_UA3_2716283
{
    public partial class SupAuteur : Form
    {
        private TextBox txtAuteurId;
        private Button btnSupprimerAuteur;

        public SupAuteur()
        {
            InitializeComponent(); // Appeler la méthode d'initialisation des composants
        }
        private void InitializeComponent()
        {
            // Initialiser les composants UI
            txtAuteurId = new TextBox();
            btnSupprimerAuteur = new Button();

            // Configurer le TextBox pour l'ID de l'auteur
            txtAuteurId.Location = new System.Drawing.Point(10, 10);
            this.Controls.Add(txtAuteurId);

            // Configurer le bouton Supprimer Auteur
            btnSupprimerAuteur.Text = "Supprimer Auteur";
            btnSupprimerAuteur.Location = new System.Drawing.Point(10, 40);
            btnSupprimerAuteur.Click += BtnSupprimerAuteur_Click;
            this.Controls.Add(btnSupprimerAuteur);
        }
        private void BtnSupprimerAuteur_Click(object sender, EventArgs e)
        {
            // Récupérer l'ID de l'auteur à supprimer
            if (int.TryParse(txtAuteurId.Text, out int auteurIdASupprimer))
            {
                // Appeler la méthode de suppression de l'auteur dans la classe DataManage
                DataManage.SupprimerAuteur(auteurIdASupprimer);

                // Rafraîchir l'affichage des auteurs après la suppression
                RafraichirListeAuteurs();

                // Afficher un message de succès
                MessageBox.Show("Auteur supprimé avec succès !");
            }
            else
            {
                // Gérer le cas où l'utilisateur n'a pas saisi un nombre valide
                MessageBox.Show("Veuillez saisir un ID d'auteur valide.");
            }
        }
        private void RafraichirListeAuteurs()
        {
        }
    }
}
