using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Explorando.Models
{
    public class Curso
    {
        public string Nome { get; set; }
        public List<Pessoa> Alunos { get; set; }

        public void AdicionarAluno(Pessoa aluno)
        {
            Alunos.Add(aluno);
        }

        public int ObterQuantidadeDeAlunosMatriculados()
        {
            int quantidade = Alunos.Count;
            return quantidade;
        }

        public void RemoverAluno(Pessoa aluno)
        {
            Alunos.Remove(aluno);
        }

        public void ListarAlunos()
        {
            Console.WriteLine($"Alunos do curso de {Nome}:");

            for (int contador = 0;  contador < Alunos.Count; contador++)
            {
                //CONCATENAÇÃO:
                //string AlunosComNumero = "Nº " + (contador + 1) + " - " + Alunos[contador].NomeCompleto;

                //INTERPOLAÇÃO
                string AlunosComNumero = $"Nº {contador + 1} - {Alunos[contador].NomeCompleto}";
                Console.WriteLine(AlunosComNumero);
            }
        }
    }

}