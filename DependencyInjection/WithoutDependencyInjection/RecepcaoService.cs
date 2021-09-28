using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WithoutDependencyInjection
{
    public class RecepcaoService
    {
        public string Saudacao(string nome) => $"Olá, {nome}";
    }
}
