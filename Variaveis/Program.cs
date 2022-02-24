using System;

namespace Variaveis
{
    class Program
    {
        static void Main(string[] args)
        {
            int inteiro;
            uint uinteiro;
            char letra;
            float real;
            double realDouble;
            bool booleano;


            inteiro = 6; //inteiro
            uinteiro = 3; //inteiro unsigned
            
            Console.WriteLine("{0}, {1}", inteiro, uinteiro);

            letra = 'a'; // char

            Console.WriteLine(letra);

            real = 0.22222;
            realDouble = 2.55555555;

            Console.WriteLine("{0} {1}", real, realDouble);

            booleano = false;

            Console.WriteLine(booleano);




        }
    }
}
