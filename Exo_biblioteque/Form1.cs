using Exo_biblioteque.models;
using Exo_biblioteque.database;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Text;
using MySql.Data.MySqlClient;
using System.Diagnostics;

namespace Exo_biblioteque
{
    public partial class Form1 : Form
    {
        List<Livre> listLivre = new List<Livre>();
        List<Abonne> listAbonne = new List<Abonne>();
        connectBDD sqlconnect = new connectBDD();
        List<Livre> loadListeLivre = new List<Livre>();
        public Form1()
        {
            InitializeComponent();
            MySqlConnection conn = sqlconnect.sqlConnect();
            var infos = sqlconnect.ReadDB(conn,listLivre);
            
            Livre livre;
            if (infos.HasRows)
            {
                while (infos.Read())
                {
                    ListViewItem item = new ListViewItem(infos.GetString(1));
                    item.SubItems.Add(infos.GetString(2));
                    listView1.Items.Add(item);
                    livre = new Livre()
                    {
                        Titre = infos.GetString(1),
                        Isbn = Convert.ToInt32(infos.GetString(2))
                    };

                    loadListeLivre.Add(livre);

                   /* for(int i = 0; i < infos.GetString(0).Length; i++)
                    listView1.Tag = infos.GetString(i);*/
                }
            }
            listView1.Tag = loadListeLivre;
            infos.Close();
            conn.Close();
            
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            string titre = richTextBox1.Text;
            int isbn = Convert.ToInt32(richTextBox2.Text);
            Livre livre = new Livre();

            livre.Titre = titre;
            livre.Isbn = isbn;

            ListViewItem item = new ListViewItem(livre.Titre);

            item.SubItems.Add(livre.Isbn.ToString());
            listView1.Items.Add(item);


            listLivre.Add(livre);
            //on ajoute le tag
            listView1.Tag = listLivre;
            richTextBox1.Clear();
            richTextBox2.Clear();

            MySqlConnection conn = sqlconnect.sqlConnect();
           sqlconnect.InsertDB(conn, listLivre);

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                //recupere l'index de l'élément selectionner
                int indexI = ((ListViewItem)listView1.SelectedItems[0]).Index;
                //recupere l'item selon l'index qui sont stocker dans le tag plus haut
                var selectedItem = (Livre)((List<Livre>)listView1.Tag)[indexI];

                if (selectedItem != null)
                {
                    richTextBox1.Text = selectedItem.Titre;
                    richTextBox2.Text = selectedItem.Isbn.ToString();
                    //MessageBox.Show(selectedItem.ToString(), "détails du livre", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }                  

            }
            catch (Exception ex)
            {
                //UN GRAND CHNGEMENT
            }
        }

        private void ButtonEdit_Click(object sender, EventArgs e)
        {
            //on recup l'index et on change le 1er element et le deuxiement de la ligne
            int indexI = listView1.SelectedItems[0].Index;
            listView1.SelectedItems[0].SubItems[0].Text = richTextBox1.Text;
            listView1.SelectedItems[0].SubItems[1].Text = richTextBox2.Text;

            //on edit la list de livre
            string titreText = richTextBox1.Text;
            int isbnText = Convert.ToInt32(richTextBox2.Text);
            //enregistre dans la listView
            loadListeLivre[indexI].Titre = titreText;
            loadListeLivre[indexI].Isbn = isbnText;

            richTextBox1.Clear();
            richTextBox2.Clear();
            //TODO: enregistrer dans la base de donnée aprés modifcation
        }

