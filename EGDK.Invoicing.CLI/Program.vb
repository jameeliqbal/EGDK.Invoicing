Imports System
Imports Microsoft.Extensions.DependencyInjection
Imports EGDK.Invoicing.Data
Imports EGDK.Invoicing.Core
Imports EGDK.Invoicing.Core.Services
Imports Microsoft.Extensions.Hosting
Imports Microsoft.EntityFrameworkCore
Imports EGDK.Invoicing.Services
Module Program
    Sub Main(args As String())

        Dim host = CreateHostBuilder().Build()

        host.RunAsync()
        Console.WriteLine("List of Categories")

    End Sub

    Function CreateHostBuilder() As IHostBuilder

        Return Host.CreateDefaultBuilder().ConfigureServices(
            Sub(hostContext, services)
                services.AddDbContext(Of EGInvoicingDBContext)(
                    Sub(hcontext, options)
                        'options.UseSqlServer(Configuration.GetConnectionString("Default"),
                        'Sub(x)
                        '    x.MigrationsAssembly("MyMusic.Data")
                        'End Sub)
                        options.UseSqlServer("name=ConnectionStrings:Default",
                                             Sub(x)
                                                 x.MigrationsAssembly("EGDK.Invoicing.DataCS")
                                             End Sub
                                             )
                    End Sub
                    )
                services.AddScoped(Of IUnitOfWork, UnitOfWork)()
                services.AddTransient(Of ICategoryService, CategoryService)
            End Sub)
    End Function
End Module
