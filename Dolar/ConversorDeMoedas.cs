using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dolar {
    class ConversorDeMoedas {
        public static double Valor(double x, double y) {

            return x * y; //620
        }
        public static double ValorTotal(double resultado) {

            double porcentagem = 6.0 / 100.0; //6% decimal
            double valorDaPorcentagem = resultado * porcentagem;
            double total = valorDaPorcentagem + resultado; // Adicionando a porcentagem ao valor original.
           
            return total;
        }
    }
}