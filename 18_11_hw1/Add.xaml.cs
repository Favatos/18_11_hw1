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

namespace _18_11_hw1
{
    /// <summary>
    /// Логика взаимодействия для Add.xaml
    /// </summary>
    public partial class Add : Window
    {
        public Add(Product product)
        {
            InitializeComponent();
            DataContext = new Product() {Name = product.Name, Amount = product.Amount, MeasureUnit = product.MeasureUnit };
            combobox.ItemsSource = Enum.GetValues(typeof(MeasureUnits));
        }

        private void ButtonOk_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
        }

        private void ButtonCansel_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
        }
    }
}
