using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadesAula3
{
    struct Estudante
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public decimal Nota { get; set; }
        public Situacao? StatusMateria { get; set; }
        public string StatusMateriaDescription
        {
            get
            {
                switch (StatusMateria)
                {
                    case Situacao.Aprovado:
                        return "Aprovado";
                    case Situacao.Reprovado:
                        return "Reprovado";
                    case Situacao.Recuperacao:
                        return "Recuperação";
                    default:
                        return "Não informado";
                }
            }
        }
        public DateTime Insercao;

        public Estudante(string nome, int idade, decimal nota, Situacao? situacao, DateTime insercao)
        {
            this.Nome = nome;
            this.Idade = idade;
            this.Nota = nota;
            this.StatusMateria = situacao;
            this.Insercao = insercao;
        }
    }
    enum Situacao
    {
        Aprovado,
        Reprovado,
        Recuperacao
    }

    
    public class ManipulacaoEstudante
    {
        List<Estudante> TodosEstudantes;
        public ManipulacaoEstudante()
        {
            TodosEstudantes = new List<Estudante>();
            MenuEstudante();
        }

        private void MenuEstudante()
        {
            Console.Clear();
            Console.WriteLine("Menu de Estudantes \nDigite operação desejada: ");
            Console.WriteLine("1- Cadastrar alunos");
            Console.WriteLine("2- Listar alunos");
            Console.WriteLine("3- Calcular média e listar alunos e status");
            Console.WriteLine("4- Pesquisar alunos pelo nome");
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
                        CadastraAluno();
                        break;
                    //Subtracao
                    case 2:
                        ListarAluno();
                        break;
                    //Multiplicacao
                    case 3:
                        CalculaMedia();
                        break;
                    //Divisao
                    case 4:
                        PesquisaAlunoNome();
                        break;
                    //Volta principal
                    case 5:
                        ValidaRetorno();
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Não foi possível executar operação. Insira um comando válido ");
                        Console.ReadLine();
                        MenuEstudante();
                        break;
                }
            }
            catch (Exception)
            {
                Console.Clear();
                Console.WriteLine("Não foi possível executar operação. Insira um comando válido ");
                Console.ReadLine();
                MenuEstudante();
            }
        }

        private void CadastraAluno()
        {
            try
            {
                if(TodosEstudantes.Count >= 10)
                {
                    Console.WriteLine("Quantidade limite de estudantes atingida. Volte para o Menu Estudante");
                    Console.ReadLine();
                    MenuEstudante();
                }
                else
                {
                    var novoEstudante = new Estudante();
                    Console.WriteLine("Insira o nome do estudante: ");
                    novoEstudante.Nome = Console.ReadLine();
                    Console.WriteLine("Insira a idade do estudante: ");
                    novoEstudante.Idade = Convert.ToInt16(Console.ReadLine());
                    Console.WriteLine("Insira a nota do estudante: ");
                    novoEstudante.Nota = Convert.ToDecimal(Console.ReadLine());
                    novoEstudante.Insercao = DateTime.Now;
                    TodosEstudantes.Add(novoEstudante);
                    Console.WriteLine("Estudante adicionado com sucesso! ");
                    ValidaRetorno();
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Não foi possível adicionar novo estudante.");
                Console.ReadLine();
                MenuEstudante();
            }
        }

        private void ListarAluno()
        {
            foreach (var estudantes in TodosEstudantes)
            {
                Console.WriteLine($"Nome: {estudantes.Nome}");
                Console.WriteLine($"Idade: {estudantes.Idade}");
                Console.WriteLine($"Nota: {estudantes.Nota}");
                Console.WriteLine($"Status: {estudantes.StatusMateriaDescription}");
                Console.WriteLine($"Data Inserção: {(estudantes.Insercao).ToString("dd/MM/yyyy")}");
            }
            ValidaRetorno();
        }

        private void CalculaMedia()
        {
            var media = TodosEstudantes.Sum(s => s.Nota) / TodosEstudantes.Count();
            Console.WriteLine($"Média da turma: {media}");

            for (int i = 0; i <= TodosEstudantes.Count -1; i++)
            {
                if (TodosEstudantes[i].Nota > media + 3)
                {
                    //É necessário fazer a atribuição desta forma visto que 
                    //Estudante é uma struct, com variáveis do tipo valor, sendo somente de leitura
                    //(divide mesma memória)
                    var estudante = TodosEstudantes[i];
                    estudante.StatusMateria = Situacao.Aprovado;
                    TodosEstudantes[i] = estudante;
                }
                else if(TodosEstudantes[i].Nota < media - 3)
                {
                    var estudante = TodosEstudantes[i];
                    estudante.StatusMateria = Situacao.Reprovado;
                    TodosEstudantes[i] = estudante;
                }
                else
                {
                    var estudante = TodosEstudantes[i];
                    estudante.StatusMateria = Situacao.Recuperacao;
                    TodosEstudantes[i] = estudante;
                } 
            }
            ListarAluno();
            ValidaRetorno();
        }

        private void PesquisaAlunoNome()
        {
            Console.Clear();
            Console.Write("Digite o nome do aluno: ");
            var nome = Console.ReadLine();
            var estudante = TodosEstudantes.Where(w=>w.Nome == nome);
            if(estudante.Any())
            {
                foreach (var estudantes in estudante)
                {
                    Console.WriteLine($"Nome: {estudantes.Nome}");
                    Console.WriteLine($"Idade: {estudantes.Idade}");
                    Console.WriteLine($"Nota: {estudantes.Nota}");
                    Console.WriteLine($"Status: {estudantes.StatusMateriaDescription}");
                    Console.WriteLine($"Data Inserção: {(estudantes.Insercao).ToString("dd/MM/yyyy")}");
                }
            }
            else
                Console.WriteLine($"Não foi encontrado nenhum estudante com o nome: {nome}");
            ValidaRetorno();
        }

        private void ValidaRetorno()
        {
            Console.WriteLine("Deseja sair do Menu de Estudante? (S/N) ");
            var resp = Console.ReadLine();
            if (!string.IsNullOrEmpty(resp) && resp.Contains("s", StringComparison.CurrentCultureIgnoreCase))
                new MenuPrincipal();
            else
                MenuEstudante();
        }
    }
}
