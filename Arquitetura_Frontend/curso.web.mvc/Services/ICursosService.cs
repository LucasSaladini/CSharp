using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using curso.web.mvc.Models.Cursos;
using Refit;

namespace curso.web.mvc.Services
{
    public interface ICursosService
    {
        [Post("/api/v1/cursos")]
        [Headers("Authorization: Bearer")]
        Task<CadastrarCursoViewModelInput> Registrar(CadastrarCursoViewModelInput cadastrarCursoViewModelInput);
        [Get("/api/v1/cursos")]
        [Headers("Authorization: Bearer")]
        Task<IList<ListarCursosViewModelOutput>> Obter();
    }
}