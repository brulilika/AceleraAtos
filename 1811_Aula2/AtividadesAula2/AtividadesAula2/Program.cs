namespace MyNamespace
{
    internal class Program
    {
        static void Main(string [] args)
        {
            MainMenu();
        }

        static void MainMenu()
        {
            Console.Clear();
            Console.WriteLine("Digite o exercício que deseja avaliar: ");
            var resp = Console.ReadLine();

            switch (resp)
            {
                case "1":
                    Exercicio1();
                    break;
                case "2":
                    Exercicio2();
                    break;
                case "3":
                    Exercicio3();
                    break;
                case "4":
                    Exercicio4();
                    break;
                case "5":
                    Exercicio5();
                    break;
                case "6":
                    Exercicio6();
                    break;
                case "7":
                    Exercicio7();
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Entrada não validada. Digite qualquer tecla para voltar ao Menu.");
                    Console.ReadLine();
                    MainMenu();
                    break;
            }
        }

        /// <summary>
        /// Declare variáveis tipo short, int, long, float, double, decimal
        /// Atribua valores inicialmente
        /// Receba valores pelo usuário e em seguida informe isso no console
        /// </summary>
        static void Exercicio1()
        {
            try
            {
                Console.Clear();
                Console.WriteLine("Atribuir valores iniciais para variáveis e depois receber elas e imprimir esses resultados");

                short valorShort = 2;
                int valorInt = 2;
                long valorLong = 2;
                float valorFloat = 2.0f;
                double valorDouble = 2.0d;
                decimal valorDecimal = 2.0m;

                Console.WriteLine("Insira valor short: ");
                string valorShortEntrada = Console.ReadLine();
                Console.WriteLine("Insira valor int: ");
                string valorIntEntrada = Console.ReadLine();
                Console.WriteLine("Insira valor long: ");
                string valorLongEntrada = Console.ReadLine();
                Console.WriteLine("Insira valor float: ");
                string valorFloatEntrada = Console.ReadLine();
                Console.WriteLine("Insira valor double: ");
                string valorDoubleEntrada = Console.ReadLine();
                Console.WriteLine("Insira valor decimal: ");
                string valorDecimalEntrada = Console.ReadLine();

                Console.WriteLine("Imprimindo valores informados...");
                
                try
                {
                    valorShort = Convert.ToInt16(valorShortEntrada);
                    Console.WriteLine("Short: " + valorShort);
                }
                catch (Exception)
                {
                    Console.WriteLine("Não foi possível realizar conversão da entrada em Short");
                }

                try
                {
                    valorInt = Convert.ToInt32(valorIntEntrada);
                    Console.WriteLine("Int: " + valorInt);
                }
                catch (Exception)
                {
                    Console.WriteLine("Não foi possível realizar conversão da entrada em Int");
                }

                try
                {
                    valorLong = Convert.ToInt64(valorLongEntrada);
                    Console.WriteLine("Long: " + valorLong);
                }
                catch (Exception)
                {
                    Console.WriteLine("Não foi possível realizar conversão da entrada em Long");
                }

                try
                {
                    valorDouble = Convert.ToDouble(valorDoubleEntrada);
                    Console.WriteLine("Double: " + valorDouble);
                }
                catch (Exception)
                {
                    Console.WriteLine("Não foi possível realizar conversão da entrada em Double");
                }

                try
                {
                    valorFloat = float.Parse(valorFloatEntrada);
                    Console.WriteLine("Float: " + valorFloat);
                }
                catch (Exception)
                {
                    Console.WriteLine("Não foi possível realizar conversão da entrada em Float");
                }

                try
                {
                    valorDecimal = Convert.ToDecimal(valorDecimalEntrada);
                    Console.WriteLine("Decimal: " + valorDecimal);
                }
                catch (Exception)
                {
                    Console.WriteLine("Não foi possível realizar conversão da entrada em Decimal");
                }

                Console.WriteLine("Deseja voltar ao menu? (S/N)");
                var resp = Console.ReadLine();
                if (resp == "S" || resp == "s")
                    MainMenu();
            }
            catch (Exception)
            {
                Console.Clear();
                Console.WriteLine("Não foi possível demonstrar o exercício, volte para o Menu.");
                Console.ReadLine();
                MainMenu();
            }
        }

        /// <summary>
        /// Imprima o valor de uma variavel byte e outra sbyte
        /// 1- Atribuição direta
        /// 2- Atribuição para uma variável int estourada, converter para byte e sbyte
        /// 3- Receber valores do usuario e imprimir
        /// </summary>
        static void Exercicio2()
        {
            try
            {
                Console.Clear();
                Console.WriteLine("Manipulação de variável byte e sbyte");

                try
                {
                    Console.WriteLine("Digite valor a ser convertido para byte: ");
                    string entrada = Console.ReadLine();
                    Console.WriteLine(Convert.ToByte(entrada));
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }

                try
                {
                    Console.WriteLine("Digite valor a ser convertido para sbyte: ");
                    string entrada = Console.ReadLine();
                    Console.WriteLine(Convert.ToSByte(entrada));
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }

                Console.WriteLine("Deseja voltar ao menu? (S/N)");
                var resp = Console.ReadLine();
                if (resp == "S" || resp == "s")
                    MainMenu();
            }
            catch (Exception)
            {
                Console.Clear();
                Console.WriteLine("Não foi possível demonstrar o exercício, volte para o Menu.");
                Console.ReadLine();
                MainMenu();
            }
        }

        /// <summary>
        /// Declarar variáveis tipo ushort, uint e ulong
        /// Atribua valores e depois tente converter uma variável para outra entre si
        /// </summary>
        static void Exercicio3()
        {
            try
            {
                Console.Clear();
                Console.WriteLine("Manipulação de variáveis ushort, uint e ulong");

                ushort variavelUShort = 123;
                uint variavelUInt = 456;
                ulong variavelULong = 789;

                Console.WriteLine("UInt para UShort: " + Convert.ToUInt16(variavelUInt));
                Console.WriteLine("ULong para UShort: " + Convert.ToUInt16(variavelULong));

                Console.WriteLine("UShort para UInt: " + Convert.ToUInt32(variavelUShort));
                Console.WriteLine("ULong para UInt: " + Convert.ToUInt32(variavelULong));

                Console.WriteLine("UShort para ULong: " + Convert.ToUInt64(variavelUInt));
                Console.WriteLine("UInt para ULong: " + Convert.ToUInt32(variavelUInt));

                Console.WriteLine("Deseja voltar ao menu? (S/N)");
                var resp = Console.ReadLine();
                if (resp == "S" || resp == "s")
                    MainMenu();
            }
            catch (Exception)
            {
                Console.Clear();
                Console.WriteLine("Não foi possível demonstrar o exercício, volte para o Menu.");
                Console.ReadLine();
                MainMenu();
            }
        }

        /// <summary>
        /// Receber uma frase do usuário,
        /// Se tiver letra G -> Encontrei a letra G
        /// Se não tiver -> Não encontrei a letra G
        /// </summary>
        static void Exercicio4()
        {
            try
            {
                Console.Clear();
                string frase= "";
                while (string.IsNullOrEmpty(frase))
                {
                    Console.WriteLine("Busca pela letra G na frase. Digite uma frase: ");
                    frase = Console.ReadLine();
                }
                
                if(frase.Contains("G")|| frase.Contains("g"))
                    Console.WriteLine("Encontrei a letra G");
                else
                    Console.WriteLine("Não encontrei a letra G");

                Console.WriteLine("Deseja voltar ao menu? (S/N)");
                var resp = Console.ReadLine();
                if (resp == "S" || resp == "s")
                    MainMenu();
            }
            catch (Exception)
            {
                Console.Clear();
                Console.WriteLine("Não foi possível demonstrar o exercício, volte para o Menu.");
                Console.ReadLine();
                MainMenu();
            }
        }

        /// <summary>
        /// Receber uma lista de dados e imprimir eles depois
        /// Os dados podem ser de tipos diferentes
        /// </summary>
        static void Exercicio5()
        {
            try
            {
                Console.Clear();
                Console.WriteLine("Lista de dados de tipos diferentes");
                List<object> dados = new List<object>();
                string controle = "";

                Console.WriteLine("Digite dados a serem adicionados na lista. Para finalizar adição digite '*': ");
                while (!controle.Equals("*"))
                {
                    controle = Console.ReadLine();
                    if (!controle.Equals("*"))
                        dados.Add(controle);
                }

                Console.WriteLine("Lista de dados inseridos: ");
                foreach (var item in dados)
                {
                    Console.WriteLine(item.ToString());
                }

                Console.WriteLine("Deseja voltar ao menu? (S/N)");
                var resp = Console.ReadLine();
                if (resp == "S" || resp == "s")
                    MainMenu();
            }
            catch (Exception)
            {
                Console.Clear();
                Console.WriteLine("Não foi possível demonstrar o exercício, volte para o Menu.");
                Console.ReadLine();
                MainMenu();
            }
        }

        /// <summary>
        /// Atribuir valores iniciais para a variável float e tente converter de forma explícita, o valor
        /// na variável float para a int, usando os métodos int.Parse ou Convert.ToInt32
        /// Se possível exibir o resultado da conversao
        /// </summary>
        static void Exercicio6()
        {
            try
            {
                Console.Clear();
                Console.WriteLine("Atribuir valor da variávell float para a variável int usando: int.Parse ou Convert.ToInt32");
                int inteiro = 3;
                float valorFloat = 3.0f;

                try
                {
                    Console.WriteLine("Conversão int.Parse: "+ int.Parse(valorFloat.ToString()));
                }
                catch (Exception e)
                {
                    Console.WriteLine("Conversão não realizada: " + e);
                }

                try
                {
                    Console.WriteLine("Conversão Convert.ToInt32: " + Convert.ToInt32(valorFloat));
                }
                catch (Exception e)
                {

                    Console.WriteLine("Conversão não realizada: " + e);
                }

                Console.WriteLine("Deseja voltar ao menu? (S/N)");
                var resp = Console.ReadLine();
                if (resp == "S" || resp == "s")
                    MainMenu();
            }
            catch (Exception)
            {
                Console.Clear();
                Console.WriteLine("Não foi possível demonstrar o exercício, volte para o Menu.");
                Console.ReadLine();
                MainMenu();
            }
        }

        /// <summary>
        /// Aplicativo console que para exibir os 10 primeiros multiplos de 2, usando operadores de atribuição
        /// </summary>
        static void Exercicio7()
        {
            try
            {
                Console.Clear();
                Console.WriteLine("Exibir os 10 primeiros múltiplos de 2");
                int quant = 0;
                int valor = 0;
                while (quant < 10)
                {
                    if (valor % 2 == 0)
                    {
                        Console.WriteLine(valor);
                        quant++;
                    }
                    valor++;
                }
                Console.WriteLine("Deseja voltar ao menu? (S/N)");
                var resp = Console.ReadLine();
                if (resp == "S" || resp == "s")
                    MainMenu();
            }
            catch (Exception)
            {
                Console.Clear();
                Console.WriteLine("Não foi possível demonstrar o exercício, volte para o Menu.");
                Console.ReadLine();
                MainMenu();
            }
        }
    }

    
}
