﻿using System.Collections.Generic;
using System.Web.Http;

namespace WebAPI.Controllers
{
    public class AlunoController : ApiController
    {
        // GET: api/Aluno
        public IEnumerable<string> Get()
        {
            return new string[] { "Rondinele", "Beatriz" };
        }

        // GET: api/Aluno/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Aluno
        public void Post([FromBody]string value)
        {
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
