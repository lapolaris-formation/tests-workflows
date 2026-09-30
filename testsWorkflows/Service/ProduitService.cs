using testsWorkflows.Donnees;
using testsWorkflows.Metier;

namespace testsWorkflows.Service;

public class ProduitService
{
    private readonly ProduitRepository _repository;

    public ProduitService(ProduitRepository repository)
    {
        _repository = repository;
    }

    public void AjouterProduit(int id, string nom, decimal prix)
    {
        if (string.IsNullOrWhiteSpace(nom))
        {
            throw new ArgumentException("Le nom du produit est obligatoire.", nameof(nom));
        }

        if (prix < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(prix), "Le prix ne peut pas être négatif.");
        }

        _repository.Ajouter(new Produit(id, nom, prix));
    }

    public IReadOnlyList<Produit> ObtenirProduits()
    {
        return _repository.ObtenirTous();
    }
}
