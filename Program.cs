using System;

namespace Lambda;

class Program
{
    static void Main(string[] args)
    {
        // Tipo de função que não tem retorno.
        Action escreverConsole = () =>
        {
            System.Console.WriteLine("Eu sou uma Action, não tenho retorno!");
        };

        escreverConsole();

        // Tipo de função que apresenta retorno.
        Func<int> Sorteiro = () =>
        {
            Random random = new Random();
            return random.Next(1,101);
        };

        System.Console.WriteLine($"Eu sou uma Func, tenho um retono: {Sorteiro()}");

    }
}