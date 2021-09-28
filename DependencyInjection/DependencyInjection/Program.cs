using System;

namespace DependencyInjection
{
    class Program
    {
        static void Main(string[] args)
        {
            var controller = new Controller(new RecepcaoService());
            string resultado = controller.Ola("Natt Souza!!!");
            Console.WriteLine(resultado);
            Console.ReadLine();
        }
    }
}
