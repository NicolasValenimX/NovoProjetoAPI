using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NovoProjetoAPI.Data;
using NovoProjetoAPI.Models;

namespace NovoProjetoAPI.Services.Autor
{
    public class AutorServices : AutorInterface
    {
        private readonly AppDbContext _context;
        public AutorServices(AppDbContext context)
        {
            _context = context;
        }
        public Task<ReponseModel<AutorModel>> BuscarAutorPorID(int idAutor)
        {
            throw new NotImplementedException();
        }

        public Task<ReponseModel<AutorModel>> BuscarAutorzPorIdLivro(int idLivro)
        {
            throw new NotImplementedException();
        }

        public Task<ReponseModel<List<AutorModel>>> ListarAutores()
        {
            throw new NotImplementedException();
        }
    }
}