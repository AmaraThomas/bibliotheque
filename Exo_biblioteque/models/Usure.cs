using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo_biblioteque.models
{
    internal class Usure
    {
        private int id;
        private string etat;
        private Boolean deleted;

        public int Id { get => id; set => id = value; }
        public string Etat { get => etat; set => etat = value; }
        public bool Deleted { get => deleted; set => deleted = value; }
    }
}
