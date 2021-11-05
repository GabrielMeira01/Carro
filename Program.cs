using System;
using Carro.Objeto;

namespace Carro
{
    class Program
    {
        static void Main(string[] args)
        {
            var Carro = new Carros("Fusca", 4);
            Console.WriteLine("Modelo: " + Carro.Modelo + " Quantidade de portas: " + Carro.QuantidadePortas);
        }
    }
}
