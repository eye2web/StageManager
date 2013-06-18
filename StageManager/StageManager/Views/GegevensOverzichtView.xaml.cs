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
        public GegevensOverzichtView()
        {
            InitializeComponent();
        }

        private void btnExport_Click(object sender, RoutedEventArgs e)
        {
            ExportExcel ee = new ExportExcel(this);
            ee.Export();
        }

        public void createWorksheet(Microsoft.Office.Interop.Excel.Worksheet worksheet)
        {
            /*
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
             */ 
        }
    }
}