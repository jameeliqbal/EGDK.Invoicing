using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.Design.AxImporter;
using System.ComponentModel.Design.Serialization;
using EGDK.Invoicing.Core;
using EGDK.Invoicing.Core.Services;
using EGDK.Invoicing.Data;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using EGDK.Invoicing.Services;
using Microsoft.Extensions.Configuration;
using EGDK.Invoicing.WinCS.Categories;
using EGDK.Invoicing.WinCS.Products;
using EGDK.Invoicing.WinCS.Customers;
using EGDK.Invoicing.WinCS.Invoices;

namespace EGDK.Invoicing.WinCS
{
    internal static class Program
    {
          public static IServiceProvider ServiceProvider { get; private set; }
      /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();


            var host = CreateHostBuilder().Build();
            ServiceProvider = host.Services;
      

            Application.Run(new MainForm());
        }

       static IHostBuilder CreateHostBuilder()
        {
            var builder = new ConfigurationBuilder();
            builder.SetBasePath(Directory.GetCurrentDirectory())
                   .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);

            IConfiguration config = builder.Build();
            string connectionString = config["ConnectionStrings:Default"];

            return Host.CreateDefaultBuilder().ConfigureServices(
                 (hostContext, services) =>
                 {
                     services.AddDbContext<EGInvoicingDBContext>(
                         (hcontext, options) =>
                         {
                             //'options.UseSqlServer(Configuration.GetConnectionString("Default"),
                             // 'Sub(x)
                             // '    x.MigrationsAssembly("MyMusic.Data")
                             //  'End Sub)
                             //options.UseSqlServer("name=ConnectionStrings:Default",
                             //                     x => x.MigrationsAssembly("EGDK.Invoicing.DataCS")
                             //                     );

                             options.UseSqlServer(connectionString,
                                                  x => x.MigrationsAssembly("EGDK.Invoicing.DataCS")
                                                  );
                         });


                     services.AddScoped<IUnitOfWork, UnitOfWork>();

                     services.AddTransient<ICategoryService, CategoryService>();
                     services.AddTransient<IProductService, ProductService>();
                     services.AddTransient<ICustomerService, CustomerService>();
                     services.AddTransient<IInvoiceService, InvoiceService>();
                     
                     services.AddTransient<CategoryListForm>();
                     services.AddTransient<ProductsListForm>();
                     services.AddTransient<CustomerListForm>();
                     services.AddTransient<InvoiceListForm>();
                     services.AddTransient<InvoiceDetailsForm>();
                     services.AddTransient<InvoiceAddForm>();
                     services.AddTransient<InvoiceLineItemAddForm>();

                 });
    }
    }
}