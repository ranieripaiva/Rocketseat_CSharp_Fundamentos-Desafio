
namespace Rocketseat_Fundamentos_Desafio;
class Operacoes
{       
    public (double rresultAdd, double resultMinus, double resultTime, double resultdivision, double averege) Valores(double valor1, double valor2)
    {
        double add = valor1 + valor2;
        double minus = valor1 - valor2;
        double times = valor1 * valor2;
        double division = 0;
        if (valor2 == 0)
        {
          Console.WriteLine("Divisão por zero não permitida!");
        }
        else
        {
            division = valor1 / valor2;
        }        
        double average = (valor1 + valor2)/2;

        return (add, minus, times, division, average);
    }


}
