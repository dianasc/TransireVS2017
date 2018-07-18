using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Service.Models;
using Newtonsoft.Json;


namespace Service.Controllers
{
    [Route("api/categoria")]
    [ApiController]
    public class CategoriaController : ControllerBase
    {

        private readonly Contexto _context;


        public CategoriaController(Contexto context)
        {
            _context = context;
        }

        // GET api/values
        [HttpGet]
        [ValidateAntiForgeryToken]
        [Route("api/categoria/get")]
        public string Get()
        {
            Return retorno = new Return() { Sucesso = false, DadosRetorno = null, Mensagem = null };
            try
            {
                var result =  _context.Categorias.Where(c => c.Ativo == true).ToList();
                retorno.Mensagem = "Sucesso";
                retorno.DadosRetorno = JsonConvert.SerializeObject(result);
            }
            catch (Exception ex)
            {
                retorno.Mensagem = ex.Message;
                retorno.DadosRetorno = JsonConvert.SerializeObject(ex);
            }
            
            return JsonConvert.SerializeObject(retorno);
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public string Post([FromBody] string value)
        {
            try
            {
                Categoria novaCategoria = JsonConvert.DeserializeObject<Categoria>(value);

                _context.Categorias.Add(novaCategoria);
                _context.SaveChanges();
                int id = novaCategoria.ID;
                return JsonConvert.SerializeObject(
                    new Return()
                    {
                        Sucesso = true,
                        Mensagem = "Categoria Cadastrada com sucesso",
                        DadosRetorno = JsonConvert.SerializeObject(novaCategoria)
                    });


            }
            catch (Exception ex)
            {
                return JsonConvert.SerializeObject(
                       new Return()
                       {
                           Sucesso = true,
                           Mensagem = ex.Message,
                           DadosRetorno = JsonConvert.SerializeObject(ex)
                       });
            }
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
