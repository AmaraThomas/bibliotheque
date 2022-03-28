using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo_biblioteque.models
{
    internal class Motcle
    {
        private int id;
        private string mot;
        private Boolean deleted;

        public int Id { get => id; set => id = value; }
        public string Mot { get => mot; set => mot = value; }
        public bool Deleted { get => deleted; set => deleted = value; }
    }
}
