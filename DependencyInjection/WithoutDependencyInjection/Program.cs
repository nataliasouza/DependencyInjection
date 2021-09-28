using System;

namespace WithoutDependencyInjection
{
    class Program
    {
        static void Main(string[] args)
        {
            var controller = new Controller();
            string resultado = controller.Ola("Natt Souza");
            Console.WriteLine(resultado);
            Console.ReadLine();
        }
    }
}
