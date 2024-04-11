using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace curso.web.mvc.Models.Cursos
{
    public class CadastrarCursoViewModelOutput
    {
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public string Login { get; set; }
    }
}