using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadesAula3
{
    internal class Exercicio1
    {
        public Exercicio1()
        {
            int[] arr = { 1, 4, 5 };
            Console.WriteLine("Dentro do Main, antes de chamar o metodo muda, o primeiro elemento é: {0}", arr[0]);
            Muda(arr);
            Console.WriteLine("Dentro do Main, apos chamar o metodo muda, o primeiro elemento é: {0}", arr[0]);

            Console.WriteLine("A mudança se deve pela atribuição realizada na posição 0 do array passado por " +
                              "parâmetro, que por sua vez, por padrão é do tipo valor");
            Console.WriteLine("Deseja sair do Exercicio 1? (S/N) ");
            var resp = Console.ReadLine();
            if (!string.IsNullOrEmpty(resp) && resp.Contains("s", StringComparison.CurrentCultureIgnoreCase))
                new MenuPrincipal();
            else
                new Exercicio1();
        }

        private void Muda(int [] pArray) 
        {
            pArray[0] = 888;
            pArray = new int[5] { -3, -1, -2, -3, -4 };
            Console.WriteLine("Dentro do metodo muda, o primeiro elemento é: {0}", pArray[0]);
        }
    }
}
