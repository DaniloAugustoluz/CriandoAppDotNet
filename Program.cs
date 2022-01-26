using System;
using ProjetoCRUD.Classes;

namespace ProjetoCRUD {
    public class Program
    {
       static SerieRepositorio repositorio = new SerieRepositorio();
       static FilmeRepositorio repositorioFilme = new FilmeRepositorio();
        public static void Main(string[] args){
            
            string opcaoUsuario = obterOpcaoUsuario();
            while(opcaoUsuario.ToUpper() != "X"){
                switch(opcaoUsuario){                    
                    //Escolhas dos Métodos do Filme//
                    //------------------------------//
                    case "1": 
                        ListarFilmes(); 
                        
                        break;

                    case "2":
                        InserirFilme();                         
                        break;
                
                    case "3":
                        AtualizarFilme();                    
                        break;

                    case "4": 
                        ExcluirFilme();                  
                        break;

                    case "5":
                        VizualizarFilme();                        
                        break;
                    
                    //Escolhas dos métodos da Série//
                    //------------------------------//
                    case "6":
                        ListarSeries(); 
                        break;

                    case "7":
                        InserirSerie();
                        break;
                   
                    case "8":
                        AtualizarSerie();
                        break;

                    case "9":
                        ExcluirSerie();
                        break;

                    case "10":
                        VisualizarSerie();
                        break;

                    //Escolha para Limpar o Console//
                    //------------------------------//
                    case "C": 
                        Console.Clear();
                            break;

                    default: 
                        throw new ArgumentOutOfRangeException();
                }
                
                opcaoUsuario = obterOpcaoUsuario();               
            }

                System.Console.WriteLine("Obrigado pela preferência!");
                Console.ReadLine();            
        }

        private static string obterOpcaoUsuario(){
           
            System.Console.WriteLine("");
            System.Console.WriteLine(" SEJA BEM VINDO A TOTAL MOVIES ");
            System.Console.WriteLine(" INFORME A OPÇÃO DE MENU DESEJADA: ");
            System.Console.WriteLine("");
            System.Console.WriteLine("    INFORME 1 PARA O MENU DE FILMES  ");
            System.Console.WriteLine("    INFORME 2 PARA O MENU DE SÉRIES  ");
            System.Console.WriteLine("    INFORME X PARA SAIR, OU C PARA LIMPAR O CONSOLE  ");
            System.Console.WriteLine("");
            string menudeEntrada = Console.ReadLine();

            if(menudeEntrada == "1"){
                System.Console.WriteLine("");
                System.Console.WriteLine(" ---------- MENU DE FILMES ----------");
                System.Console.WriteLine("1- Listar todos os Filmes");
                System.Console.WriteLine("2- Inserir novo Filme");
                System.Console.WriteLine("3- Atualizar Filme");
                System.Console.WriteLine("4- Excluir Filme");
                System.Console.WriteLine("5- Vizualizar Filme");
                System.Console.WriteLine("");
               
                string opcaoUsuario = Console.ReadLine().ToUpper();
                System.Console.WriteLine("");
                return opcaoUsuario;
            }
            else if(menudeEntrada == "2"){
                System.Console.WriteLine("");
                System.Console.WriteLine(" ---------- MENU DE SÉRIES ----------");
                System.Console.WriteLine("6- Listar todas as séries");
                System.Console.WriteLine("7- Inserir nova Série");
                System.Console.WriteLine("8- Atualizar Série");
                System.Console.WriteLine("9- Excluir Série");
                System.Console.WriteLine("10- Visualizar Série");
                

                System.Console.WriteLine("");
                System.Console.WriteLine("C- Limpar tela");
                System.Console.WriteLine("X- Sair");
                System.Console.WriteLine("");
                
                string opcaoUsuario = Console.ReadLine().ToUpper();
                System.Console.WriteLine("");
                return opcaoUsuario;
            }
            else{
                return "X";
            } 
        }
        private static void VizualizarFilme()
        {
            System.Console.WriteLine("Informe o ID do Filme: ");
            int idFilme = Convert.ToInt32(Console.ReadLine());

            Filme vizualizarFilme = repositorioFilme.RetornaPorId(idFilme);
            System.Console.WriteLine(vizualizarFilme);
        }

