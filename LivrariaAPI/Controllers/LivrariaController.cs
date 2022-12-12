using LivrariaAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Livraria.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LivrariaController : ControllerBase
    {
        private readonly ToDoContext _context;




        public LivrariaController(ToDoContext context)
        {
            _context = context;

            _context.TodoProducts.Add(new Produto { Id = 1, Nome = "Livro1", Preco = 24.0, Quantidade = 1, Categoria = "Ação", Img = "img1" });
            _context.TodoProducts.Add(new Produto { Id = 2, Nome = "Livro2", Preco = 124.0, Quantidade = 1, Categoria = "Aventura", Img = "img2" });
            _context.TodoProducts.Add(new Produto { Id = 3, Nome = "Livro3", Preco = 234.0, Quantidade = 1, Categoria = "Ação", Img = "img3" });
            _context.TodoProducts.Add(new Produto { Id = 4, Nome = "Livro4", Preco = 34.0, Quantidade = 1, Categoria = "Infantil", Img = "img4" });
            _context.TodoProducts.Add(new Produto { Id = 5, Nome = "Livro5", Preco = 244.0, Quantidade = 1, Categoria = "Ação", Img = "img5" });

            _context.SaveChanges();
        }


        [HttpGet]
        public async Task<ActionResult<IEnumerable<Produto>>> GetProdutos()
        {
            return await _context.TodoProducts.ToListAsync();
        }



    }
}
