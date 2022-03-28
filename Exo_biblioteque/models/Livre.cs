using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo_biblioteque.models
{
    internal class Livre
    {
        private int id;
        private string titre;
        private int isbn;
        private Boolean deleted;

        public int Id { get => id; set => id = value; }
        public string Titre { get => titre; set => titre = value; }
        public int Isbn { get => isbn; set => isbn = value; }
        public bool Deleted { get => deleted; set => deleted = value; }

        public override string ToString()
        {
            var details = string.Format("{0} - {1}", Titre, Isbn);
            return details;
        }
    }
   
}
