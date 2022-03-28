using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo_biblioteque.models
{
    internal class Categorie
    {
        private int id;
        private string titre;
        private Boolean deleted;

        public int Id { get => id; set => id = value; }
        public string Titre { get => titre; set => titre = value; }
        public bool Deleted { get => deleted; set => deleted = value; }
    }
}
