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
    /// Interaction logic for GegevensOverzichtView.xaml
    /// </summary>
    public partial class GegevensOverzichtView : UserControl
    {
        ObservableCollection<PGDummy> Collection { get; set; }

        public GegevensOverzichtView()
        {
            InitializeComponent();

            Collection = new ObservableCollection<PGDummy>();
            //Collection.Add(new PGDummy("", "m.aydin4@student.avans.nl", "Aydin, Murat", "Hyacinthenstraat 15", "Ingeleverd", "In orde", "Bob Bus"));

            listView.ItemsSource = Collection;
        }
    }

    public class PGDummy
    {
        public int StudentNummer { get; set; }
        public string Achternaam { get; set; }
        public string Voorvoegsels { get; set; }
        public string Roepnaam { get; set; }
        public string EmailURL { get; set; }
        public string Email { get; set; }
        public string Straatnaam { get; set; }
        public int Nummer { get; set; }
        public string Toevoeging { get; set; }
        public string Postcode { get; set; }
        public string Plaats { get; set; }
        public string Telefoonnummer { get; set; }
        public string SLB61 { get; set; }
        public string SLB62 { get; set; }
        public string SLB63 { get; set; }
        public string SLB6T { get; set; }
        public string SLB71 { get; set; }
        public string SLB72 { get; set; }
        public string SLB7T { get; set; }
        public int EC { get; set; }
        public string P { get; set; }
        public string EPS { get; set; }
        public string FormGoed { get; set; }
        public string ToestEx { get; set; }
        public string Stagecontract { get; set; }
        public string Docent { get; set; }
        public string Bijzonderheden { get; set; }
        public string Bedrijf { get; set; }
        public string Branche { get; set; }
        public string BStraat { get; set; }
        public int BNummer { get; set; }
        public string BToevoeging { get; set; }
        public string BPostcode { get; set; }
        public string BPlaats { get; set; }
        public string BLand { get; set; }
        public string Bedrijfsbegeleider { get; set; }
        public string BEmailURL { get; set; }
        public string BEmail { get; set; }
        public string BTelefoon { get; set; }
        public string BegTelefoon { get; set; }
        public string Website { get; set; }

        public PGDummy(int studentnummer, string achternaam, string voorvoegsels, string roepnaam, string emailurl, string email, string straatnaam, int nummer, string toevoeging, string postcode, string plaats, 
            string telefoonnummer, string slb61, string slb62, string slb63, string slb6t, string slb71, string slb72, string slb7t, int ec, string p, string eps, string formgoed, string toestex, string stagecontract,
            string docent, string bijzonderheden, string bedrijf, string branche, string bstraat, int bnummer, string btoevoeging, string bpostcode, string bplaats, string bland, string bedrijfsbegeleider, string bemailurl, 
            string bemail, string btelefoon, string begtelefoon, string website)
        {
            StudentNummer = studentnummer;
            Achternaam = achternaam;
            Voorvoegsels = voorvoegsels;
            Roepnaam = roepnaam;
            EmailURL = emailurl;
            Email = email;
            Straatnaam = straatnaam;
            Nummer = nummer;
            Toevoeging = toevoeging;
            Postcode = postcode;
            Plaats = plaats;
            Telefoonnummer = telefoonnummer;
            SLB61 = slb61;
            SLB62 = slb62;
            SLB63 = slb63;
            SLB6T = slb6t;
            SLB71 = slb71;
            SLB72 = slb72;
            SLB7T = slb7t;
            EC = ec;
            P = p;
            EPS = eps;
            FormGoed = formgoed;
            ToestEx = toestex;
            Stagecontract = stagecontract;
            Docent = docent;
            Bijzonderheden = bijzonderheden;
            Bedrijf = bedrijf;
            Branche = branche;
            BStraat = bstraat;
            BNummer = bnummer;
            BToevoeging = btoevoeging;
            BPostcode = bpostcode;
            BPlaats = bplaats;
            BLand = bland;
            Bedrijfsbegeleider = bedrijfsbegeleider;
            BEmailURL = bemailurl;
            BEmail = bemail;
            BTelefoon = btelefoon;
            BegTelefoon = begtelefoon;
            Website = website;
        }
    }
}
