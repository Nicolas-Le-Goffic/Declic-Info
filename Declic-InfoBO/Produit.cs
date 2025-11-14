using System;

namespace Declic_InfoBO
{
    public class Produit
    {
        // Attributs privés
        private int codeProduit;
        private float prixVenteProduit;
        private string libelleProduit;
        private string categorie;

        // Constructeur
        public Produit(int codeProduit, float prixVenteProduit, string libelleProduit, string categorie)
        {
            this.codeProduit = codeProduit;
            this.prixVenteProduit = prixVenteProduit;
            this.libelleProduit = libelleProduit;
            this.categorie = categorie;
        }

        // Propriétés publiques (CamelCase)
        public int CodeProduit
        {
            get { return codeProduit; }
            set { codeProduit = value; }
        }

        public string LibelleProduit
        {
            get { return libelleProduit; }
            set { libelleProduit = value; }
        }

        public float PrixVenteProduit
        {
            get { return prixVenteProduit; }
            set { prixVenteProduit = value; }
        }

        public string Categorie
        {
            get { return categorie; }
            set { categorie = value; }
        }
    }
}
