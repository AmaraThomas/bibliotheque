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
        private string nom;
        private string prenom;
        private string adresse;
        private DateTime date_adhesion;
        private string matricule;
        private int telephone;
        private string date_naissance;
        private string email;
        private string password;
    //  private Boolean deleted;

        public int Id { get => id; set => id = value; }
        public string Nom { get => nom; set => nom = value; }
        public string Prenom { get => prenom; set => prenom = value; }
        public string Adresse { get => adresse; set => adresse = value; }
        public DateTime Date_adhesion { get => date_adhesion; set => date_adhesion = value; }
        public string Matricule { get => matricule; set => matricule = value; }
        public int Telephone { get => telephone; set => telephone = value; }
        public string Date_naissance { get => date_naissance; set => date_naissance = value; }
        public string Email { get => email; set => email = value; }
        public string Password { get => password; set => password = value; }

        public Abonne(string nom, string prenom, string adresse, DateTime date_adhesion, string matricule, int telephone, string date_naissance, string email, string password)
        {
            this.Id = id;
            this.nom = nom;
            this.prenom = prenom;
            this.adresse = adresse;
            this.date_adhesion = date_adhesion;
            this.matricule = matricule;
            this.telephone = telephone;
            this.date_naissance = date_naissance;
            this.email = email;
            this.password = password;
        }
        public Abonne(){}

        //   public bool Deleted { get => deleted; set => deleted = value; }


    }
}
