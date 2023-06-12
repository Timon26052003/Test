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
using Ekzamen.Models;
using Ekzamen.Windows;
using Ekzamen.Properties;


namespace Ekzamen.Windows
{
    /// <summary>
    /// Логика взаимодействия для VhodYchactniki.xaml
    /// </summary>
    public partial class VhodYchactniki : Window
    {
        
        public VhodYchactniki()
        {
            InitializeComponent();
            Class1.DD = new Ekzamen2Entities();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Vhod_Click(object sender, RoutedEventArgs e)
        {

            if (Log.Text == "techie@outlook.com" && Pass.Text == "tKKevv8%")
            {
                Ychactniki v = new Ychactniki();
                v.Show();
                this.Close();
            }
            else MessageBox.Show("Данные введены не верно");
        }
    }
}
