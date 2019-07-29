using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Web.Hosting;

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
            var caminhoArquivo = HostingEnvironment.MapPath(@"~/Data\Base.json");
            var json = File.ReadAllText(caminhoArquivo);
            var listaAlunos = JsonConvert.DeserializeObject<List<Alunos>>(json);
            return listaAlunos;
        }
    }
}