using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo_biblioteque.models
{
    internal class Abonne
    {
        private int id;
        private string name;
        private string prenom;
        private string adresse;
        private DateTime date_adhesion;
        private string matricule;
        private int telephone;
        private DateTime date_naissance;
        private string email;
        private string password;
        private Boolean deleted;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Prenom { get => prenom; set => prenom = value; }
        public string Adresse { get => adresse; set => adresse = value; }
        public DateTime Date_adhesion { get => date_adhesion; set => date_adhesion = value; }
        public string Matricule { get => matricule; set => matricule = value; }
        public int Telephone { get => telephone; set => telephone = value; }
        public DateTime Date_naissance { get => date_naissance; set => date_naissance = value; }
        public string Email { get => email; set => email = value; }
        public string Password { get => password; set => password = value; }
        public bool Deleted { get => deleted; set => deleted = value; }
    }
}
