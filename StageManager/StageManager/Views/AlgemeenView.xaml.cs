using System;
using System.Collections.Generic;
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
using System.Windows.Shapes;

namespace StageManager.Views
{
    /// <summary>
    /// Interaction logic for AlgemeenView.xaml
    /// </summary>
    public partial class AlgemeenView : Window
    {

        public AlgemeenView()
        {
            InitializeComponent();
            Show();
        }

        public String Jaargang
        {
            get { return jaargang.ToString(); }
        }

        public String Werkuren
        {
            get { return werkuren.ToString(); }
        }

        public String AantBlokken
        {
            get { return aantBlokken.ToString(); }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

    }
}
