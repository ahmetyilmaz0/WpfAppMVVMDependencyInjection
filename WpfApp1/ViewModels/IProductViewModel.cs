using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp1.Models;

namespace WpfApp1.ViewModels
{
    public interface IProductViewModel
    {
        public ObservableCollection<Products> Products { get; set; }
    }
}
