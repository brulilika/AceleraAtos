using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeAula8
{
    public class Exercicio1
    {
        class Pessoa : IDisposable
        {
            private string _nome;
            public string Nome { get => _nome; set => _nome = value; }
            public Pessoa(string nome)
            {
                Console.WriteLine("Construtor PAI com parametros " + nome);

            }
            public virtual void Exibir() //Este é o metodo genérico
            {
                Console.WriteLine($"O Nome é: {Nome} ");
            }

            public void Dispose()
            {
                throw new NotImplementedException();
            }
        }

        public Exercicio1()
        {
            ExecutaResolucao();
        }

        private void ExecutaResolucao()
        {
            //using (Pessoa pessoa = new Pessoa("Roberto"))
            //{
            //    Console.WriteLine("Executando enquanto o objeto existe");
            //}

            /*Para que seja possível a utilização do using, o método dentro deve ser
             * do tipo IDisposable
             */

            using (Pessoa pessoa = new Pessoa("Roberto"))
            {
                Console.WriteLine("Executando enquanto o objeto existe");
            }
            /*Problema resolvido atribuindo herança da interface IDisposable 
             * na classe Pessoa, com o método de Dispose sem implementação
             */
            Console.WriteLine("Para ser possível a utilização de using, é necessário que o conteúdo seja do tipo Disposable. " +
                              "Para solucionar tal problema, é adicionada a herança da interface IDisposable na classe pessoa, " +
                              "com o método Dispose sem implementação");

            Console.WriteLine("Deseja sair do Exercicio 1? (S/N) ");
            var resp = Console.ReadLine();
            if (!string.IsNullOrEmpty(resp) && resp.Contains("s", StringComparison.CurrentCultureIgnoreCase))
                new MenuPrincipal();
            else
                new Exercicio1();
        }
    }
}
