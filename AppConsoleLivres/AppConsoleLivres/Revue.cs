using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppConsoleLivres
{
    internal class Revue : Livres
    {
        public int Numero { get; set; }
        public int Annee { get; set; }
        public Revue(string Titre, string Auteur, int nbrPages, int Numeros, int Annees) : base (Titre, Auteur, nbrPages)
        {
            Numero = Numeros;
            Annee = Annees;
        }
        public override void AfficherDetails()
        {
            base.AfficherDetails();
            Console.WriteLine($"Numero: {Numero}");
            Console.WriteLine($"Annee: {Annee}");
        }
    }
}
