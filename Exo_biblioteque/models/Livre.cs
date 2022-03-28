using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo_biblioteque.models
{
    internal class livre
    {
        private int id;
        private string name;
        private int isbn;
        private Boolean deleted;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public int Isbn { get => isbn; set => isbn = value; }
        public bool Deleted { get => deleted; set => deleted = value; }
    }
}