        private void ButtonSup_Click(object sender, EventArgs e)
        {

            if(MessageBox.Show("Tu es sur ?", "Supprimer", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                listView1.Items.RemoveAt(listView1.SelectedIndices[0]);
                richTextBox1.Clear();
                richTextBox2.Clear();
            }
        }

        private void ButtonSaveAbo_Click(object sender, EventArgs e)
        {
            string nom = this.richTextNom.Text;
            string prenom = this.richTextPrenom.Text;
            string adresse = this.richTextAdresse.Text;
            string naissance = this.richTextNaissance.Text;
            int tel = Convert.ToInt32(richTextTel.Text);
            string matricule = richTextMatricule.Text;
            string email = richTextEmail.Text;
            string mdp = richTextMdp.Text;

            Abonne abonne = new Abonne();

            abonne.Nom = nom;
            abonne.Prenom = prenom;
            abonne.Adresse = adresse;
            abonne.Telephone = tel;
            abonne.Matricule = matricule;
            abonne.Email = email;
            abonne.Password = mdp;
            abonne.Date_naissance = naissance;
            abonne.Date_adhesion = DateTime.Now;


            ListViewItem item = new ListViewItem(abonne.Nom);
            item.SubItems.Add(abonne.Prenom.ToString());
            item.SubItems.Add(abonne.Adresse.ToString());
            item.SubItems.Add(abonne.Telephone.ToString());
            item.SubItems.Add(abonne.Matricule.ToString());
            item.SubItems.Add(abonne.Email.ToString());
            item.SubItems.Add(abonne.Password.ToString());
            item.SubItems.Add(abonne.Date_naissance.ToString());
            item.SubItems.Add(abonne.Date_adhesion.ToString());

            listView2.Items.Add(item);


            listAbonne.Add(abonne);
            //on ajoute le tag
            listView2.Tag = listAbonne;

            this.richTextNom.Clear();
            this.richTextPrenom.Clear();
            this.richTextAdresse.Clear();
            this.richTextNaissance.Clear();
            richTextTel.Clear();
            richTextMatricule.Clear();
            richTextEmail.Clear();
            richTextMdp.Clear();

            autoSave(listAbonne);
        }

        private void ButtonEditAbo_Click(object sender, EventArgs e)
        {
            //on recup l'index et on change le 1er element et le deuxiement de la ligne
            int indexI = listView2.SelectedItems[0].Index;

            listView2.SelectedItems[0].SubItems[0].Text = richTextNom.Text;
            listView2.SelectedItems[0].SubItems[1].Text = richTextPrenom.Text;
            listView2.SelectedItems[0].SubItems[2].Text = richTextAdresse.Text;
            listView2.SelectedItems[0].SubItems[3].Text = richTextNaissance.Text;
            listView2.SelectedItems[0].SubItems[4].Text = richTextTel.Text;
            listView2.SelectedItems[0].SubItems[5].Text = richTextMatricule.Text;
            listView2.SelectedItems[0].SubItems[6].Text = richTextEmail.Text;
            listView2.SelectedItems[0].SubItems[7].Text = richTextMdp.Text;

            //on edit la list de livre
            string NomText =        richTextNom.Text;
            string PrenomText =     richTextPrenom.Text;
            string adresseText =    richTextAdresse.Text;
            string naissanceText =  richTextNaissance.Text;
            int telephoneText =     Convert.ToInt32(richTextTel.Text);
            string matriculeText =  richTextMatricule.Text;
            string emailText =      richTextEmail.Text;
            string passwordText =   richTextMdp.Text;

            listAbonne[indexI].Nom = NomText ;
            listAbonne[indexI].Prenom = PrenomText;
            listAbonne[indexI].Adresse = adresseText ;
            listAbonne[indexI].Date_naissance = naissanceText ;
            listAbonne[indexI].Telephone = telephoneText ;
            listAbonne[indexI].Matricule = matriculeText ;
            listAbonne[indexI].Email = emailText ;
            listAbonne[indexI].Password = passwordText ;

            richTextNom.Clear();
            richTextPrenom.Clear();
            richTextAdresse.Clear();
            richTextNaissance.Clear();
            richTextTel.Clear();
            richTextMatricule.Clear();
            richTextEmail.Clear();
            richTextMdp.Clear();

        }

        private void ButtonSupAbo_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tu es sur ?", "Supprimer", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                listView2.Items.RemoveAt(listView2.SelectedIndices[0]);
                richTextNom.Clear();
                richTextPrenom.Clear();
                richTextAdresse.Clear();
                richTextNaissance.Clear();
                richTextTel.Clear();
                richTextMatricule.Clear();
                richTextEmail.Clear();
                richTextMdp.Clear();
            }
        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                //recupere l'index de l'élément selectionner
                int indexI = ((ListViewItem)listView2.SelectedItems[0]).Index;
                //recupere l'item selon l'index qui sont stocker dans le tag plus haut
                var selectedItem = (Abonne)((List<Abonne>)listView2.Tag)[indexI];

                if (selectedItem != null)
                {
                    richTextNom.Text  = selectedItem.Nom;
                    richTextPrenom.Text  = selectedItem.Prenom;
                    richTextAdresse.Text  = selectedItem.Adresse;
                    richTextTel.Text  = selectedItem.Telephone.ToString();
                    richTextMatricule.Text  = selectedItem.Matricule;
                    richTextEmail.Text  = selectedItem.Email;
                    richTextMdp.Text  = selectedItem.Password;
                    richTextNaissance.Text = selectedItem.Date_naissance;

                    //MessageBox.Show(selectedItem.ToString(), "détails du livre", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception ex)
            {
                //UN GRAND CHNGEMENT
            }
        }
        private void autoSave(List<Abonne>listAbonne)
        {
            string json = JsonConvert.SerializeObject(listAbonne);
            string path = @"C:\Users\Thoma\Documents\abonne.json";

            if (File.Exists(path))
            {
                File.Delete(path);
                using (var tw = new StreamWriter(path, true))
                {
                    tw.WriteLine(json);
                    tw.Close();
                }
            }
            else if (!File.Exists(path))
            {
                using (var tw = new StreamWriter(path, true))
                {
                    tw.WriteLine(json);
                    tw.Close();
                }
            }
        }
    }
}

