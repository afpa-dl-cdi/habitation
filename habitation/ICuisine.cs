namespace habitation
{
    /// <summary>
    /// Définit les éléments et le fonctionnement d'une cuisine
    /// </summary>
     interface ICuisine
    {
        // pas d'attributs possibles
        // pas de constructeurs possibles
        // pas d'accesseurs

        /// <summary>
        /// Définir l'arrivée de la prise du four
        /// </summary>
        /// <param name="priseMurale"></param>
        /// <param name="Amperage"></param>
        void faireArriverPriseFour(prise priseMurale, int Amperage);


        /// <summary>
        /// Définir l'installation de l'évier
        /// </summary>
        /// <param name="robinetCuisine"></param>
        /// <param name="nombreEvier"></param>
        void ImplanterEvier(robinet robinetCuisine, int nombreEvier);

        /// <summary>
        /// Définir le plan de travail
        /// </summary>
        /// <param name="typeMateriau"></param>
        /// <param name="longueur"></param>
        /// <param name="profondeur"></param>
        /// <param name="epaisseur"></param>
        void InstallerPlanDeTravail(materiau typeMateriau, float longueur, float profondeur, float epaisseur);

        /// <summary>
        /// Définir la VMC pour l'évacuation des fumées
        /// </summary>
        void InstallerVMC();

        /// <summary>
        /// Définir les paramètres de la cuisinière
        /// </summary>
        /// <param name="typeCuisson"></param>
        /// <param name="nombreFeux"></param>
        /// <param name="longueur"></param>
        /// <param name="largeur"></param>
        void InstallerCuisiniere(energie typeCuisson, int nombreFeux, float longueur, float largeur);
    }


}