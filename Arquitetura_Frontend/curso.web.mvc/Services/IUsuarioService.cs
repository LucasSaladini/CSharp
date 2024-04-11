using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using curso.web.mvc.Models.Usuarios;
using Refit;

namespace curso.web.mvc.Services
{
    public interface IUsuarioService
    {
        [Post("/api/v1/usuario/registrar")]
        Task<RegistrarUsuarioViewModelInput> Registrar(RegistrarUsuarioViewModelInput registrarUsuarioViewModelInput);

        [Post("/api/v1/usuario/logar")]
        Task<LoginViewModelOutput> Logar(LoginViewModelInput loginViewModelInput);
    }
}