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
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfApp1.Services;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //private readonly IProductsService _employeeService;

        public MainWindow()
        {
            //this._employeeService = employeeService;
            InitializeComponent();
            //GetEmployees();
        }

        //private async void GetEmployees()
        //{
        //    var employees = dbContext.Employee.ToList();
        //    var employees = await _employeeService.List();
        //    EmployeeDG.ItemsSource = employees;
        //}
    }
}
