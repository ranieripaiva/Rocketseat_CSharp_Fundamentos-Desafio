using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rocketseat_Fundamentos_Desafio;
class Desafio03
{
    public static void calcular(string nome) { 
        Operacoes operacoes = new Operacoes();

        Console.WriteLine(nome + ", inisira dois valores abaixo para realizarmos alguns calculos!");
            Console.Write("Primeiro valor .: ");

            double val1 = Double.Parse(Console.ReadLine());

        Console.Write("Segundo valor .: ");

            double val2 = Double.Parse(Console.ReadLine());

        (double add, double minus, double times, double division, double average) = operacoes.Valores(valor1: val1, valor2: val2);

        Console.WriteLine("Resultado da adição: " + add);
        Console.WriteLine("Resultado da subtração: " + minus);
        Console.WriteLine("Resultado da multiplicação: " + times);
        Console.WriteLine("Resultado da divisão: " + division);
        Console.WriteLine("Resultado da média: " + average);
    }
}
