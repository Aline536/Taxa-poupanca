using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxaPopanca
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculo de rendimento Insira o valor R$");

            
            //taxa poupança mensal = 0.5;

            NovoCalculo NovoValor = new NovoCalculo ();

            NovoValor.valor =  double.Parse(Console.ReadLine ());

            double taxa = NovoValor.valor * 0.5 / 100 ;

            Console.WriteLine( "O Valor de rendimento por mês será: " + taxa);
            Console.WriteLine("Execução finalizada tecle enter ...");

          
            Console.ReadLine();

        }
    }
}
