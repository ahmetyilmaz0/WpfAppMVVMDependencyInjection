using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using WpfApp1.Models;
using WpfApp1.Services;
using WpfApp1.ViewModels;
using WpfApp1.Views;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private ServiceProvider serviceProvider;
        public IServiceProvider ServiceProvider { get; private set; }

        public IConfiguration Configuration { get; private set; }

        public App()
        {
            ServiceCollection services = new ServiceCollection();
            ConfigureServices(services);
            serviceProvider = services.BuildServiceProvider();
        }
        protected override void OnStartup(StartupEventArgs e)
        {
            var scope = serviceProvider.CreateScope();
            var context = scope.ServiceProvider.GetRequiredService<ProductsDbContext>();
            DataGenerator.Initialize(context);

            var builder = new ConfigurationBuilder();

            Configuration = builder.Build();

            var serviceCollection = new ServiceCollection();
            ConfigureServices(serviceCollection);

            ServiceProvider = serviceCollection.BuildServiceProvider();

            var mainWindow = ServiceProvider.GetRequiredService<ProductWindow>();
            mainWindow.Show();
        }

        private static void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<ProductsDbContext>(options =>
                {
                    options.UseInMemoryDatabase(databaseName: "InMemoryDB");
                });
            services.AddSingleton<ProductWindow>();
            services.AddScoped<ISaveAsService, SaveAsService>();
            services.AddScoped<IProductsService, ProductsService>();
            services.AddScoped<IProductViewModel, ProductViewModel>();
        }

        //private void ConfigureServices(ServiceCollection services)
        //{
        //    services.AddDbContext<ProductsDbContext>(options =>
        //    {
        //        options.UseInMemoryDatabase(databaseName: "InMemoryDB");
        //    });
        //    //services.AddScoped<IRepositoryBase, RepositoryBase>();
        //    //services.AddScoped<IProductsService, ProductsService>();
        //    services.AddSingleton<MainWindow>();
        //}

        //private void OnStartup(object sender, StartupEventArgs e)
        //{
        //    var scope = serviceProvider.CreateScope();
        //    var context = scope.ServiceProvider.GetRequiredService<ProductsDbContext>();
        //    DataGenerator.Initialize(context);

        //    var builder = new ConfigurationBuilder();

        //    Configuration = builder.Build();

        //    var serviceCollection = new ServiceCollection();
        //    ConfigureServices(serviceCollection);

        //    ServiceProvider = serviceCollection.BuildServiceProvider();

        //    var mainWindow = ServiceProvider.GetRequiredService<MainWindow>();
        //    mainWindow.Show();
        //    //var mainWindow = serviceProvider.GetService<MainWindow>();
        //    //mainWindow.Show();
        //}
    }
}
