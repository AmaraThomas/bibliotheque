using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo_biblioteque.models
{
    internal class Editeur
    {
        private int id;
        private string name;
        private Boolean deleted;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public bool Deleted { get => deleted; set => deleted = value; }
    }
}
