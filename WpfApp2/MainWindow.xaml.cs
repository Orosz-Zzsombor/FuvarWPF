using System;
using System.Collections.Generic;
using System.IO;
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
using System.Xml;

namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            // << Kecskés Dominik
            // >> Stiegelmayer Bálint

            

        
        }
        
        private void utazasSzamabtn_Click(object sender, RoutedEventArgs e)
        {
            List<Fuvar> Fuvarok = new List<Fuvar>();
            File.ReadAllLines("fuvar.csv").Skip(1).ToList().ForEach(x => new Fuvar(x));
            int fuvarokSzama = Fuvarok.Count();
            MessageBox.Show(Convert.ToString(fuvarokSzama));
        }

        private void tavolsagbtn_Click(object sender, RoutedEventArgs e)
        {
            List<Fuvar> Fuvarok = new List<Fuvar>();
            File.ReadAllLines("fuvar.csv").Skip(1).ToList().ForEach(x => new Fuvar(x));

            double osszesKm = Fuvarok.Sum(x => x.MegtettTavolsag);
            osszesKm = Math.Round( osszesKm * 1.6,2);
            MessageBox.Show(Convert.ToString(osszesKm));
        }

        private void leghosszabbbtn_Click(object sender, RoutedEventArgs e)
        {
            List<Fuvar> Fuvarok = new List<Fuvar>();
            File.ReadAllLines("fuvar.csv").Skip(1).ToList().ForEach(x => new Fuvar(x));

            Fuvar leghosszabb = Fuvarok.Find(x => x.UtazasTartam == Fuvarok.Max(x => x.UtazasTartam));

            MessageBox.Show(Convert.ToString(leghosszabb));
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            List<Fuvar> Fuvarok = new List<Fuvar>();
            File.ReadAllLines("fuvar.csv").Skip(1).ToList().ForEach(x => new Fuvar(x));
            try
            {
                int fuvarSzam = Convert.ToInt32(adatTxt.Text);

                double bevetel = Fuvarok.Where(x => x.TaxiAzon == fuvarSzam).Sum(x => x.Viteldij + x.Borravalo);
                MessageBox.Show(Convert.ToString(bevetel));
            }
            catch (Exception)
            {

                MessageBox.Show("Egész számot adjon meg");
            }

        }
    }

}
