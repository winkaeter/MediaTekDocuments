
namespace MediaTekDocuments.model
{
    /// <summary>
    /// Classe métier Rayon (rayon de classement du document) hérite de Categorie
    /// </summary>
    public class Rayon : Categorie
    {
        /// <summary>
        /// Initialise une nouvelle instance de la classe <see cref="Rayon"/>
        /// </summary>
        /// <param name="id">Identifiant du rayon</param>
        /// <param name="libelle">Libellé du rayon</param>
        public Rayon(string id, string libelle) : base(id, libelle)
        {
        }

    }
}
