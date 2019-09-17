using KinoModel.View;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace KinoModel.ViewModel
{
    public class MainWindow_ViewModel :ModelBase
    {
        private ICommand suchenCommand;
        private ICommand bestellenCommand;
        public string FilmName { get; set; }
        public Kino Kinos { get; set; } = Kino.getInstance();
        public ObservableCollection<Film> CurrentFilm { get; set; }

        public ICommand SuchenCommand
        {
            get { return suchenCommand; }
            set { suchenCommand = value; }
        }

        public ICommand BestellenCommand
        {
            get { return bestellenCommand; }
            set { bestellenCommand = value; }
        }


        public MainWindow_ViewModel()
        {
            CurrentFilm = new ObservableCollection<Film>();
            foreach (Film b in Kinos.Filmlist)
            {
                CurrentFilm.Add(b);
            }
            SuchenCommand = new RelayCommand(Do_suchenCommand);
            BestellenCommand = new RelayCommand(Do_bestellenCommand, CanExecute_bestellenCommand);

        }


        private void Do_suchenCommand(object obj)
        {
            CurrentFilm.Clear();
            foreach (Film b in Kinos.findFilmByName(FilmName))
            {
                CurrentFilm.Add(b);
            }
        }

        private void Do_bestellenCommand(object obj)
        {
            KinoView_ViewModel bestellung_ViewModel = new KinoView_ViewModel((Film)obj);

            KinoView newKinoView = new KinoView();

            newKinoView.DataContext = bestellung_ViewModel;

            if (newKinoView.ShowDialog() == true)
            {
                bestellung_ViewModel = (KinoView_ViewModel)newKinoView.DataContext;

                Film currentFilm = bestellung_ViewModel.Film;

                CurrentFilm.Remove((Film)obj);
                CurrentFilm.Add(currentFilm);

            }

        }

        private bool CanExecute_bestellenCommand(object obj)
        {
            Film vm = (Film)obj;

            

            return vm !=null;


        }

    }



}
