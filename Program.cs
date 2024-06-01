using Explorando.Models;

Pessoa p1 = new Pessoa(nome: "Paulo", sobrenome: "Ricardo");
Pessoa p2 = new Pessoa(nome: "Eduardo", sobrenome: "Fernandes");


Curso cursoDeIngles = new Curso(); 
cursoDeIngles.Nome = "Ingles";
cursoDeIngles.Alunos = new List<Pessoa>();

cursoDeIngles.AdicionarAluno(p1);
cursoDeIngles.AdicionarAluno(p2);   
cursoDeIngles.ListarAlunos();















// p1.Idade = 18;

// p1.Apresentar();