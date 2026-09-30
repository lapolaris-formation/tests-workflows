using testsWorkflows.Metier;

namespace testsWorkflows.Donnees;

public class ProduitRepository
{
    private readonly List<Produit> _produits = [];

    public void Ajouter(Produit produit)
    {
        _produits.Add(produit);
    }

    public IReadOnlyList<Produit> ObtenirTous()
    {
        return _produits;
    }
}
