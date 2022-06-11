using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rappelPOO
{
   
    class Program
    {
    class Person
    {
        private string Nom { set; get; }
        private string PostNom { set; get; }
        private string PreNom { set; get; }
        private string Genre { set; get; }
        private DateTime DateNaissance { set; get; }
        private string Adresse { set; get; }
        public  Person(string nom,string postnom,string prenom,string genre,DateTime datenaissance,string adresse )
        {
            this.Nom = nom;
            this.PostNom = postnom;
            this.PreNom = prenom;
            this.Genre = genre;
            this.DateNaissance = datenaissance;
            this.Adresse = adresse;
            Console.WriteLine("========================INITILIZING ...");
        }
        ~Person()
        {

        }
        public void AfficherPersonne()
        {
            Console.WriteLine("Bonjour " + Nom + " " + PostNom + " " + PreNom + " " + (DateTime.Today.Year-DateNaissance.Year));
        }

    }
        static void Main(string[] args)
        {
            Person p = new Person("exauce", "mwililikwa", "mutindos", "m", DateTime.Parse("2005-12-12"), "goma");
            p.AfficherPersonne();
            Console.Read();
        }
    }
}
