using System.Collections.Generic;

namespace WebAPI.Models
{
    public class Alunos
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public string SobreNome { get; set; }

        public string Telefone { get; set; }

        public string Ra { get; set; }


        public List<Alunos> ListaAlunos()
        {
            Alunos aluno = new Alunos();
            aluno.Id = 1;
            aluno.Nome = "Rondinele";
            aluno.SobreNome = "Guimarães";
            aluno.Telefone = "1221211";
            aluno.Ra = "13145445";

            Alunos aluno1 = new Alunos();
            aluno1.Id = 2;
            aluno1.Nome = "Beatriz";
            aluno1.SobreNome = "Guimarães";
            aluno1.Telefone = "45454545";
            aluno1.Ra = "15544666";

            var listaAlunos = new List<Alunos>();
            listaAlunos.Add(aluno);
            listaAlunos.Add(aluno1);
            return listaAlunos;
        }
    }
}