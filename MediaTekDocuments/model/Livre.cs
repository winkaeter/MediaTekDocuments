
namespace MediaTekDocuments.model
{
    /// <summary>
    /// Classe métier Livre hérite de LivreDvd : contient des propriétés spécifiques aux livres
    /// </summary>
    public class Livre : LivreDvd
    {
        /// <summary>
        /// Obtient l'ISBN du livre
        /// </summary>
        public string Isbn { get; }
        /// <summary>
        /// Obtient l'auteur du livre
        /// </summary>
        public string Auteur { get; }
        /// <summary>
        /// Obtient la collection du livre
        /// </summary>
        public string Collection { get; }

        /// <summary>
        /// Initialise une nouvelle instance de la classe <see cref="Livre"/>
        /// </summary>
        /// <param name="id">Identifiant du livre</param>
        /// <param name="titre">Titre du livre</param>
        /// <param name="image">URL de l'image du livre</param>
        /// <param name="isbn">ISBN du livre</param>
        /// <param name="auteur">Auteur du livre</param>
        /// <param name="collection">Collection du livre</param>
        /// <param name="idGenre">Identifiant du genre</param>
        /// <param name="genre">Libellé du genre</param>
        /// <param name="idPublic">Identifiant du public</param>
        /// <param name="lePublic">Libellé du public</param>
        /// <param name="idRayon">Identifiant du rayon</param>
        /// <param name="rayon">Libellé du rayon</param>
        public Livre(string id, string titre, string image, string isbn, string auteur, string collection,
            string idGenre, string genre, string idPublic, string lePublic, string idRayon, string rayon)
            : base(id, titre, image, idGenre, genre, idPublic, lePublic, idRayon, rayon)
        {
            this.Isbn = isbn;
            this.Auteur = auteur;
            this.Collection = collection;
        }



    }
}
