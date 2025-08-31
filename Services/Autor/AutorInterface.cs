using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NovoProjetoAPI.Models;

namespace NovoProjetoAPI.Services.Autor
{
    public interface AutorInterface
    {
        Task<ReponseModel<List<AutorModel>>> ListarAutores();
        Task<ReponseModel<AutorModel>> BuscarAutorPorID(int idAutor);
        Task<ReponseModel<AutorModel>> BuscarAutorzPorIdLivro(int idLivro);
    }


}