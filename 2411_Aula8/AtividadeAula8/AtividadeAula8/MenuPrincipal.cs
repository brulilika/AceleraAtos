using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeAula8
{
    public class MenuPrincipal
    {
        public MenuPrincipal()
        {
            InicializaMenuPrincipal();
        }

        private void InicializaMenuPrincipal()
        {
            Console.Clear();
            Console.WriteLine("Digite o exercício que deseja avaliar: ");
            Console.WriteLine("1 - Avaliação de código compartilhado");
            Console.WriteLine("2 - Programa com interfaces, classes abstratas. Métodos publicos, privados, abstratos, virtuais e protegidos");
            Console.WriteLine("3 - Controle de estudantes - Classe e lista de Alunos");
            var resp = Console.ReadLine();

            switch (resp)
            {
                case "1":
                    new Exercicio1();
                    break;
                case "2":
                    new Exercicio2();
                    break;
                case "3":
                    new Exercicio3();
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
