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
        public Projeto BuscaPorId(int id){
            return _context.Projetos.Find(id);
        }
        public void Cadastrar(Projeto projeto){
            _context.Projetos.Add(projeto);
            _context.SaveChanges();
        }
        public void Atualizar(int id, Projeto projeto){
            Projeto projetoBuscado = _context.Projetos.Find(id);
            if(projetoBuscado != null){
                projetoBuscado.NomeDoProjeto = projeto.NomeDoProjeto;
                projetoBuscado.Area = projeto.Area;
                projetoBuscado.Status = projeto.Status;
            }
            _context.Projetos.Update(projetoBuscado);
            _context.SaveChanges();
        }
        public void Deletar(int id){
            Projeto projetoBuscado = _context.Projetos.Find(id);
            _context.Projetos.Remove(projetoBuscado);
            _context.SaveChanges();

        }
    }
}