using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeAula4
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
            Console.WriteLine("1 - Controle de estudantes");
            var resp = Console.ReadLine();

            switch (resp)
            {
                case "1":
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
