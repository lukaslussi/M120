using KinoModel.ViewModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace KinoModel
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        //public string FilmName { get; set; }
        //public Kino Kinos { get; set; } = Kino.getInstance();
        //public ObservableCollection<Film> CurrentFilm { get; set; }
        public MainWindow()
        {

        InitializeComponent();
        MainWindow_ViewModel mainWindow_ViewModel = new MainWindow_ViewModel();
        DataContext = mainWindow_ViewModel;
        }

        //private void Suchen_Click(object sender, RoutedEventArgs e)
        //{
        //    CurrentFilm.Clear();
        //    foreach (Film b in Kinos.findFilmByName(FilmName))
        //    {
        //        CurrentFilm.Add(b);
        //    }
        //}
    }
}
