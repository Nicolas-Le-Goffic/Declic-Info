using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Declic_InfoBO
{
    public class Produit
    {
        protected int id;
        protected string libelle;
        protected int categorie;
        protected decimal prix;

        public Produit() { }

        public Produit(int id, string libelle, int categorie, decimal prix)
        {
            this.id = id;
            this.libelle = libelle;
            this.categorie = categorie;
            this.prix = prix;
        }

        public int getId()
        {
            return id;
        }

        public string getLibelle()
        {
            return libelle;
        }

        public int getCategorie()
        {
            return categorie;
        }

        public decimal getPrix()
        {
            return prix;
        }

        public void setId(int id)
        {
            this.id = id;
        }

        public void setLibelle(string libelle)
        {
            this.libelle = libelle;
        }

        public void setCategorie(int categorie)
        {
            this.categorie = categorie;
        }

        public void setPrix(decimal prix)
        {
            this.prix = prix;
        }
    }
}
