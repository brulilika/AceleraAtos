using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadesAula3
{
    internal class CalculadoraBasica
    {
        public CalculadoraBasica()
        {
            MenuCalculadora();
        }

        private void MenuCalculadora()
        {
            Console.Clear();
            Console.WriteLine("Menu de Calculadora Básica\nDigite operação desejada: ");
            Console.WriteLine("1- Soma");
            Console.WriteLine("2- Subtração");
            Console.WriteLine("3- Multiplicação");
            Console.WriteLine("4- Divisão");
            Console.WriteLine("5- Voltar Menu Principal");
            string resp = Console.ReadLine();
            RedirecionaComando(resp);
        }

        private void RedirecionaComando(string comando)
        {
            try
            {
                int operacao = Convert.ToInt32(comando);
                switch (operacao)
                {
                    //Soma
                    case 1:
                        ExecutaSoma();
                        break;
                    //Subtracao
                    case 2:
                        ExecutaSubtracao();
                        break;
                    //Multiplicacao
                    case 3:
                        ExecutaMultiplicacao();
                        break;
                    //Divisao
                    case 4:
                        ExecutaDivisao();
                        break;
                    //Volta principal
                    case 5:
                        ValidaRetorno();
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Não foi possível executar operação. Insira um comando válido ");
                        Console.ReadLine();
                        MenuCalculadora();
                        break;
                }
            }
            catch (Exception)
            {
                Console.Clear();
                Console.WriteLine("Não foi possível executar operação. Insira um comando ou valores válidos ");
                Console.ReadLine();
                MenuCalculadora();
            }
        }

        private void ExecutaSoma()
        {
            Console.Clear();
            Console.WriteLine("SOMA");
            Console.WriteLine("Primeiro valor: ");
            var primeiro = Console.ReadLine();
            Console.WriteLine("Segundo valor: ");
            var segundo = Console.ReadLine();
            Console.WriteLine($"Somatório: {Convert.ToDecimal(primeiro) + Convert.ToDecimal(segundo)}");
            ValidaRetorno();
        }

        private void ExecutaSubtracao()
        {
            Console.Clear();
            Console.WriteLine("SUBTRACAO");
            Console.WriteLine("Primeiro valor: ");
            var primeiro = Console.ReadLine();
            Console.WriteLine("Segundo valor: ");
            var segundo = Console.ReadLine();
            Console.WriteLine($"Substração: {Convert.ToDecimal(primeiro) - Convert.ToDecimal(segundo)}");
            ValidaRetorno();
        }

        private void ExecutaMultiplicacao()
        {
            Console.Clear();
            Console.WriteLine("MULTIPLICACAO");
            Console.WriteLine("Primeiro valor: ");
            var primeiro = Console.ReadLine();
            Console.WriteLine("Segundo valor: ");
            var segundo = Console.ReadLine();
            Console.WriteLine($"Multiplicação: {Convert.ToDecimal(primeiro) * Convert.ToDecimal(segundo)}");
            ValidaRetorno();
        }

        private void ExecutaDivisao()
        {
            Console.Clear();
            Console.WriteLine("DIVISÃO");
            Console.WriteLine("Primeiro valor: ");
            var primeiro = Console.ReadLine();
            Console.WriteLine("Segundo valor: ");
            var segundo = Console.ReadLine();
            Console.WriteLine($"Divisão: {Convert.ToDecimal(primeiro) / Convert.ToDecimal(segundo)}");
            ValidaRetorno();
        }

        private void ValidaRetorno()
        {
            Console.WriteLine("Deseja sair do Menu da Calculadora? (S/N) ");
            var resp = Console.ReadLine();
            if (!string.IsNullOrEmpty(resp) && resp.Contains("s", StringComparison.CurrentCultureIgnoreCase))
                new MenuPrincipal();
            else
                MenuCalculadora();
        }
    }
}
