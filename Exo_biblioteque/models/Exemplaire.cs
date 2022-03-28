
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo_biblioteque.models
{
    internal class Exemplaire
    {
        private int id;
        private DateTime date_achat;
        private string emplacement;
        private Boolean deleted;

        public int Id { get => id; set => id = value; }
        public DateTime Date_achat { get => date_achat; set => date_achat = value; }
        public string Emplacement { get => emplacement; set => emplacement = value; }
        public bool Deleted { get => deleted; set => deleted = value; }
    }
}
