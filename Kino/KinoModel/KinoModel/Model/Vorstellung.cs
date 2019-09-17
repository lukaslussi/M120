using System;
using System.Collections.Generic;
using System.Text;

namespace KinoModel
{
    public class Vorstellung
    {
        
        public DateTime Spielzeit { get; set; }
        public int AnzfreiePlaetze {get; set;} 


        public Vorstellung(DateTime zeit, int anzfreiePlaetze)
        {
            
            Spielzeit = zeit;
            AnzfreiePlaetze = anzfreiePlaetze; 
        }

        public string getInfo()
        {
            return "Zeit: " + Spielzeit + " Anzahl freier Plaetze " + AnzfreiePlaetze;
        }
    }
}
