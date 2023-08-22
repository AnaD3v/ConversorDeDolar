using System;
using Dolar;
using System.Globalization;

namespace Dolar {
    internal class Program {
        static void Main(string[] args) {

            Console.WriteLine("Qual é a cotação do dolar? ");
            double x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Quantos dólares você vai comprar? ");
            double y = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            double resultado = ConversorDeMoedas.Valor(x, y);
            double porcentagem = ConversorDeMoedas.ValorTotal(resultado);

            Console.WriteLine("\nValor a ser pago em reais: " + porcentagem.ToString("F2", CultureInfo.InvariantCulture));


        }
    }
}