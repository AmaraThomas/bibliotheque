using Exo_biblioteque.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exo_biblioteque
{
    public partial class Form1 : Form
    {
        List<Livre> listLivre = new List<Livre>();

        public Form1()
        {
            InitializeComponent();
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
            listView1.CheckBoxes = true;
            listView1.Items.Add(item);

            listLivre.Add(livre);
            listView1.Tag = listLivre;
            richTextBox1.Clear();
            richTextBox2.Clear();   
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
<<<<<<< HEAD
                var selectedItem = (Livre)listView1.SelectedItems[0].Tag;
                if (selectedItem != null)
                {
                    MessageBox.Show(selectedItem.ToString(), "détails du livre", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

=======
                int indexI = ((ListViewItem)listView1.SelectedItems[0]).Index;
                var selectedItem = (Livre)((List<Livre>)listView1.Tag)[indexI];
                if (selectedItem != null)
                {
                    richTextBox1.Text = selectedItem.Titre;
                    richTextBox2.Text = selectedItem.Isbn.ToString();
                    //MessageBox.Show(selectedItem.ToString(), "détails du livre", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }    
                
>>>>>>> a95cca42db658bc320725ce01b0668960c3c4012
            }
            catch (Exception ex)
            {
                //bon pour un tour en voiture télécommandé pour thomas
            }
        }

        private void ButtonEdit_Click(object sender, EventArgs e)
        {
            int indexI = listView1.SelectedItems[0].Index;
            string subI0 = listView1.SelectedItems[0].SubItems[0].Text = richTextBox1.Text;
            string subI1 = listView1.SelectedItems[0].SubItems[1].Text = richTextBox2.Text;

            string titreText = richTextBox1.Text;
            int isbnText = Convert.ToInt32(richTextBox2.Text);
            listLivre[indexI].Titre = titreText;
            listLivre[indexI].Isbn = isbnText;

            richTextBox1.Clear();
            richTextBox2.Clear();

        }
    }
}
