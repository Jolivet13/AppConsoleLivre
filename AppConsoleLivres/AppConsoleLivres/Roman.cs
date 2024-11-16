using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppConsoleLivres
{
    internal class Roman :Livres
    {
        public string Genre { get; set; }
        public Roman(string Titre, string Auteur, int nbrPages, string genre) : base(Titre, Auteur, nbrPages)
        {
            Genre = genre;
        }
        public override void AfficherDetails()
        {
            base.AfficherDetails();
            Console.WriteLine($"genre: {Genre}");
        }
    }
}
