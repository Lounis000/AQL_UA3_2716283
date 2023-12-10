using System;
using System.Windows.Forms;

namespace AQL_UA3_2716283
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Ici, tu pourrais initialiser des choses si nécessaire lors du chargement du formulaire principal
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Bouton Livres
            Livre livresForm = new Livre();
            livresForm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Bouton Auteurs
            Auteur auteursForm = new Auteur();
            auteursForm.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Bouton Emprunts
            Emprunt empruntsForm = new Emprunt();
            empruntsForm.ShowDialog();
        }
    }
}
