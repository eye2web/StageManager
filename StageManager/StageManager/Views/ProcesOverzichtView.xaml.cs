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

namespace StageManager.Views
{
    /// <summary>
    /// Interaction logic for ProcesOverzichtView.xaml
    /// </summary>
    public partial class ProcesOverzichtView : UserControl
    {
        ObservableCollection<PDummy> StudentGegevensCollection { get; set; }

        public ProcesOverzichtView()
        {
            InitializeComponent();

            StudentGegevensCollection = new ObservableCollection<PDummy>();
            StudentGegevensCollection.Add(new PDummy("", "m.aydin4@student.avans.nl", "Aydin, Murat", "Hyacinthenstraat 15", "Ingeleverd", "In orde", "Bob Bus"));
            StudentGegevensCollection.Add(new PDummy("", "r.baas1@student.avans.nl", "Rosan, Baas", "Bovenhof 1", "Ingeleverd", "In orde", "Bob van der Putten"));
            StudentGegevensCollection.Add(new PDummy("", "tjm.vandenberg@student.avans.nl", "Berg van den, Thomas", "Dreef 48", "Ingeleverd", "In orde", "Bob Bus"));
            StudentGegevensCollection.Add(new PDummy("", "b.bijl@student.avans.nl", "Bijl, Benny", "Zoutelandehoeve 14", "Ingeleverd", "In orde", "Bob van der Putten"));
            StudentGegevensCollection.Add(new PDummy("", "r.blok@student.avans.nl", "Blok, Robin", "Bevrijdingslaan 18", "Ingeleverd", "In orde", "Ger Saris"));
            StudentGegevensCollection.Add(new PDummy("", "l.tenboden@student.avans.nl", "Boden ten, Liza", "Dijkmanzoet 90", "Nog in te leveren", "Nog uitbreiden", "Ger Saris"));

            listView.ItemsSource = StudentGegevensCollection;
        }

    }

    public class PDummy
    {
        public string EmailURL { get; set; }
        public string Email { get; set; }
        public string StudentNaam { get; set; }
        public string Gegevens { get; set; }
        public string Stageopdracht { get; set; }
        public string Feedback { get; set; }
        public string Docent { get; set; }

        public PDummy(string url, string email, string naam, string gegevens, string opdracht, string feedback, string docent)
        {
            EmailURL = url;
            Email = email;
            StudentNaam = naam;
            Gegevens = gegevens;
            Stageopdracht = opdracht;
            Feedback = feedback;
            Docent = docent;
        }
    }
}
