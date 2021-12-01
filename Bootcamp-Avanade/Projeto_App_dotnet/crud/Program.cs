using System;


namespace crud.Series
{
    class Program
    {
        static SerieRepositorio repositorio = new SerieRepositorio();
        static void Main(string[] args)
        {
            string opcaoUsuario = ObterOpcaoUsuario();

            while (opcaoUsuario.ToUpper() != "X")
                {
                    switch (opcaoUsuario)
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
                            VizualizarSerie();
                            break;
                        case "C":
                            Console.Clear();
                            break;
                        default:
                        throw new ArgumentOutOfRangeException();
                    }
                    opcaoUsuario = ObterOpcaoUsuario();

                }
                Console.WriteLine("Obrigado por utilizar nossos serviços");
                Console.ReadLine();
            
        }
            //listar series
            private static void ListarSeries()
            {
                Console.WriteLine("Listar Séries");

                var lista = repositorio.Lista();

                if (lista.Count == 0)
                {
                    Console.WriteLine("Nenhuma série encontrada");
                    return;
                }
                foreach (var serie in lista)
                {
                    var excluido = serie.retornaExcluido();
                    
                    Console.WriteLine("#ID {0}: - {1} {2}", serie.retornaId(), serie.retornaTitulo(), (excluido ? ">Excluido<" : ""));
                }
            }

            //INSERIR SERIES
                
            private static void InserirSerie()
            {
                Console.WriteLine("Inserir nova série");

                foreach (int i in Enum.GetValues(typeof(Genero)))
                {
                    Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Genero), i));
                
                }
                Console.WriteLine("Digite o genêro entre as opções acima");
                int entradaGenero = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite o titiulo da Série: ");
                string entradaTitulo = (Console.ReadLine());

                Console.WriteLine("Digite o ano de Inicio da Série: ");
                int entradaAno = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite a descrição da Série: ");
                string entradaDescricao = Console.ReadLine();

                Serie novaSerie = new Serie(id: repositorio.ProximoId(),
                                            genero: (Genero)entradaGenero,
                                            titulo: entradaTitulo,
                                            ano: entradaAno,
                                            descricao: entradaDescricao);

                repositorio.Insere(novaSerie);

            }    

            private static void AtualizarSerie()
            {
                Console.WriteLine("Digite o Id da série: ");
                int indiceSerie = int.Parse(Console.ReadLine());

                foreach (int i in Enum.GetValues(typeof(Genero)))
                {
                    Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Genero), i));
                }

                Console.Write("Digite o Gênero entre as opções acima");
                int entradaGenero = int.Parse(Console.ReadLine());

                Console.Write("Digite o titulo da Série: ");
                string entradaTitulo = Console.ReadLine();

                Console.Write("Insira o ano da Série: ");
                int entradaAno = int.Parse(Console.ReadLine());

                Console.Write("Insira a descrição da Série: ");
                string entradaDescricao = Console.ReadLine();

                Serie atualizaSerie = new Serie(id: indiceSerie,
                                            genero: (Genero)entradaGenero,
                                            titulo: entradaTitulo,
                                            ano: entradaAno,
                                            descricao: entradaDescricao );

                repositorio.Atualiza(indiceSerie, atualizaSerie);

            }

            private static void ExcluirSerie()
            {
                Console.Write("Digite o id da série: ");
                int indiceSerie = int.Parse(Console.ReadLine());

                repositorio.Exclui(indiceSerie);
            }

            private static void VizualizarSerie()
            {
                Console.Write("Digite o id da série: ");
                int indiceSerie = int.Parse(Console.ReadLine());

                var serie = repositorio.RetornarPorId(indiceSerie);

                Console.WriteLine(serie);
            }



            private static string ObterOpcaoUsuario()  
          {
            Console.WriteLine();
            Console.WriteLine("Aplicação iniciada 'Séries'");     
            Console.WriteLine("Informe a sua opção: *");

            Console.WriteLine("1- Listar séries");
            Console.WriteLine("2- Inserir novas séries");
            Console.WriteLine("3- Atualizar série");
            Console.WriteLine("4- Excluir série");
            Console.WriteLine("5- Vizualizar série");
            Console.WriteLine("C- Limpar tela");
            Console.WriteLine("X- Sair");

            string opcaoUsuario = Console.ReadLine().ToUpper();
            Console.WriteLine();
            return opcaoUsuario;

          }  


    }
}