using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rocketseat_Fundamentos_Desafio;
class Desafio05
{
    public static void Placa(string placa)
    {
        
        string placaSemEspaco = placa.Replace(" ", "").Replace("-", "");

        bool Numerico = false;

        string ultimas4Posicoes = placaSemEspaco.Substring(placaSemEspaco.Length - 4);
        int contagem = 0;
        for (int i = 0; i < ultimas4Posicoes.Length; i++)
        {
            if ((Char.IsLetter(ultimas4Posicoes[i])))
            {
                Numerico = false;
                break;
            }
            else
            {
                Numerico = true;
            }            
        }

        if (ContaCaracteres.ContarCaracteres(placaSemEspaco) != 7)
        {
            Console.WriteLine("***Falso***");
        }
        else if (!(Char.IsLetter(placaSemEspaco[0]) && Char.IsLetter(placaSemEspaco[1]) && Char.IsLetter(placaSemEspaco[2])))
        {
            Console.WriteLine("***Falso***");
        }
        else if (Numerico != true)
        {
            Console.WriteLine("***Falso***");
        }
        else
        {
            Console.WriteLine("***Verdadeiro***");
        }

    }
}
