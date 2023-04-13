using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExoApi.Models;

namespace ExoApi
{
    public class ProjetoRepository
    {
        private readonly ExoContext _context;

        public ProjetoRepository(ExoContext context){
            _context = context;
        }

        public List<Projeto> Listar(){
            return _context.Projetos.ToList();
        }
    }
}