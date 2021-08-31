using Alura.Estacionamento.Modelos;
using System;
using System.Collections.Generic;

namespace Alura.Estacionamento
{
    class Program
    {
  
            // Cria uma lista de objetos do tipo veículos, para armazenar
            // os veículos (automovéis e motos) que estão no estacionamento;
            static List<Veiculo> estacionamento = new List<Veiculo>();
            static double faturado = 0;

            static void Main(string[] args)
            {
                string opcao;
                do
                {
                    Console.WriteLine(MostrarCabecalho());
                    Console.WriteLine(MostrarMenu());
                    opcao = LerOpcaoMenu();
                    ProcessarOpcaoMenu(opcao);
                    Console.Clear();// limpa a tela;

                } while (opcao != "5");
            }

            static void ProcessarOpcaoMenu(string opcao)
            {
                switch (opcao)
                {
                    case "1":
                        RegistrarEntradaVeiculo();
                        break;
                    case "2":
                        RegistrarSaidaVeiculo();
                        break;
                    case "3":
                        MostrarFaturamento();
                        break;
                    case "4":
                        MostrarVeiculosEstacionados();
                        break;
                    case "5":
                        Console.WriteLine("Obrigado por utilizar o programa.");
                        Console.WriteLine("Pressione qualquer tecla para prosseguir.");
                        Console.ReadKey();
                        break;
                    default:
                        Console.WriteLine("Opção de menu inválida!");
                        Console.WriteLine("Pressione qualquer tecla para prosseguir.");
                        Console.ReadKey();
                        break;
                }
            }

            static void MostrarVeiculosEstacionados()
            {
                Console.Clear();
                Console.WriteLine(" Veículos Estacionados");
                foreach (Veiculo v in estacionamento)
                {
                    // placa, propr, hora
                    Console.WriteLine("Placa :{0}", v.Placa);
                    Console.WriteLine("Proprietário :{0}", v.Proprietario);
                    Console.WriteLine("Hora de entrada :{0:HH:mm:ss}", v.HoraEntrada);
                    Console.WriteLine("********************************************");
                }
                if (estacionamento.Count == 0)
                {
                    Console.WriteLine("Não há veículos estacionados no momento...");
                }
                Console.WriteLine("Pressione qualquer tecla para prosseguir.");
                Console.ReadKey();
            }

            static void MostrarFaturamento()
            {
                Console.Clear();
                Console.WriteLine("Total faturado até o momento :::::::::::::::::::::::::::: {0:c}", faturado);
                Console.WriteLine("Pressione qualquer tecla para prosseguir.");
                Console.ReadKey();
            }

            static void RegistrarSaidaVeiculo()
            {
                Console.Clear();
                Console.WriteLine("Registro de Saída de Veículos");
                Console.Write("Placa: ");
                string placa = Console.ReadLine();
                Veiculo encontrado = null;
                foreach (Veiculo v in estacionamento)
                {
                    if (v.Placa == placa)
                    {
                        v.HoraSaida = DateTime.Now;
                        TimeSpan tempo = v.HoraSaida - v.HoraEntrada;
                        double valorCobrado = 0;
                        if (v is Automovel)
                        {
                            /// o método Math.Ceiling(), aplica o conceito de teto da matemática onde o valor máximo é o inteiro imediatamente posterior a ele.
                            /// Ex.: 0,9999 ou 0,0001 teto = 1
                            /// Obs.: o conceito de chão é invero e podemos utilizar Math.Floor();
                            valorCobrado = Math.Ceiling(tempo.TotalHours) * 2;

                        }
                        else if (v is Motocicleta)
                        {
                            valorCobrado = Math.Ceiling(tempo.TotalHours) * 1;
                        }

                        Console.WriteLine(" Hora de entrada: {0: HH:mm:ss}", v.HoraEntrada);
                        Console.WriteLine(" Hora de saída: {0: HH:mm:ss}", v.HoraSaida);
                        Console.WriteLine(" Permanência: {0: HH:mm:ss}", new DateTime().Add(tempo));
                        Console.WriteLine("Valor a pagar: {0:c}", valorCobrado);

                        encontrado = v;
                        faturado = faturado + valorCobrado;

                        break;
                    }

                }
                if (encontrado != null)
                {
                    estacionamento.Remove(encontrado);

                }
                else
                {
                    Console.WriteLine("Não há veículo com a placa informada.");
                }

                Console.WriteLine("Pressione qualquer tecla para prosseguir.");
                Console.ReadKey();
            }