        private static void ExcluirFilme()
        {
            System.Console.WriteLine("Informe o ID do Filme para excluir: ");
            int idFilme = Convert.ToInt32(Console.ReadLine());

            repositorioFilme.Exclui(idFilme);

        }

        private static void AtualizarFilme()
        {
            System.Console.WriteLine("");
            System.Console.WriteLine("Digite o ID do Filme: ");
            int idFilme = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("");

            foreach (int Genero in Enum.GetValues(typeof(Genero)))
            {
                System.Console.WriteLine("{0}- {1}", Genero, Enum.GetName(typeof(Genero), Genero));
            }

            System.Console.WriteLine("");
            System.Console.WriteLine("Escolha um Genero de Filme por favor: ");
            int entradaGenero = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("");

            System.Console.WriteLine("");
            System.Console.WriteLine("Informe o nome do Filme: ");
            string nomeFilme = Console.ReadLine();
            System.Console.WriteLine("");

            System.Console.WriteLine("");
            System.Console.WriteLine("Informe o tempo de duração do filme: ");
            string tempoFilme = Console.ReadLine();

            System.Console.WriteLine("");
            System.Console.WriteLine("Escreva a Sinópse do Filme: ");
            string sinopseFilme = Console.ReadLine();
            System.Console.WriteLine("");

            System.Console.WriteLine("");
            System.Console.WriteLine("Informe o nome do Autor do Filme: ");
            string nomeAutor = Console.ReadLine();
            System.Console.WriteLine("");

            System.Console.WriteLine("");
            System.Console.WriteLine("Informe o ano do Filme: ");
            int anoFilme = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("");

            Filme atualizarFilme = new Filme(id: repositorioFilme.proximoId(),
                                            nome: nomeFilme,
                                            tempo: tempoFilme,
                                            sinopse: sinopseFilme,
                                            genero: (Genero)entradaGenero,
                                            autor: nomeAutor,
                                            ano: anoFilme);
            repositorioFilme.Atualizar(idFilme,atualizarFilme);
        }

        private static void InserirFilme()
        {
            System.Console.WriteLine("Inserir Filmes: ");
            foreach (int Genero in Enum.GetValues(typeof(Genero)))
            {
                System.Console.WriteLine("{0}-{1}", Genero, Enum.GetName(typeof(Genero), Genero));   
            }
            System.Console.WriteLine("");
            System.Console.WriteLine("Escolha um Genero de Filme por favor: ");
            int entradaGenero = Convert.ToInt32(Console.ReadLine());
            
            System.Console.WriteLine("");
            System.Console.WriteLine("Informe o nome do Filme: ");
            string nomeFilme = Console.ReadLine();

            System.Console.WriteLine("");
            System.Console.WriteLine("Informe o tempo de duração do filme: ");
            string tempoFilme = Console.ReadLine();

            System.Console.WriteLine("");
            System.Console.WriteLine("Escreva a Sinópse do Filme: ");
            string sinopseFilme = Console.ReadLine();

            System.Console.WriteLine("");
            System.Console.WriteLine("Informe o nome do Autor do Filme: ");
            string nomeAutor = Console.ReadLine();

            System.Console.WriteLine("");
            System.Console.WriteLine("Informe o ano de lançamento do Filme: ");
            int anoFilme = Convert.ToInt32(Console.ReadLine());

            Filme novoFilme = new Filme(id: repositorioFilme.proximoId(),
                                        nome: nomeFilme,
                                        tempo: tempoFilme,
                                        sinopse: sinopseFilme,
                                        genero: (Genero)entradaGenero,
                                        autor: nomeAutor,
                                        ano: anoFilme);

            repositorioFilme.Insere(novoFilme);

        }

