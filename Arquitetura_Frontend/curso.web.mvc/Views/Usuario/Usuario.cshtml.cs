using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace curso.web.mvc.Views.Usuario
{
    public class Usuario : PageModel
    {
        private readonly ILogger<Usuario> _logger;

        public Usuario(ILogger<Usuario> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}