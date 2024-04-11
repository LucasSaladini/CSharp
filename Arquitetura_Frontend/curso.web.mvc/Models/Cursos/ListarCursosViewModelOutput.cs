using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace curso.web.mvc.Models.Cursos
{
    public class ListarCursosViewModelOutput
    {
        [Required(ErrorMessage = "O nome é obrigatório")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "A descrição é obrigatória")]
        public string Descricao { get; set; }
        [Required(ErrorMessage = "O login é obrigatório")]
        public string Login { get; set; }
    }
}