            static void RegistrarEntradaVeiculo()
            {
                Console.Clear();
                Console.WriteLine("Registro de Entrada de Veículos");
                Console.Write("Tipo de veículo (1-Carro; 2-Moto) :");
                string tipo = Console.ReadLine();
                switch (tipo)
                {
                    case "1":
                        RegistrarEntradaAutomovel();
                        break;
                    case "2":
                        RegistrarEntradaMotocicleta();
                        break;
                    default:
                        Console.WriteLine("Tipo Inválido");
                        Console.WriteLine("Pressione qualquer tecla para prosseguir.");
                        Console.ReadKey();
                        break;
                }
            }

            static void RegistrarEntradaMotocicleta()
            {
                Console.WriteLine("Dados da Motocicleta");
                Motocicleta moto = new Motocicleta();
                //preeencher placa,cor,hora,entrada e proprietário
                Console.Write("Digite os dados da placa (XXX-9999): ");
                try
                {
                    moto.Placa = Console.ReadLine();
                }
                catch (FormatException fe)
                {
                    Console.WriteLine("ocorreu um problema: {0}", fe.Message);
                    Console.WriteLine("Pressione qualquer tecla para prosseguir.");
                    Console.ReadKey();
                    return;
                }
                Console.Write("Digite a cor da moto: ");
                moto.Cor = Console.ReadLine();
                Console.Write("Digite o nome do proprietário: ");
                moto.Proprietario = Console.ReadLine();
                moto.HoraEntrada = DateTime.Now;
                moto.Acelerar(5);
                moto.Freiar(5);
                estacionamento.Add(moto);
                Console.WriteLine("Motocicleta registrada com sucesso!");
                Console.WriteLine("Pressione qualquer tecla para prosseguir.");
                Console.ReadKey();
            }

            static void RegistrarEntradaAutomovel()
            {
                Console.WriteLine("Dados do Automovél");
                Automovel carro = new Automovel();
                //preeencher placa,cor,hora,entrada e proprietário
                Console.Write("Digite os dados da placa (XXX-9999): ");
                try
                {
                    carro.Placa = Console.ReadLine();
                }
                catch (FormatException fe)
                {
                    Console.WriteLine("ocorreu um problema: {0}", fe.Message);
                    Console.WriteLine("Pressione qualquer tecla para prosseguir.");
                    Console.ReadKey();
                    return;
                }
                Console.Write("Digite a cor do carro: ");
                carro.Cor = Console.ReadLine();
                Console.Write("Digite o nome do proprietário: ");
                carro.Proprietario = Console.ReadLine();
                carro.HoraEntrada = DateTime.Now;
                carro.Acelerar(5);
                carro.Freiar(5);
                estacionamento.Add(carro);
                Console.WriteLine("Automovél registrada com sucesso!");
                Console.WriteLine("Pressione qualquer tecla para prosseguir.");
                Console.ReadKey();
            }

            static string MostrarCabecalho()
            {
                return "Controle de Estacionamento Rotativo";
            }

            static string LerOpcaoMenu()
            {
                string opcao;
                Console.Write("Opção desejada: ");
                opcao = Console.ReadLine();
                return opcao;
            }
           
            static string MostrarMenu()
            {
                string menu = "Escolha uma opção:\n" +
                              "1 - Registrar Entrada\n" +
                              "2 - Registrar Saída\n" +
                              "3 - Exibir Faturamento\n" +
                              "4 - Mostrar Veículos Estacionados\n" +
                              "5 - Sair do Programa";
                return menu;
            }
        }
    
}
