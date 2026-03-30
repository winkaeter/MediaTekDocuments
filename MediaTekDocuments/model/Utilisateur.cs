/// <summary>
/// Classe métier Utilisateur (représente un utilisateur de l'application)
/// </summary>
public class Utilisateur
{
    /// <summary>
    /// Obtient ou définit l'identifiant technique de l'utilisateur
    /// </summary>
    public string Id { get; set; }
    /// <summary>
    /// Obtient ou définit l'identifiant de connexion de l'utilisateur
    /// </summary>
    public string Identifiant { get; set; }
    /// <summary>
    /// Obtient ou définit le nom de l'utilisateur
    /// </summary>
    public string Nom { get; set; }
    /// <summary>
    /// Obtient ou définit le prénom de l'utilisateur
    /// </summary>
    public string Prenom { get; set; }
    /// <summary>
    /// Obtient ou définit l'identifiant du service de l'utilisateur
    /// </summary>
    public int IdService { get; set; }
    /// <summary>
    /// Obtient ou définit le libellé du service de l'utilisateur
    /// </summary>
    public string LibelleService { get; set; }

    /// <summary>
    /// Initialise une nouvelle instance de la classe <see cref="Utilisateur"/>
    /// </summary>
    /// <param name="id">Identifiant technique</param>
    /// <param name="identifiant">Identifiant de connexion</param>
    /// <param name="nom">Nom</param>
    /// <param name="prenom">Prénom</param>
    /// <param name="idService">Identifiant du service</param>
    /// <param name="libelleService">Libellé du service</param>
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