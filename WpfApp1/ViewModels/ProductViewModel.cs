using DevExpress.Mvvm;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

using WpfApp1.Models;
using WpfApp1.Services;

namespace WpfApp1.ViewModels
{
    public class ProductViewModel : ViewModelBase, IProductViewModel
    {
        private readonly IProductsService _productService;
        private readonly ISaveAsService _saveAsService;
        public ObservableCollection<Products> Products { get; set; }
        public ObservableCollection<Products> Selections { get; } = new ObservableCollection<Products>();
        public DelegateCommand SaveAsCSV { get; private set; }
        public DelegateCommand SaveAsTXT { get; private set; }
        public ProductViewModel(IProductsService productService, ISaveAsService saveAsService)
        {
            _productService = productService;
            _saveAsService = saveAsService;
            SaveAsService service = new SaveAsService();
            Products = new ObservableCollection<Products>();
            _productService.List().ForEach(productItem =>
            {
                Products.Add(productItem);
            });
            SaveAsCSV = new DelegateCommand(() => _saveAsService.SaveAsCSVFile(Selections));
            SaveAsTXT = new DelegateCommand(() => _saveAsService.SaveAsTXTFile(Selections));
        }
    }
}
