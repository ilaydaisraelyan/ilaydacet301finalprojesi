﻿using System;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ilaydaproje
{
    /// <summary>
    /// MainWindow.xaml etkileşim mantığı
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string kullaniciadi = textbox1.Text;
            string parola = textbox2.Password;

            if(kullaniciadi == "ilayda" && parola == "israelyan")
            {
                Window1 userpage = new Window1();

                userpage.Show();
            } else
            {
                MessageBox.Show("Kullanıcı bilgileri yanlış. Tekrar deneyiniz.", "Hata!");
            }
        }

        private void textbox1_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
