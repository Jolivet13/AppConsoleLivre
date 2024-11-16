namespace AppConsoleLivres;

internal class Program
{
    static void Main(string[] args)
    {
        List<Livres> maBibliotheque = new List<Livres>();
        Revue revue01 = new Revue("Revue Spetacle", "Dr.Fabrice", 101, 13, 1995);
        Revue revue02 = new Revue("Revue litteraire", "Dr.Franck", 152, 5, 1953);
        Roman roman01 = new Roman("L'abell", "kenfack", 430, "Fiction");
        Roman roman02 = new Roman("Le fils de Dieu", "Jolivet", 540, "Fiction");
        maBibliotheque.Add(revue01);
        maBibliotheque.Add(revue02);
        maBibliotheque.Add(roman01);
        maBibliotheque.Add(roman02);
        foreach (var livre in maBibliotheque)
        {
            livre.AfficherDetails();
            Console.WriteLine();
        }
    }
}