        private static void ListarFilmes()
        {
            System.Console.WriteLine("Lista de Filmes: ");
            var lista = repositorioFilme.Lista();
            if(lista.Count == 0){
                System.Console.WriteLine("Nenhum filme foi encontrado, cadastre um filme por favor.");
            }
            foreach (var filme in lista)
            {
                var excluido = filme.retornaItemExcluido();
                System.Console.WriteLine("#ID: {0} Nome do Filme: {1} Tempo do Filme: {2} Sinópse do Filme: {3} Excluido: {4}", filme.retornaId(), filme.retornaNome() + Environment.NewLine, filme.retornaTempo() + Environment.NewLine, filme.retornaSinopse() + Environment.NewLine, excluido ? "Excluido" : "" + Environment.NewLine);
            }
            
        }

        private static void VisualizarSerie()
        {
            System.Console.WriteLine("Digite o ID da Série: ");
            int idVisualizar = Convert.ToInt32(Console.ReadLine());

            Serie serie = repositorio.RetornaPorId(idVisualizar);
            System.Console.WriteLine(serie);

        }

        private static void ExcluirSerie()
        {
            System.Console.WriteLine("Informe o ID da Série: ");
            int idExcluir = Convert.ToInt32(Console.ReadLine());

            repositorio.Exclui(idExcluir);

        }

        private static void AtualizarSerie()
        {   
            System.Console.WriteLine("");
            System.Console.WriteLine("Digite o ID da Série: ");
            int indiceSerie = Convert.ToInt32(Console.ReadLine());

            foreach(int i in Enum.GetValues(typeof(Genero))){
                System.Console.WriteLine("{0}-{1}", i ,Enum.GetName(typeof(Genero), i));
            }
                System.Console.WriteLine("");
                System.Console.WriteLine("Digite o gênero entre as opções acima: ");
                int entradaGenero = int.Parse(Console.ReadLine());

                System.Console.WriteLine("");
                System.Console.WriteLine("Digite o Título da Série: ");
                string entradaTitulo = Console.ReadLine();

                System.Console.WriteLine("");
                System.Console.WriteLine("Digite a Descrição da Série: ");
                string entradaDescricao = Console.ReadLine();

                System.Console.WriteLine("");
                System.Console.WriteLine("Digite o ano de inicio da Série: ");
                int entradaAno = int.Parse(Console.ReadLine());

                 Serie atualizarSerie = new Serie(id: repositorio.proximoId(), 
                                        genero: (Genero)entradaGenero,
                                        titulo: entradaTitulo, 
                                        descricao: entradaDescricao, 
                                        ano: entradaAno);

            repositorio.Atualizar(indiceSerie,atualizarSerie);

            
        }

        private static void ListarSeries(){
            
            System.Console.WriteLine("Lista de Séries: ");
            var lista = repositorio.Lista();             
                    if(lista.Count == 0){
                        System.Console.WriteLine("Não há nenhuma série cadastrada.");
                        return;               
                    }                     
                    foreach (var serie in lista)
                    {
                        var excluido = serie.retornaExcluido();  
                        System.Console.WriteLine("#ID: {0}: - {1} - {2} :", serie.retornaId(), serie.retornoTitulo(), excluido ? "Excluido" : "");
                    }                          
        }

        private static void InserirSerie(){
            
                System.Console.WriteLine("Inserir nova Série!");

                foreach (int i in Enum.GetValues(typeof(Genero)))
                {
                    System.Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Genero), i));
                }
                System.Console.WriteLine("");
                System.Console.WriteLine("Digite o gênero entre as opções acima: ");
                int entradaGenero = int.Parse(Console.ReadLine());

                System.Console.WriteLine("");
                System.Console.WriteLine("Digite o Título da Série: ");
                string entradaTitulo = Console.ReadLine();

                System.Console.WriteLine("");
                System.Console.WriteLine("Digite a Descrição da Série: ");
                string entradaDescricao = Console.ReadLine();

                System.Console.WriteLine("");
                System.Console.WriteLine("Digite o ano de inicio da Série: ");
                int entradaAno = int.Parse(Console.ReadLine());

                 Serie novaSerie = new Serie(id: repositorio.proximoId(), 
                                        genero: (Genero)entradaGenero,
                                        titulo: entradaTitulo, 
                                        descricao: entradaDescricao, 
                                        ano: entradaAno);

            repositorio.Insere(novaSerie);
        }
                              
    }
}