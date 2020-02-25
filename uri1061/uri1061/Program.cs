using System;

namespace Uri1061
{
    class Program
    {
        static void Main(string[] args)
        {
            int dia1, dia2, hr1, min1, seg1, hr2, min2, seg2, W, X, Y, Z, inicio, fim, duracao, resto;
            string s;

            s = "DIA ";
            Console.Write(s);
             dia1 = int.Parse(Console.ReadLine());

            string[] valores = Console.ReadLine().Split(' ');
            hr1 = int.Parse(valores[0]);
            min1 = int.Parse(valores[2]);
            seg1 = int.Parse(valores[4]);

            Console.Write(s);
            dia2 = int.Parse(Console.ReadLine());

            valores = Console.ReadLine().Split(' ');
            hr2 = int.Parse(valores[0]);
            min2 = int.Parse(valores[2]);
            seg2 = int.Parse(valores[4]);

            inicio = (dia1 - 1) * 24 * 60 * 60 + hr1 * 60 * 60 + min1 * 60 + seg1;
            fim = (dia2 - 1) * 24 * 60 * 60 + hr2 * 60 * 60 + min2 * 60 + seg2;
            duracao = fim - inicio;

            W = duracao / (24 * 60 * 60);
            resto = duracao % (24 * 60 * 60);
            X = resto / (60 * 60);
            resto = resto % (60 * 60);
            Y = resto / 60;
            Z = resto % 60;

            Console.WriteLine(W + " dia(s)");
            Console.WriteLine(X + " hora(s)");
            Console.WriteLine(Y + " minuto(s)");
            Console.WriteLine(Z + " segundo(s)");
        }
    }
}
