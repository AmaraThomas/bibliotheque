using System;
using MySql.Data.MySqlClient;
using Exo_biblioteque.models;
using System.Collections.Generic;



namespace Exo_biblioteque.database
{
    public class connectBDD
    {
        public static MySqlConnection conn;

        public MySqlConnection sqlConnect()
        {
            string server = "localhost";
            string database = "sqlbibliotheque";
            string user = "root";
            string password = "";
            string port = "3306";
            string sslM = "none";

            string connString = String.Format("server={0};port={1};user id={2}; password={3}; database={4}; SslMode={5}", server, port, user, password, database, sslM);

            conn = new MySqlConnection(connString);
            try
            {
                conn.Open();
                Console.WriteLine("Connection Successful");
               // conn.Close();
            }
            catch (MySqlException e)
            {
                Console.WriteLine(e.Message + connString);
            }
            return conn;    
        }

        internal void InsertDB(MySqlConnection conn, List<Livre> listLivre)
        {
            
            foreach (Livre livre in listLivre)
            {
                var sql = "INSERT INTO livre (titre, isbn) VALUES (@titre,@isbn)";
                var cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@titre", livre.Titre);
                cmd.Parameters.AddWithValue("@isbn", livre.Isbn);
                cmd.Prepare();
                cmd.ExecuteNonQuery();
            }
            conn.Close();
            /* var cmd = new MySqlCommand();
             cmd.Connection = conn;
             foreach (Livre livre in listLivre) {
                 cmd.CommandText = "INSERT INTO livre (titre, isbn) VALUES (@titre,@isbn)";
                 cmd.Parameters.AddWithValue("@titre", livre.Titre);
                 cmd.Parameters.AddWithValue("@isbn", livre.Isbn);
                 cmd.Prepare();
                 cmd.ExecuteNonQuery();
             }*/

        }

        internal MySqlDataReader ReadDB(MySqlConnection conn, List<Livre> listLivre)
        {
            List<Livre> newList = new List<Livre>();
            // Récuperer les données de la commande sql ! remplace ExecuteNonQuery();qui ne renvoie rien !!!
            var sql = "SELECT * FROM livre";
            var cmd = new MySqlCommand(sql, conn);
            MySqlDataReader rdr = cmd.ExecuteReader();

            return rdr;
        }


    }
}
