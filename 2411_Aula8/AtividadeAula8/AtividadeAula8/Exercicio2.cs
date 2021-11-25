using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeAula8
{
    public class Exercicio2
    {
        /// <summary>
        /// Construa um programa com Interfaces
        /// Classes abstratas
        /// Métodos publicos, abstratos, virtuais, protegidos e privados
        /// </summary>
        /// 
        public interface IAlteracoes
        {
            void AlteraNome(string troca);
        }

        public abstract class Endereco
        {
            public string localizacao(string rua, string bairro, string cidade)
            {
                return $"Rua {rua} - {bairro}, {cidade}";
            }
        }

        public class Pessoa : Endereco, IAlteracoes
        {
            public string Nome { get; set; }
            public int Idade { get; set; }

            public void AlteraNome(string novoNome)
            {
                this.Nome = novoNome;
            }

            public virtual string Imprime()
            {
                return this.Nome;
            }
        }

        public Exercicio2()
        {
            ExecutaExercicio2();
        }

        public void ExecutaExercicio2() 
        {
            var novaPessoa = new Pessoa()
            {
                Nome = "Bruna",
                Idade = 22,
            };
            var minhaLocalizacao = novaPessoa.localizacao("uma rua por ai", "um bairro legal", "em uma cidade legal");
            novaPessoa.AlteraNome("Tamake");
            
        }

        public class SobreEscrita: Pessoa
        {
            public override string Imprime()
            {
                var mensagem = base.Imprime();
                return $"Nome: {mensagem}. Idade: {this.Idade}";
            }
        }
    }
}
