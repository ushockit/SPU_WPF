using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
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
using WpfApp1.Models;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        /*
            ВАЖНО!!! Привязка может быть выполнена только к public св-вам
        */
        public event PropertyChangedEventHandler PropertyChanged;
        private string _textValue = string.Empty;
        private string _inputCountry = string.Empty;
        public string TextValue
        {
            get => _textValue;
            set
            {
                if (!value.Equals(_textValue))
                {
                    _textValue = value;
                    OnPropertyChanged(nameof(TextValue));
                }
            }
        }
        public string InputCountry
        {
            get => _inputCountry;
            set
            {
                if (!value.Equals(_inputCountry))
                {
                    _inputCountry = value;
                    OnPropertyChanged(nameof(InputCountry));
                }
            }
        }

        public double WindowHeight { get; set; } = 700;
        public double WindowWidth { get; set; } = 1000;

        public ObservableCollection<string> Countries { get; set; } = new ObservableCollection<string>
        {
            "США", "Украина", "Беларусь", "Германия", "Франция"
        };
        public ObservableCollection<ProductModel> Products { get; set; } = new ObservableCollection<ProductModel>
        {
            new ProductModel
            {
                Id = 1,
                Title = "Title 1",
                Description = "Description 1",
                Image = "https://img.icons8.com/bubbles/2x/fa314a/product.png",
                Price = 100.5m
            },
            new ProductModel
            {
                Id = 2,
                Title = "Title 2",
                Description = "Description 2",
                Image = "https://img.icons8.com/plasticine/2x/fa314a/product.png",
                Price = 200.5m
            },
        };

        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ;
        }

        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }

        private void ButtonAddCountry_Click(object sender, RoutedEventArgs e)
        {
            Countries.Add(InputCountry);
            InputCountry = string.Empty;
        }

        private void ButtonAddProduct_Click(object sender, RoutedEventArgs e)
        {
            Products.Add(new ProductModel
            {
                Id = 2,
                Title = "Title 2",
                Description = "Description 2",
                Image = "https://img.icons8.com/plasticine/2x/fa314a/product.png",
                Price = 300
            });
        }

        private void StackPanel_MouseDown(object sender, MouseButtonEventArgs e)
        {
            var product = (sender as StackPanel).DataContext as ProductModel;
            if (e.ClickCount == 2)
            {
                Products.Remove(product);
            }
        }
    }
}
