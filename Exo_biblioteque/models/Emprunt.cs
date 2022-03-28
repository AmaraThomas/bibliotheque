using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo_biblioteque.models
{
    internal class Emprunt
    {
        private int id;
        private DateTime date_sortie;
        private DateTime date_retour;
        private Boolean deleted;

        public int Id { get => id; set => id = value; }
        public DateTime Date_sortie { get => date_sortie; set => date_sortie = value; }
        public DateTime Date_retour { get => date_retour; set => date_retour = value; }
        public bool Deleted { get => deleted; set => deleted = value; }
    }
}
