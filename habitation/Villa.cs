namespace habitation
{
    /// <summary>
    /// Habitation de type villa avec ou sans extérieur
    /// </summary>
    class Villa : Habitation
    {
        /// <summary>
        /// Définit si la maison possède un extérieur ou non
        /// </summary>
        public bool Terrain { get; set; }

        /// <summary>
        /// Définit la superficie du terrain
        /// </summary>
        /// <remarks>Le terrain doit exister</remarks>
        public int SuperficieTerrain { get; set; }

        /// <summary>
        /// Constructeur d'une villa sans terrain
        /// </summary>
        /// <param name="nbPiece"></param>
        public Villa (int nbPiece): base (nbPiece)
        {
            NombreDePieces = nbPiece;
        }


        /// <summary>
        /// Constructeur d'une villa avec terrain 
        /// </summary>
        /// <param name="nbPiece"></param>
        /// <param name="terrain"></param>
        /// <param name="superficieTerrain"></param>
        public Villa(int nbPiece, bool terrain, int superficieTerrain=0) : base(nbPiece)
        {
            NombreDePieces = nbPiece;
            Terrain = terrain;
            SuperficieTerrain = superficieTerrain;
        }
    }
}