using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProjetoCRUD.Interfaces;

namespace ProjetoCRUD.Classes
{
    public class FilmeRepositorio : IRepositorio<Filme>
    {
        private List<Filme> listaFilmes = new List<Filme>();
        public void Atualizar(int id, Filme entidade)
        {
            listaFilmes[id] = entidade;
        }

        public void Exclui(int id)
        {
            listaFilmes[id].Excluir();
        }

        public void Insere(Filme entidade)
        {
            listaFilmes.Add(entidade);
        }

        public List<Filme> Lista()
        {
            return listaFilmes;
        }

        public int proximoId()
        {
            return listaFilmes.Count;
        }

        public Filme RetornaPorId(int id)
        {
            return listaFilmes[id];
        }
    }
}