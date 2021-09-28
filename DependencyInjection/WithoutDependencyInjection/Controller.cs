using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WithoutDependencyInjection
{
     public class Controller
    {
        public string Ola(string nome)
        {
            var service = new RecepcaoService();
            return service.Saudacao(nome);
        }
    }
}
