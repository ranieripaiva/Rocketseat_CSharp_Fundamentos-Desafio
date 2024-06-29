using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rocketseat_Fundamentos_Desafio;
class Desafio06
{
    public static void Datas()
    {
        while (true)
        {
            Console.WriteLine("Selecione uma opção para exibir a data atual:");
            Console.WriteLine("1 - Formato completo (dia da semana, dia do mês, mês, ano, hora, minutos, segundos)");
            Console.WriteLine("2 - Apenas a data no formato \"01/03/2024\"");
            Console.WriteLine("3 - Apenas a hora no formato de 24 horas");
            Console.WriteLine("4 - A data com o mês por extenso");
            Console.WriteLine("5 - Sair");

            string opcao = Console.ReadLine();

            // Obter a data e hora atual
            DateTime agora = DateTime.Now;

            switch (opcao)
            {
                case "1":
                    Console.WriteLine("Formato completo:");
                    Console.WriteLine(agora.ToString("dddd, dd MMMM yyyy HH:mm:ss"));
                    break;
                case "2":
                    Console.WriteLine("Apenas a data:");
                    Console.WriteLine(agora.ToString("dd/MM/yyyy"));
                    break;
                case "3":
                    Console.WriteLine("Apenas a hora:");
                    Console.WriteLine(agora.ToString("HH:mm:ss"));
                    break;
                case "4":
                    Console.WriteLine("Data com o mês por extenso:");
                    Console.WriteLine(agora.ToString("dd 'de' MMMM 'de' yyyy"));
                    break;
                case "5":
                    Console.WriteLine("Saindo...");
                    return; // Encerra o programa
                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    break;
            }

            Console.WriteLine(); // Linha em branco para separar as saídas
            Console.WriteLine("Pressione qualquer tecla para continuar...");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
