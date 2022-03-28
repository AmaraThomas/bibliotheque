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
            listView1.Items.Add(item);

            listLivre.Add(livre);
            listView1.Tag = listLivre;
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var selectedItem = (Livre)listView1.SelectedItems[0].Tag;
                if (selectedItem != null)
                {
                    MessageBox.Show(selectedItem.ToString(), "détails du livre", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception ex)
            {
                //bon
            }
        }
    }
}
