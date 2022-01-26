using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoCRUD.Classes
{
    public class Serie: Entidade
    {
        private Genero Genero { get; set; }

        private string Titulo { get; set; }

        private string Descricao { get; set; }

        private int Ano { get; set; }

        private bool itemExcluido { get; set; }

        public Serie(int id, Genero genero, string titulo, string descricao, int ano){

                this.Id = id;
                this.Genero = genero;
                this.Titulo = titulo;
                this.Descricao = descricao;
                this.Ano = ano;
                this.itemExcluido = false;

        }

        public override string ToString()
        {
            string Retorno = "";
            Retorno += "Gênero: " + this.Genero + Environment.NewLine;
            Retorno += "Título: " + this.Titulo + Environment.NewLine;
            Retorno += "Descrição: " + this.Descricao + Environment.NewLine;
            Retorno += "Ano de Inicio: " + this.Ano + Environment.NewLine;
            Retorno += "Excluido: " + this.itemExcluido;
            return Retorno;
        }

        //Método para retornar ID (Encapsulamento)
        public int retornaId(){
            return this.Id;
        }

        //Método para Retornar Série Excluida(Encapsulamento)
        public bool retornaExcluido(){
            return this.itemExcluido;
        }


        //Método para retornar Titulo (Encapsulamento)
        public string retornoTitulo(){
            return this.Titulo;
        }

        public void Excluir(){
            this.itemExcluido = true;
        }

    }
}