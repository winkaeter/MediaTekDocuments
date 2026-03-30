public class Utilisateur
{
    public string Id { get; set; }
    public string Identifiant { get; set; }
    public string Nom { get; set; }
    public string Prenom { get; set; }
    public int IdService { get; set; }
    public string LibelleService { get; set; }

    public Utilisateur(string id, string identifiant, string nom, string prenom, int idService, string libelleService)
    {
        this.Id = id;
        this.Identifiant = identifiant;
        this.Nom = nom;
        this.Prenom = prenom;
        this.IdService = idService;
        this.LibelleService = libelleService;
    }
}