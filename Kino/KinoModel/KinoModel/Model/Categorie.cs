using System;
using System.Collections.Generic;
using System.Text;

namespace KinoModel
{
    public enum CategorieId
    {
        ACTION,
        DOKUMENTATION,
        KRIMI,
        SCIENCEFICTION,
        KOMOEDIE

    }
    public class Categorie
    {
        public CategorieId id { get; set; }
        private Dictionary<int, String> idToDescMap = new Dictionary<int, string>(){
            {(int)CategorieId.ACTION, "Action"},
            {(int)CategorieId.DOKUMENTATION, "Dokumentation"},
            {(int)CategorieId.KRIMI, "Krimi"},
            {(int)CategorieId.SCIENCEFICTION, "Science-fiction"},
            {(int)CategorieId.KOMOEDIE, "Komoedie"}
        };

        public String Desc
        {
            get
            {
                return idToDescMap[(int)id];
            }
        }

        public Categorie(CategorieId id)
        {
            this.id = id;
        }
    }
}
