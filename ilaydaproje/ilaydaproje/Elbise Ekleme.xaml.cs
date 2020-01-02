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
    /// Elbise_Ekleme.xaml etkileşim mantığı
    /// </summary>
    public partial class Elbise_Ekleme : Window
    {
        public Elbise_Ekleme()
        {
            InitializeComponent();
        }

        private void textbox1_TextChanged(object sender, TextChangedEventArgs e)
        {
            string urunmarkasi = textbox1.Text;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Ürün bilgileri başarıyla kaydedildi.", "İşlem başarılı!");
        }

        private void Button_Click_12(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
