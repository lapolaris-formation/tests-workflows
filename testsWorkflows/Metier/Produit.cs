namespace testsWorkflows.Metier;

public class Produit
{
    public int Id { get; }
    public string Nom { get; }
    public decimal Prix { get; }

    public Produit(int id, string nom, decimal prix)
    {
        Id = id;
        Nom = nom;
        Prix = prix;
    }
}
