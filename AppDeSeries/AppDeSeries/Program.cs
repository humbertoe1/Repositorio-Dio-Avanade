using System;


namespace AppDeSeries
{
    internal class Program
    {
        static SerieRepositorio repositorio = new SerieRepositorio();
        static void Main(string[] args)
        {
            string opcao = ObterOpcaoUsuario();
            while(opcao.ToUpper() != "X")
            {
                switch (opcao)
                {
                    case "1":
                        ListarSeries();
                        break;
                    case "2":
                        InserirSerie();
                        break;
                    case "3":
                        AtualizarSerie();
                        break;
                    case "4":
                        ExcluirSerie();
                        break;
                    case "5":
                        VisualizarSerie();
                        break;
                    case "C":
                        Console.Clear();
                        break;

                    default:
                        throw new ArgumentOutOfRangeException();
                }
                opcao = ObterOpcaoUsuario();
            }
            
        }

      

       

      

      

        private static void ListarSeries()
        {
            Console.WriteLine("Listar séries: ");
            var lista = repositorio.Lista();

            if (lista.Count == 0)
            {
                Console.WriteLine("Nenhuma série Cadastrada");
                return;
            }

            foreach (var serie in lista)
            {
                var excluido = serie.retornaExcluido();
                string excluidoOuNao = excluido ? "Excluido" : "";
                Console.WriteLine($"#ID [{serie.retornaId()}] - {serie.retornaTitulo()} {excluidoOuNao}");
            }
        }
        private static void InserirSerie()
        {
            Console.WriteLine("Inserir uma nova série: ");
            foreach(int i in Enum.GetValues(typeof(Genero)))
            {
                Console.WriteLine($"{i}-{Enum.GetName(typeof(Genero), i)}");
            }
            Console.WriteLine("Digite o Gênero entre as opções acima: ");
            int entradaGenero = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o Titulo da Série: ");
            string entradaTitulo = Console.ReadLine();

            Console.WriteLine("Digite o Ano de inicio da serie: ");
            int entradaAno = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a Descrição da Serie: ");
            string entradaDescricao = Console.ReadLine();

            Series novaSerie = new Series(Id: repositorio.ProximoId(),
                                          genero: (Genero)entradaGenero,
                                          titulo: entradaTitulo,
                                          descricao: entradaDescricao,
                                          ano: entradaAno);
            repositorio.Insere(novaSerie);
                
        }
        private static void AtualizarSerie()
        {

            Console.WriteLine("Digite o ID da série: ");
            int idDaSerie = int.Parse(Console.ReadLine());

            foreach (int i in Enum.GetValues(typeof(Genero)))
            {
                Console.WriteLine($"{i}-{Enum.GetName(typeof(Genero), i)}");
            }
            Console.WriteLine("Digite o Gênero entre as opções acima: ");
            int entradaGenero = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o Titulo da Série: ");
            string entradaTitulo = Console.ReadLine();

            Console.WriteLine("Digite o Ano de inicio da serie: ");
            int entradaAno = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a Descrição da Serie: ");
            string entradaDescricao = Console.ReadLine();

            Series novaSerie = new Series(Id: idDaSerie,
                                          genero: (Genero)entradaGenero,
                                          titulo: entradaTitulo,
                                          descricao: entradaDescricao,
                                          ano: entradaAno);
            repositorio.Atualiza(idDaSerie, novaSerie);
        }
        private static void ExcluirSerie()
        {
            Console.WriteLine("Digite o ID da Serie: "); 
            int idDaSerie = int.Parse(Console.ReadLine());

            repositorio.Exclui(idDaSerie);
        }
        private static void VisualizarSerie()
        {
            Console.WriteLine("Digite o ID da Serie: ");
            int idDaSerie = int.Parse(Console.ReadLine());

            var serie = repositorio.RetornaPorId(idDaSerie);

            Console.WriteLine(serie);
        }

        private static string ObterOpcaoUsuario()
        {
            Console.WriteLine();
            Console.WriteLine("App de Sérires");
            Console.WriteLine("Informe a opção desejada");

            Console.WriteLine("1 - Listar séries");
            Console.WriteLine("2 - Inserir uma nova série");
            Console.WriteLine("3 - Atualizar série");
            Console.WriteLine("4 - Excluir série");
            Console.WriteLine("5 - Visualizar série");
            Console.WriteLine("C - Limpar Tela");
            Console.WriteLine("X - Sair");
            Console.WriteLine();

            string opcao = Console.ReadLine().ToUpper();
            Console.WriteLine();
            return opcao;
        }
    }
}
