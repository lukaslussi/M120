using KinoModel.View;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace KinoModel.ViewModel
{
    public class KinoView_ViewModel:ModelBase
    {
        private ICommand kaufenCommand;
        private ICommand cancelCommand;
        private Film film;
        private int anzahl;
        private double kosten;
        private double preis;
        private string selectedSpielzeit;


        public ICommand KaufenCommand
        {
            get { return kaufenCommand; }
            set { kaufenCommand = value; }
        }

        public ICommand CancelCommand
        {
            get { return cancelCommand; }
            set { cancelCommand = value; }
        }



        public Film Film
        {
            get { return film; }
            set { film = value; }
        }
        public string Titel
        {
            get { return Film.Title; }
            set { Film.Title = value; }
        }
        public string Kategorie
        {
            get { return Film.Categorie.Desc; }

        }
        public string Trailer
        {
            get { return Film.Trailer; }

        }
        public int Dauer
        {
            get { return Film.Dauer; }
        }
        public List<string> Spielzeiten
        {
            get { return Film.Spielzeiten.Split('\n').ToList<string>(); }

        }
        public ArrayList Verfuegbar
        {
            get { return film.Vorstellungen ; }
        }
        
        public int Anzahl
        {
            get { return anzahl; }
            set
            {
                anzahl = value;
                OnPropertyChanged(nameof(Anzahl));

                Kosten = anzahl * Preis;
                Console.WriteLine(anzahl);
            }
        }
        public double Kosten
        {
            get {return kosten;}
            set
            {
                kosten = value;
                OnPropertyChanged(nameof(Kosten));
            }
        }

        public double Preis
        {
            get {
                preis = Film.Preis;
                return preis; }
        }

        public string SelectedSpielzeit
        {
            get
            {
                
                return selectedSpielzeit;
            }
            set { selectedSpielzeit = value; }
        }


        public KinoView_ViewModel(Film film)
        {
            this.Film = film;
            this.Anzahl = 1;

            KaufenCommand = new RelayCommand(Do_kaufenCommand, CanExecute_kaufenCommand);

            
        }


        private void Do_kaufenCommand(object obj)
        {
            KinoView kinoWindow = (KinoView)obj;

            Vorstellung gewaehlteVorstellung = (Vorstellung)kinoWindow.CmbVerfuegbar.SelectedItem;

            if (MessageBox.Show("Sie haben "+Anzahl+ " Ticket fuer den Film "+Titel+" am " +gewaehlteVorstellung.Spielzeit+" gekauft. Wollen Sie es kaufen?", "Kauf", MessageBoxButton.YesNo, MessageBoxImage.Warning) == MessageBoxResult.No)
            {
               
            }
            else
            {
                MessageBox.Show("Danke für Ihren kauf", "Kauf erfolgreich");
                Vorstellung ausgewaehlteVorstellung = (Vorstellung)kinoWindow.CmbVerfuegbar.SelectedItem;
                ausgewaehlteVorstellung.AnzfreiePlaetze -= Anzahl;

                kinoWindow.DialogResult = true;


            }
        }
        private bool CanExecute_kaufenCommand(object obj)
        {
            KinoView vm = (KinoView)obj;

            Vorstellung gewaehlteVorstellung = (Vorstellung)vm.CmbVerfuegbar.SelectedItem;

            return  gewaehlteVorstellung.AnzfreiePlaetze >= Anzahl && Anzahl>0;


        }


    }
}
