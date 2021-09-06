using DevExpress.Xpf.Grid;
using DevExpress.Xpf.Bars;
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
using WpfApp1.ViewModels;
using WpfApp1.Models;
using WpfApp1.Services;

namespace WpfApp1.Views
{
    /// <summary>
    /// Interaction logic for ProductWindow.xaml
    /// </summary>
    public partial class ProductWindow : Window
    {
        private readonly IProductViewModel _productViewModel;
        public ProductWindow(IProductViewModel productViewModel,ISaveAsService saveAsService)
        {
            InitializeComponent();
            this._productViewModel = productViewModel;
            DataContext = productViewModel;
        }
    }
}
