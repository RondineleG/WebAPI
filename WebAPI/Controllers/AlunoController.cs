using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    public class AlunoController : ApiController
    {
        // GET: api/Aluno
        public IEnumerable<Alunos> Get()
        {
            var aluno = new Alunos();
            return aluno.ListaAlunos();
        }

        // GET: api/Aluno/5
        public Alunos Get(int id)
        {
            var aluno = new Alunos();
            return aluno.ListaAlunos().Where(x => x.Id == id).FirstOrDefault();
        }

        // POST: api/Aluno
        public List<Alunos> Post(Alunos aluno)
        {
            var alunos = new List<Alunos>
            {
                aluno
            };
            return alunos;
        }

        // PUT: api/Aluno/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Aluno/5
        public void Delete(int id)
        {
        }
    }
}
