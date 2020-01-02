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

namespace ilaydaproje
{
    /// <summary>
    /// siparistakip.xaml etkileşim mantığı
    /// </summary>
    public partial class siparistakip : Window
    {
        public siparistakip()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string siparisno = textbox1.Text;
            if (siparisno == "1" || siparisno == "7" ) 
            {
                tb1.Text = "Siparişiniz tedarik aşamasında.";
                
            } else
            {
                tb1.Text = "Geçersiz sipariş numarası.";
            }
        }
    }
}
