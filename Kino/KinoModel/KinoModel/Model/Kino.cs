using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Collections.ObjectModel;

namespace KinoModel
{
    public class Kino
    {
        public string Name {get;}           //Name of the cinema
        public int AnzahlSitze { get; }     //Total number of seats (suppose there is only one room)
        public ArrayList Filmlist { get; }  //All the movies

        public ObservableCollection<Vorstellung> Vorstellungsliste { get; set; }

        private static string[,] filmdata  = new string[,]{
            {"Despicable Me 3", "0","https://www.youtube.com/watch?v=6DBi41reeF0"},
            {"Valerian and the City of a Thousand Planets", "3","https://www.youtube.com/watch?v=NNrK7xVG3PM"},
            {"The Party", "4","https://www.youtube.com/watch?v=Wb4FF6lCqFw"},
            {"Spider-Man: Homecoming", "2","https://www.youtube.com/watch?v=n9DwoQ7HWvI"},
            {"Walk with Me", "1","https://www.youtube.com/watch?v=u9V4cKTffLU"},
            };
        private static string[,] trailer = new string[,]{
            {"https://www.youtube.com/watch?v=6DBi41reeF0", "0"},
            {"https://www.youtube.com/watch?v=NNrK7xVG3PM", "3"},
            {"https://www.youtube.com/watch?v=Wb4FF6lCqFw", "4"},
            {"https://www.youtube.com/watch?v=n9DwoQ7HWvI", "2"},
            {"https://www.youtube.com/watch?v=u9V4cKTffLU", "1"},
            };
        private static Kino _instance = null; //the single instance of this class

        /// <summary>
        /// This is the protected constructor. It should only be called within this class.
        /// The public interface is the static method getInstance(), which returns the single instance of this class.
        /// This method initialises all attributes. Especially the list of all movies (Filmlist) will be initialised 
        /// by calling init(). 
        /// </summary>
        protected Kino()
        {
            Name = "Kino ABC";
            AnzahlSitze = 20;
            Filmlist = new ArrayList();
            init();
        }

        private void init()
        {
            int id = 1;
            for (int i = 0; i < filmdata.Length/3 ; i++) // 
            {
                string title = filmdata[i, 0];
                int catid = int.Parse(filmdata[i, 1]);
                string trailer = filmdata[i, 2];
                Console.WriteLine("{0}, {1}, {2}", id, title, catid);
                Film fm = new Film(id, title,trailer, (CategorieId)catid, 100+2*i);
                //new for 2019SS:
                fm.Preis = 15 + i;
                fm.Vorstellungen.Add(new Vorstellung(new DateTime(2017, 10, 9, 14+i*2, 15, 0), AnzahlSitze));
                fm.Vorstellungen.Add(new Vorstellung(new DateTime(2017, 10, 10, 14+i*2, 15, 0), AnzahlSitze));
                fm.Vorstellungen.Add(new Vorstellung(new DateTime(2017, 10, 11, 14 + i * 2, 15, 0), AnzahlSitze));
                fm.Vorstellungen.Add(new Vorstellung(new DateTime(2017, 10, 12, 14 + i * 2, 15, 0), AnzahlSitze));
                fm.Vorstellungen.Add(new Vorstellung(new DateTime(2017, 10, 13, 14 + i * 2, 15, 0), AnzahlSitze));
                fm.Vorstellungen.Add(new Vorstellung(new DateTime(2017, 10, 14, 14 + i * 2, 15, 0), AnzahlSitze)); 
                Filmlist.Add(fm); 
                id++;
            }
        }

        /// <summary>
        /// This method returns the single instance of this class.
        /// Regardless how many times you call this method, you will always get the same instance.
        /// </summary>
        public static Kino getInstance()
        {
            if (_instance == null)
            {
                _instance = new Kino();
            }
            return _instance;
        }

        /// <summary>
        /// This method finds all movies, which matches (case insensitive) the given name and returns them as a list.
        /// </summary>
        public ArrayList findFilmByName(string name)
        {
            ArrayList filmByNameList = new ArrayList();
            if (name == null) name = "";
            foreach (Film fm in Filmlist)
            {
                if (fm.Title.ToUpper().Contains(name.ToUpper()))
                {
                    filmByNameList.Add(fm);
                }
            }
            return filmByNameList;
        }

    }
}
