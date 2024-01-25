using System;

namespace DataHora {

    public class DataHora {

        public static void Main() {

            String versao = "1.0", diaSemana, mes;

            Console.WriteLine("---------------------");
            Console.WriteLine("Data e Hora Atual! Versão - {0}", versao);
            Console.WriteLine("---------------------");

            while(true) {

                switch((int) DateTime.Now.DayOfWeek) {

                    case 0:
                        diaSemana = "Domingo";
                        break;

                    case 1:
                        diaSemana = "Segunda";
                        break;

                    case 2:
                        diaSemana = "Terça";
                        break;

                    case 3:
                        diaSemana = "Quarta";
                        break;

                    case 4:
                        diaSemana = "Quinta";
                        break;

                    case 5:
                        diaSemana = "Sexta";
                        break;

                    case 6:
                        diaSemana = "Sábado";
                        break;

                    default:
                        diaSemana = "N/D";
                        break;
                }

                switch((int) DateTime.Now.Month) {

                    case 1:
                        mes = "Janeiro";
                        break;

                    case 2:
                        mes = "Fevereiro";
                        break;

                    case 3:
                        mes = "Março";
                        break;

                    case 4:
                        mes = "Abril";
                        break;

                    case 5:
                        mes = "Maio";
                        break;

                    case 6:
                        mes = "Junho";
                        break;

                    case 7:
                        mes = "Julho";
                        break;

                    case 8:
                        mes = "Agosto";
                        break;

                    case 9:
                        mes = "Setembro";
                        break;

                    case 10:
                        mes = "Outubro";
                        break;

                    case 11:
                        mes = "Novembro";
                        break;

                    case 12:
                        mes = "Dezembro";
                        break;

                    default:
                        mes = "N/M";
                        break;
                }

                /* Escreve no console de forma dinâmica e sobrepõem os valores anteriores */
                Console.Write("\r {0} - {1} de {2} de {3} - {4}", diaSemana, DateTime.Now.ToString("dd"), mes, DateTime.Now.ToString("yyyy"),
                                 DateTime.Now.ToString("HH:mm:ss"));

                /* Faz com que o tempo para retornar demore um segundo */
                Thread.Sleep(1000);
            }
        }
    }
}