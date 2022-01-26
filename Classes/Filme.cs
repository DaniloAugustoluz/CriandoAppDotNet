using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoCRUD.Classes
{
    public class Filme : Entidade
    {
        
        private string Nome { get; set; }
        private string Tempo { get; set; }

        private string Sinopse { get; set; }

        private Genero Genero { get; set; }

        private string Autor { get; set; }

        private int Ano { get; set; }

        private bool itemExcluido { get; set; }

        public Filme(int id, string nome, string tempo, string sinopse, Genero genero, string autor, int ano){
           
            this.Id = id;
            this.Nome = nome;
            this.Tempo = tempo;
            this.Sinopse = sinopse;
            this.Genero = genero;
            this.Autor = autor;
            this.Ano = ano;
            this.itemExcluido = false;

        }

        public override string ToString()
        {
            string _retorno = "";
            _retorno += "Nome do Filme: " + this.Nome + Environment.NewLine;
            _retorno += "Tempo de Filme: " + this.Tempo + Environment.NewLine;
            _retorno += "Sinópse do Filme: " + this.Sinopse + Environment.NewLine;
            _retorno += "Genero: " + this.Genero + Environment.NewLine;
            _retorno += "Autor: " + this.Autor + Environment.NewLine;
            _retorno += "Ano do Filme: " + this.Ano + Environment.NewLine;
            
            return _retorno;
        }
        //Retorna o valor da propiedade ID
        public int retornaId(){
            return this.Id;
        }

        //Retorna o valor da propiedade Nome
        public string retornaNome(){
            return this.Nome;
        }

        //Retorna o valor da propiedade Tempo
        public string retornaTempo(){
            return this.Tempo;
        }

        //Retorna o valor da propiedade Autor
        public string retornaAutor(){
            return this.Autor;
        }

        //Retorna o valor da propiedade Sinopse
        public string retornaSinopse(){
            return this.Sinopse;
        }

        public bool retornaItemExcluido(){
            return this.itemExcluido;
        }
        
        //Retorna o valor da Propiedade Genero
        public Genero retornaGenero(){
            return this.Genero;
        }

        public void Excluir(){
            this.itemExcluido = true;
        }

    }
}