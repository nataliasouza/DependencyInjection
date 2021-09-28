using Microsoft.Extensions.DependencyInjection;
using System;

namespace DI_Nativo
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ServiceProvider container = RegistrarServices())
            {
                var controller = container.GetRequiredService<Controller>();
                string resultado = controller.Ola("Macoratti");
                Console.WriteLine(resultado);
            }
        }
        static ServiceProvider RegistrarServices()
        {
            var services = new ServiceCollection();
            services.AddSingleton<IRecepcaoService, RecepcaoService>();
            services.AddTransient<Controller>();
            return services.BuildServiceProvider();
        }
    }
}
