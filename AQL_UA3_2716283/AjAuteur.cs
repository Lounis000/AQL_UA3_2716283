using System;
using System.Windows.Forms;

namespace AQL_UA3_2716283
{
    public partial class AjAuteur : Form
    {
        public AjAuteur()
        {
            InitializeComponent();
        }

        private void btnAjouterAuteur_Click(object sender, EventArgs e)
        {
            // Récupère les données du formulaire
            string nom = txtNom.Text;
            string prenom = txtPrenom.Text;
            DateTime dateNaissance = dtpDateNaissance.Value;

            // Utilise la classe DataManage pour ajouter l'auteur à la base de données
            DataManage.AjouterAuteur(nom, prenom, dateNaissance);

            // Exemple de message
            MessageBox.Show($"Auteur ajouté:\nNom: {nom}\nPrénom: {prenom}\nDate de Naissance: {dateNaissance.ToShortDateString()}");

            // Ferme le formulaire après l'ajout
            this.Close();
        }

        private void dtpDateNaissance_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
