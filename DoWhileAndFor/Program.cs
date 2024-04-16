using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace DoWhileAndFor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* do while
            string resp;
            double total = 0;

            do
            {
                Console.WriteLine("Informe a despesa: ");
                string nome = Console.ReadLine();
                Console.WriteLine("Digite a sua despesa: R$");
                total += double.Parse(Console.ReadLine());
                Console.WriteLine("Deseja adicionar mais uma divida(s/n)? ");
                resp = Console.ReadLine().ToUpper();
                Console.Clear();    
            } 
            while (resp == "S" );

            Console.WriteLine("Quantas pessoas vivem na casa? ");
            int pessoa = int.Parse(Console.ReadLine());

            double fim = total/ pessoa;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Tera que pagar cada um " + fim.ToString("C"));
            Console.ReadKey();
            */



            /* Varios números sem repetir for
             for (int i = 1; i <= 9; i++)
             {
                 Console.Write(i);
                 for (int j = 1; j <= 9; j++)
                 {
                     if (i != j)
                     {
                         Console.Write(j);
                     }
                 }
                 Console.WriteLine("");


             }
             Console.ReadKey();
            */

            int prec;
            double total = 0;
            string resp = "S";
            int inte = 0;
            int me = 0;
            for (int i = 1; i <= 30; i++)
            {
                if ( i <= 10) 
                {
                    prec = 100;
                }
                else if (i <= 20) 
                {
                    prec = 150;
                }
                else
                {
                     prec = 200;
                }
              
                Console.Write("cliente n" + i +"°, o ingresso custa " + prec.ToString("C") + ", por acaso você é estudante(s/n)? ");
                resp = Console.ReadLine().ToUpper();
                
                if ( resp == "S" )                 
                {
                    total += prec/2;
                    me++;
                }
                else
                {
                    total += prec;
                    inte++;
                }
                Console.Clear();
            }

            Console.WriteLine("Pessoas que pagaram integralmente: " + inte);
            Console.WriteLine("Pessoas que pagaram meia entrada: " + me);
            Console.WriteLine("Valor total de venda: " + total.ToString("C"));
            Console.ReadKey();
        }
    }
}
