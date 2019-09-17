using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace KinoModel
{
    

    public class Film
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public Categorie Categorie { get; set; }
        public int Dauer { get; set;}  //in Minuten
        public double Preis { get; set; }

        public string Trailer { get; set; }

        public ArrayList Vorstellungen { get; } //Alle Vorstellungen zu diesem Film

        public Film(int id, string title,string trailer, CategorieId categorieId)
        {
            Id = id;
            Title = title;
            Trailer = trailer;
            Categorie = new Categorie(categorieId);
            Vorstellungen = new ArrayList();
        }
        public Film(int id, string title, string trailer, CategorieId categorieId, int dauer): this(id, title,trailer, categorieId)
        {
            this.Dauer = dauer;
        }

        public string getInfo()
        {
            return Title + ":" + Categorie.Desc + " " + Dauer + "min";
        }

        public string Spielzeiten
        {
            get
            {
                string langZeiten = "";
                foreach (Vorstellung v in Vorstellungen)
                {
                    langZeiten += (v.Spielzeit.ToString("g")) + "\n";
                }
                return langZeiten;
            }
        }
    }
}
