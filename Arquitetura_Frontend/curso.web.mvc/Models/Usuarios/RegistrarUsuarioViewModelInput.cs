using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace curso.web.mvc.Models.Usuarios
{
    public class RegistrarUsuarioViewModelInput
    {
        internal object Usuario;

        [Required(ErrorMessage = "O login é obrigatório")]
        public string Login { get; set; }
        [Required(ErrorMessage = "O e-mail é obrigatório")]
        [EmailAddress(ErrorMessage = "O e-mail é inválido")]
        public string Email { get; set; }
        [Required(ErrorMessage = "A senha é obrigatória")]
        public string Senha { get; set; }
    }
}