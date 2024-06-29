using Rocketseat_Fundamentos_Desafio;
using System.Runtime.ConstrainedExecution;
using System.Runtime.Intrinsics.X86;

namespace Fundamentos;

class Program
{   

    static void Main()
    {
        // Desafio - 1 *********************************
        //              Crie um programa em que o usuário precisa digitar um nome e uma mensagem de boas vindas
        //              personalizada com o nome dele é exibida:  Olá, Welisson! Seja muito bem-vindo!

        string boasVindas = " Olá, {0}! Seja muito bem-vindo!";

        Console.Write("Insira seu nome.: ");

        string? nome = Console.ReadLine();

        string resultado = string.Format(boasVindas, nome );

        Console.WriteLine(resultado);
        Console.WriteLine("Pressione qualquer tecla para continuar...");
        Console.ReadKey();
        Console.Clear();

        // *********************************************

        // Desafio - 2 *********************************
        //              Crie um programa que concatene um nome e um sobrenome inseridos pelo usuário e ao final
        //              exiba o nome completo.

        string nomeCompleto = " Nome.: {0} {1}";

        Console.Write("Insira seu sobrenome.: ");

        string? sobreNome = Console.ReadLine();

        string resultadoCompleto = string.Format(nomeCompleto, nome, sobreNome);

        Console.WriteLine(resultadoCompleto);
        Console.WriteLine("Pressione qualquer tecla para continuar...");
        Console.ReadKey();
        Console.Clear();

        // *********************************************

        // Desafio - 3 *********************************
        //              1. Crie um programa com 2 valores do tipo **`double`** já declarados ****que retorne:
        //              -A soma entre esses dois números;
        //              -A subtração entre os dois números;
        //              -A multiplicação entre os dois números;
        //              -A divisão entre os dois números(vale uma verificação se o segundo número é 0!);
        //              -A média entre os dois números.

        Desafio03.calcular(nome);
        Console.WriteLine("Pressione qualquer tecla para continuar...");
        Console.ReadKey();
        Console.Clear();
        // *********************************************

        // Desafio - 4 *********************************
        //              Crie um programa em que o usuário digita uma ou mais palavras e é exibido a quantidade
        //              de caracteres que a palavra inserida tem.

        string semEspacos = nomeCompleto.Replace(" ", "");

        int comprimento = ContaCaracteres.ContarCaracteres(semEspacos);

        Console.WriteLine("Seu nome completo tem " + comprimento + " caracteres.");
        Console.WriteLine("Pressione qualquer tecla para continuar...");
        Console.ReadKey();
        Console.Clear();
        // *********************************************

        // Desafio - 5 *********************************
        //              1. Crie um programa em que o usuário precisa digitar a placa de um veículo e o programa verifica
        //              se a placa é válida, seguindo o padrão brasileiro válido até 2018:
        //              -A placa deve ter 7 caracteres alfanuméricos;
        //              -Os três primeiros caracteres são letras(maiúsculas ou minúsculas);
        //              -Os quatro últimos caracteres são números;
        //
        //              Ao final, o programa deve exibir*** Verdadeiro***se a placa for válida e ***Falso * **caso contrário.

        Console.Write(nome + ", digite a placa do seu veículo para validação.: ");
        string? placa = Console.ReadLine();
        Desafio05.Placa(placa);
        Console.WriteLine("Pressione qualquer tecla para continuar...");
        Console.ReadKey();
        Console.Clear();

        // *********************************************          

        // Desafio - 5 *********************************
        //              Crie um programa que solicita ao usuário a exibição da data atual em diferentes formatos:
        //              - Formato completo (dia da semana, dia do mês, mês, ano, hora, minutos, segundos).
        //              - Apenas a data no formato "01/03/2024".
        //              - Apenas a hora no formato de 24 horas.
        //              - A data com o mês por extenso.

        Desafio06.Datas();

        // *********************************************    


    }
}