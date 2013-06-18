using StageManager.Services;
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
    public partial class GegevensOverzichtView : UserControl, IExcelAlgorithm
    {
        ObservableCollection<PGDummy> Collection { get; set; }

        public GegevensOverzichtView()
        {
            InitializeComponent();

            Collection = new ObservableCollection<PGDummy>();

            /*
            Collection.Add(new PGDummy(4022335, "Achternaam", "Voorvoegsels", "roepnaam", "emailurl", "email", "straatnaam", 0, "toevoeging", "postcode", "plaats", "telefoonnummer", "slb61", "slb62", "slb63", "slb6t", "slb71",
                "slb72", "slb7t", 2, "p", "eps", "formgoed", "toestex", "stagecontract", "docent", "bijzonderheden", "bedrijf", "branche", "bstraat", 14, "btoevoeging", "bpostcode", "bplaats", "bland", "bedrijfsbegeleider",
                "bemailurl", "bemail", "btelefoon", "begtelefoon", "website"));
             */

            Collection.Add(new PGDummy(2043161, "Aydin", "", "Murat", "", "m.aydin4@student.avans.nl", "Hyacinthenstraat", 15, "", "5462 AE", "Veghel", "", "", "", "", "", "",
                "", "", 0, "ja", "", "", "", "", "", "", "", "", "", 0, "", "", "", "", "", "", "", "", "", ""));

            Collection.Add(new PGDummy(2048620, "Baas", "", "Rosan", "", "r.baas1@student.avans.nl", "Bovenhof", 1, "", "5275 CN", "Den Dungen", "", "", "", "", "", "",
                "", "", 0, "ja", "", "", "", "", "", "", "", "", "", 0, "", "", "", "", "", "", "", "", "", ""));

            Collection.Add(new PGDummy(2000606, "Berg", "van den", "Thomas", "", "tjm.vandenberg@student.avans.nl", "Dreef", 48, "", "4875 AC", "Etten-Leur", "", "", "", "", "", "",
                "", "", 0, "ja", "", "", "", "", "", "", "", "", "", 0, "", "", "", "", "", "", "", "", "", ""));

            Collection.Add(new PGDummy(2052712, "Bijl", "", "Benny", "", "b.bijl@student.avans.nl", "Zoutelandehoeve", 14, "", "3137 EM", "Vlaardingen", "", "", "", "", "", "",
                "", "", 0, "ja", "", "", "", "", "", "", "", "", "", 0, "", "", "", "", "", "", "", "", "", ""));

            Collection.Add(new PGDummy(2042135, "Blok", "", "Robin", "", "r.blok@student.avans.nl", "Bevrijdingslaan", 18, "", "4001 HZ", "Tiel", "", "Vrijstelling", "", "", "", "",
                "", "", 0, "ja", "", "", "", "", "", "", "", "", "", 0, "", "", "", "", "", "", "", "", "", ""));

            Collection.Add(new PGDummy(2048172, "Boden", "ten", "Liza", "", "t.tenboden@student.avans.nl", "Dijkmanzoet", 90, "", "4007 XJ", "Tiel", "", "Heeft al stage gelopen? Is 3e jaars", "", "", "", "",
                "", "", 0, "ja", "", "", "", "", "", "", "", "", "", 0, "", "", "", "", "", "", "", "", "", ""));

            listView.ItemsSource = Collection;
        }

        private void btnExport_Click(object sender, RoutedEventArgs e)
        {
            ExportExcel ee = new ExportExcel(this);
            ee.Export();
        }

        public void createWorksheet(Microsoft.Office.Interop.Excel.Worksheet worksheet)
        {
            int i = 1;
            int j = 1;

            worksheet.Cells[i, j] = "StudentNummer";
            worksheet.Cells[i, j + 1] = "Achternaam";
            worksheet.Cells[i, j + 2] = "Voorvoegsels";
            worksheet.Cells[i, j + 3] = "Roepnaam";
            worksheet.Cells[i, j + 4] = "EmailURL";
            worksheet.Cells[i, j + 5] = "Email";
            worksheet.Cells[i, j + 6] = "Straatnaam";
            worksheet.Cells[i, j + 7] = "Nummer";
            worksheet.Cells[i, j + 8] = "Toevoeging";
            worksheet.Cells[i, j + 9] = "Postcode";
            worksheet.Cells[i, j + 10] = "Plaats";

            i++;

            foreach (PGDummy item in listView.Items)
            {
                worksheet.Cells[i, j] = item.StudentNummer;
                worksheet.Cells[i, j + 1] = item.Achternaam;
                worksheet.Cells[i, j + 2] = item.Voorvoegsels;
                worksheet.Cells[i, j + 3] = item.Roepnaam;
                worksheet.Cells[i, j + 4] = item.EmailURL;
                worksheet.Cells[i, j + 5] = item.Email;
                worksheet.Cells[i, j + 6] = item.Straatnaam;
                worksheet.Cells[i, j + 7] = item.Nummer;
                worksheet.Cells[i, j + 8] = item.Toevoeging;
                worksheet.Cells[i, j + 9] = item.Postcode;
                worksheet.Cells[i, j + 10] = item.Plaats;

                i++;
            }
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