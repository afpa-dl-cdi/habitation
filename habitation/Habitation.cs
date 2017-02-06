using System;

namespace habitation
{
    /// <summary>
    /// Classe abstraite définissant une habitation
    /// </summary>
    abstract class Habitation : ISalleDeBain, ICuisine, ISanitaire
    {
        /// <summary>
        /// Nombre de pièce(s) dans l'habitation
        /// </summary>
        public int NombreDePieces { get; set; }

        /// <summary>
        /// Constructeur permettant de définir le nombre de pièces
        /// </summary>
        /// <param name="nbPiece"></param>
        public Habitation(int nbPiece)
        {
            this.NombreDePieces = nbPiece;
        }

        /// <summary>
        /// faire arriver l'eau
        /// </summary>
        public void faireArriverLeau()
        {
            //code pour définir l'arrivée d'eau pour une habitation
        }

        /// <summary>
        /// évacuer l'eau
        /// </summary>
        public void evacuerLeau()
        {
            //code pour définir l'évacuation de l'eau
        }

        /// <summary>
        /// place le mirroir
        /// </summary>
        /// <param name="hauteur"></param>
        /// <param name="largeur"></param>
        public void placeMirroir(int hauteur, int largeur)
        {
            //code pour définir le placement du mirroir
        }


        /// <summary>
        /// faire arriver des prises electriques
        /// </summary>
        /// <param name="prises"></param>
        public void faireArriverPriseElectrique(prise[] prises)
        {
            //code pour définir l'arrivée de la prise électrique
        }


        /// <summary>
        /// faire arriver la prise pour le four
        /// </summary>
        /// <param name="priseMurale"></param>
        /// <param name="Amperage"></param>
        public void faireArriverPriseFour(prise priseMurale, int Amperage)
        {
            // code pour définir la prise du four
        }

        /// <summary>
        /// installer et configurer l'évier
        /// </summary>
        /// <param name="robinetCuisine"></param>
        /// <param name="nombreEvier"></param>
        public void ImplanterEvier(robinet robinetCuisine, int nombreEvier)
        {
            // code pour configurer l'évier 
        }

        /// <summary>
        /// installer le plan de travail
        /// </summary>
        /// <param name="typeMateriau"></param>
        /// <param name="longueur"></param>
        /// <param name="profondeur"></param>
        /// <param name="epaisseur"></param>
        public void InstallerPlanDeTravail(materiau typeMateriau, float longueur, float profondeur, float epaisseur)
        {
            // code pour définir le plan de travail
        }

        /// <summary>
        /// Installer la VMC
        /// </summary>
        public void InstallerVMC()
        {
           // code pour l'installation de la vmc 
        }

        /// <summary>
        /// installer la cuisinière
        /// </summary>
        /// <param name="typeCuisson"></param>
        /// <param name="nombreFeux"></param>
        /// <param name="longueur"></param>
        /// <param name="largeur"></param>
        public void InstallerCuisiniere(energie typeCuisson, int nombreFeux, float longueur, float largeur)
        {
           // code pour la configuration de la cuisiniere
        }
    }
}