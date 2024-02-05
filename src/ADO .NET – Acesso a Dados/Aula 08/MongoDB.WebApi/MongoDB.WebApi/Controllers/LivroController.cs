using Microsoft.AspNetCore.Mvc;
using MongoDB.WebApi.Models;
using MongoDB.WebApi.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MongoDB.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LivroController : ControllerBase
    {
        private readonly LivroService _livroService;

        public LivroController(LivroService livroService)
        {
            _livroService = livroService;
        }


        // GET: api/<LivroController>
        [HttpGet]
        public IEnumerable<Livro> Get() => _livroService.Livros;


        // GET api/<LivroController>/5
        [HttpGet("{id}")]
        public Livro Get(string id) => _livroService.Obter(id);

        // POST api/<LivroController>
        [HttpPost]
        public void Post(Livro livro) => _livroService.CriarLivro(livro);


        // PUT api/<LivroController>/5
        [HttpPut("{id}")]
        public void Put(string id, Livro novosDados) => _livroService.AtualizarLivro(id, novosDados);


        // DELETE api/<LivroController>/5
        [HttpDelete("{id}")]
        public void Delete(string id) => _livroService.ApagarLivro(id);
    }
}
