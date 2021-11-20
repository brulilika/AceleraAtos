using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadesAula3
{
    internal class MenuPrincipal
    {
        public MenuPrincipal()
        {
            InicializaMenuPrincipal();
        }

        private void InicializaMenuPrincipal()
        {
            Console.Clear();
            Console.WriteLine("Digite o exercício que deseja avaliar: ");
            Console.WriteLine("1 - Transcrição de saída do programa");
            Console.WriteLine("2 - Calculadora básica");
            Console.WriteLine("3 - Controle de estudantes");
            var resp = Console.ReadLine();

            switch (resp)
            {
                case "1":
                    new Exercicio1();
                    break;
                case "2":
                    new CalculadoraBasica();
                    break;
                case "3":
                    new ManipulacaoEstudante();
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Entrada não validada. Digite qualquer tecla para voltar ao Menu.");
                    Console.ReadLine();
                    InicializaMenuPrincipal();
                    break;
            }
        }
    }
}
