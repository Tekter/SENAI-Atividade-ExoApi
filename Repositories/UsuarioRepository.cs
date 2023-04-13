using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExoApi.Models;

namespace ExoApi
{
    public class UsuarioRepository
    {
        private readonly ExoContext _context;

        UsuarioRepository(ExoContext context){
            _context = context;
        }

        public List<Usuario> Listar(){
            return _context.Usuarios.ToList();
        }
    }
}