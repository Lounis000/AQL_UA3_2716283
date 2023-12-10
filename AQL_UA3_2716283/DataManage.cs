using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace AQL_UA3_2716283
{
    internal class DataManage
    {
        private static string connectionString = "Data Source = DataManagem.db;Version=3;";

        public static void AjouterLivre(string isbn, string titre, int auteurId, int anneePublication, string genre)
        {
            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();

                    // Insérer le livre dans la table Books
                    string query = "INSERT INTO Books (ISBN, Title, AuthorId, PublicationYear, Genre) " +
                                   $"VALUES ('{isbn}', '{titre}', {auteurId}, {anneePublication}, '{genre}')";
                    using (SQLiteCommand command = new SQLiteCommand(query, connection))
                    {
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de l'ajout du livre : {ex.Message}");
            }
        }

        public static void ModifierLivre(int livreId, string isbn, string titre, int auteurId, int anneePublication, string genre)
        {
            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();

                    // Modifier le livre dans la table Books
                    string query = $"UPDATE Books SET ISBN = '{isbn}', Title = '{titre}', AuthorId = {auteurId}, " +
                                   $"PublicationYear = {anneePublication}, Genre = '{genre}' WHERE Id = {livreId}";
                    using (SQLiteCommand command = new SQLiteCommand(query, connection))
                    {
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de la modification du livre : {ex.Message}");
            }
        }

        public static void SupprimerLivre(int livreId)
        {
            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();

                    // Supprimer le livre de la table Books
                    string query = $"DELETE FROM Books WHERE Id = {livreId}";
                    using (SQLiteCommand command = new SQLiteCommand(query, connection))
                    {
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de la suppression du livre : {ex.Message}");
            }
        }
        private static Author ObtenirAuteurParId(int authorId)
        {
            Author auteur = null;
            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();

                    string query = $"SELECT * FROM Authors WHERE AuthorID = {authorId}";
                    using (SQLiteCommand command = new SQLiteCommand(query, connection))
                    {
                        using (SQLiteDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                auteur = ObtenirAuteurParId(Convert.ToInt32(reader["AuthorID"]));
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de la récupération de l'auteur : {ex.Message}");
            }

            return auteur;
        }


        public static List<Book> ObtenirLivres()
{
    List<Book> livres = new List<Book>();
    try
    {
        string connectionString = "Data Source=database.db;Version=3;";
        using (SQLiteConnection connection = new SQLiteConnection(connectionString))
        {
            connection.Open();

            // Récupérer tous les livres de la table Books
            string query = "SELECT * FROM Books";
            using (SQLiteCommand command = new SQLiteCommand(query, connection))
            {
                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int authorId = Convert.ToInt32(reader["AuthorId"]);

                        // Obtenir l'auteur associé au livre
                        Author author = ObtenirAuteurParId(authorId);

                        Book livre = new Book()
                        {
                            ISBN = Convert.ToString(reader["ISBN"]),
                            Title = Convert.ToString(reader["Title"]),
                            Author = author,
                            PublicationYear = int.Parse(Convert.ToString(reader["PublicationYear"])),
                            Genre = Convert.ToString(reader["Genre"])
                        };
                        livres.Add(livre);
                    }
                }
            }
        }
    }
    catch (Exception ex)
    {
        MessageBox.Show($"Erreur lors de la récupération des livres : {ex.Message}");
    }

    return livres;
}


        public static void AjouterAuteur(string nom, string prenom, DateTime dateNaissance)
        {
            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();

                    string query = "INSERT INTO Authors (LastName, FirstName, DateOfBirth) " +
                                   $"VALUES ('{nom}', '{prenom}', '{dateNaissance.ToString("yyyy-MM-dd")}')";
                    using (SQLiteCommand command = new SQLiteCommand(query, connection))
                    {
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
               // MessageBox.Show($"Erreur lors de l'ajout de l'auteur : {ex.Message}");
            }
        }

        public static void ModifierAuteur(int auteurId, string nom, string prenom, DateTime dateNaissance)
        {
            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();

                    string query = $"UPDATE Authors SET LastName = '{nom}', FirstName = '{prenom}', " +
                                   $"DateOfBirth = '{dateNaissance.ToString("yyyy-MM-dd")}' WHERE AuthorID = {auteurId}";
                    using (SQLiteCommand command = new SQLiteCommand(query, connection))
                    {
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de la modification de l'auteur : {ex.Message}");
            }
        }

        public static void SupprimerAuteur(int auteurId)
        {
            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();

                    string query = $"DELETE FROM Authors WHERE AuthorID = {auteurId}";
                    using (SQLiteCommand command = new SQLiteCommand(query, connection))
                    {
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de la suppression de l'auteur : {ex.Message}");
            }
        }

        public static List<Author> ObtenirAuteurs()
        {
            List<Author> auteurs = new List<Author>();
            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT * FROM Authors";
                    using (SQLiteCommand command = new SQLiteCommand(query, connection))
                    {
                        using (SQLiteDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Author auteur = ObtenirAuteurParId(Convert.ToInt32(reader["AuthorID"]));
                                auteurs.Add(auteur);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de la récupération des auteurs : {ex.Message}");
            }

            return auteurs;
        }


        public static void AjouterEmprunt(int livreId, DateTime borrowDate, DateTime dueDate)
        {
            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();

                    // Vérifie si le livre est disponible avant d'ajouter l'emprunt
                    if (EstLivreDisponible(livreId))
                    {
                        string query = "INSERT INTO Borrowings (BookId, BorrowDate, DueDate, Status) " +
                                       $"VALUES ({livreId}, '{borrowDate.ToString("yyyy-MM-dd")}', '{dueDate.ToString("yyyy-MM-dd")}', {(int)BorrowingStatus.InProgress})";
                        using (SQLiteCommand command = new SQLiteCommand(query, connection))
                        {
                            command.ExecuteNonQuery();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Le livre n'est pas disponible pour l'emprunt.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de l'ajout de l'emprunt : {ex.Message}");
            }
        }

        public static void RetournerEmprunt(int empruntId)
        {
            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();

                    string query = $"UPDATE Borrowings SET Status = {(int)BorrowingStatus.Returned} WHERE BorrowingID = {empruntId}";
                    using (SQLiteCommand command = new SQLiteCommand(query, connection))
                    {
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors du retour de l'emprunt : {ex.Message}");
            }
        }
        private static Book ObtenirLivreParId(int bookId)
        {
            Book livre = null;
            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();

                    string query = $"SELECT * FROM Books WHERE Id = {bookId}";
                    using (SQLiteCommand command = new SQLiteCommand(query, connection))
                    {
                        using (SQLiteDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                livre = new Book
                                {
                                    ISBN = Convert.ToString(reader["ISBN"]),
                                    Title = Convert.ToString(reader["Title"]),
                                    Author = ObtenirAuteurParId(Convert.ToInt32(reader["AuthorId"])),
                                    PublicationYear = Convert.ToInt32(reader["PublicationYear"]),
                                    Genre = Convert.ToString(reader["Genre"])
                                };
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de la récupération du livre : {ex.Message}");
            }

            return livre;
        }

        public static List<Borrowing> ObtenirEmprunts()
        {
            List<Borrowing> emprunts = new List<Borrowing>();
            try
            {
                string connectionString = "Data Source=database.db;Version=3;";
                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT * FROM Borrowings";
                    using (SQLiteCommand command = new SQLiteCommand(query, connection))
                    {
                        using (SQLiteDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                int bookId = Convert.ToInt32(reader["BookId"]);
                                Book livre = ObtenirLivreParId(bookId);

                                Borrowing emprunt = new Borrowing(
                                    Convert.ToInt32(reader["BorrowingID"]),
                                    livre,
                                    Convert.ToDateTime(reader["BorrowDate"]),
                                    Convert.ToDateTime(reader["DueDate"]),
                                    (BorrowingStatus)Convert.ToInt32(reader["Status"])
                                );
                                emprunts.Add(emprunt);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de la récupération des emprunts : {ex.Message}");
            }

            return emprunts;
        }




        private static bool EstLivreDisponible(int livreId)
        {
            // Logique pour vérifier si le livre est disponible (non emprunté)
            // Retourne true si le livre est disponible, sinon false
            return true;
        }

    }
}
