using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppConsoleLivres
{
    internal class Livres
    {
        public string Titre { get; set; }
        public string Auteur { get; set; }
        public int NombrePages { get; set; }
        public Livres(string titre, string auteur, int nbrPages)
        {
            Titre = titre;
            Auteur = auteur;
            NombrePages = nbrPages;
        }
        public virtual void AfficherDetails()
        {
            Console.WriteLine($"Titre: {Titre}");
            Console.WriteLine($"Auteur: {Auteur}");
            Console.WriteLine($"Nombre de pages: {NombrePages}");
        }
    }
}