using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dentro_fora {
    class Program {
        static void Main(string[] args) {

            int n, i, x, dentro, fora;

            Console.Write("Quantos numeros voce vai digitar? ");
            n = int.Parse(Console.ReadLine());
            
            dentro = 0;
            for (i = 0; i < n; i++) {
                Console.Write("Digite um numero: ");
                x = int.Parse(Console.ReadLine());
                if (x >= 10 && x <= 20) {
                    dentro = dentro + 1;
                }
            }

            fora = n - dentro;
            Console.WriteLine(dentro + " DENTRO.");
            Console.WriteLine(fora + " FORA.");
        }
    }
}
