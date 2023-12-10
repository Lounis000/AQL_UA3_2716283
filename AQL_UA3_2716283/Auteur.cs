using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace AQL_UA3_2716283
{
    public partial class Auteur : Form
    {

        public Auteur()
        {
            InitializeComponent();
          ;
        }

    
        private void AjouterAuteur_Click(object sender, EventArgs e)
        {
            // Code pour ouvrir le formulaire d'ajout d'auteur
            AjAuteur ajAuteurForm = new AjAuteur();
            ajAuteurForm.ShowDialog();
        }

        private void ModifierAuteur_Click(object sender, EventArgs e)
        {
            // Code pour ouvrir le formulaire de modification d'auteur
            ModAuteur modAuteurForm = new ModAuteur();
            modAuteurForm.Show();
        }

        private void AfficherAuteurs_Click(object sender, EventArgs e)
        {
            // Code pour ouvrir le formulaire d'affichage des auteurs
            AffAuteur affAuteurForm = new AffAuteur();
            affAuteurForm.Show();
        }

        private void SupprimerAuteur_Click(object sender, EventArgs e)
        {
            // Code pour ouvrir le formulaire de suppression d'auteur
            SupAuteur supAuteurForm = new SupAuteur();
            supAuteurForm.Show();
        }
                     
    }
}

