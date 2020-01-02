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
    /// Window1.xaml etkileşim mantığı
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            kiralasatinal kiralamasatinalma = new kiralasatinal();

            kiralamasatinalma.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            kiralasatinal kiralamasatinalma = new kiralasatinal();

            kiralamasatinalma.Show();
        }

        private void button13_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void closeWindow(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void siparistakip_Click(object sender, RoutedEventArgs e)
        {
            siparistakip st = new siparistakip();

            st.Show();
        }

        private void button12_Click(object sender, RoutedEventArgs e)
        {
            Elbise_Ekleme ee = new Elbise_Ekleme();

            ee.Show();
        }
    }
}
