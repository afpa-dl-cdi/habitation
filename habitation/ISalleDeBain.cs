namespace habitation
{
    /// <summary>
    /// Définit les éléments et le fonctionnement d'une salle de bain
    /// </summary>
    interface ISalleDeBain
    {
        /// <summary>
        /// Point d'arriver de l'eau
        /// </summary>
        void faireArriverLeau();

        /// <summary>
        /// Point d'évacuation de l'eau
        /// </summary>
        void evacuerLeau();

        /// <summary>
        /// Méthode de placement du mirroir en fonction de sa hauteur et larger
        /// </summary>
        /// <param name="hauteur"></param>
        /// <param name="largeur"></param>
        void placeMirroir(int hauteur, int largeur);

        /// <summary>
        /// Fait arriver des prises électriques
        /// </summary>
        /// <param name="prises"></param>
        void faireArriverPriseElectrique(prise [] prises);

    }
}