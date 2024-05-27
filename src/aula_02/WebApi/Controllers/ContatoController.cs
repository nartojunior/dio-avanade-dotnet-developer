using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApi.Context;
using WebApi.Entities;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ContatoController : ControllerBase
    {
        private readonly AgendaContext _context;

        public ContatoController(AgendaContext agendaContext)
        {
            _context = agendaContext;   
        }
        
        [HttpPost]
        public IActionResult Create(Contato contato){
            _context.Add(contato);
            _context.SaveChanges();

            return CreatedAtAction(nameof(GetById), new {id = contato.Id}, contato);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id){
            var contato = _context.Contatos.Find(id);

            if (contato == null)
            {
                return NotFound();
            }

            return Ok(contato);
        }

         [HttpGet("ObterPorNome")]
        public IActionResult GetByNome(string nome){
            var contato = _context.Contatos.Where(x => x.Nome.Contains(nome)).FirstOrDefault<Contato>();

            return Ok(contato);
        }

        [HttpPut("{id:int}")]
        public IActionResult UpdateById(int id, Contato contato){
            var contatoBanco = _context.Contatos.Find(id);

            if (contatoBanco == null){ return NotFound(); }

            contatoBanco.Nome = contato.Nome;
            contatoBanco.Telefone = contato.Telefone;
            contatoBanco.Ativo = contato.Ativo;

            _context.Contatos.Update(contatoBanco);
            _context.SaveChanges();

            return Ok(contatoBanco);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteById(int id){
            var contato = _context.Contatos.Find(id);

            if (contato == null){ return NotFound(); }

            _context.Contatos.Remove(contato);
            _context.SaveChanges();

            return NoContent();
        }
        
    }
}