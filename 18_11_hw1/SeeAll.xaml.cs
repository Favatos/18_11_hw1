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
using System.Windows.Shapes;
using System.Xml;

namespace _18_11_hw1
{
    /// <summary>
    /// Логика взаимодействия для SeeAll.xaml
    /// </summary>
    public partial class SeeAll : Window
    {
        public SeeAll()
        {
            InitializeComponent();
            DataContext = new ObservableCollection < Product >{ };
        }

        private void ButtonAdd_Click(object sender, RoutedEventArgs e)
        {
            Add add = new Add(new Product());
            if(add.ShowDialog() == true)
            {
                ((ObservableCollection<Product>)DataContext).Add((Product)add.DataContext);
            }

        }

        private void ButtonChange_Click(object sender, RoutedEventArgs e)
        {
            if (listbox.SelectedItem == null) return;
            Add add = new Add((Product)listbox.SelectedItem);
            int index = listbox.SelectedIndex;
            if (add.ShowDialog() == true)
            {
                ((ObservableCollection<Product>)DataContext)[index] = (Product)add.DataContext;
            }
        }
    }
}
