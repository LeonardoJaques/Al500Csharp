﻿using System;
namespace Al500CSharp
{
    public class Algoritmo21
    {

        /* DESAFIO
        prog teste
        
        */

        private void Logic()
        {
            double[] calculo = new double [8];
            calculo[0] = 12.0+5.0/2.0;
            calculo[1] = (12.0 + 5.0) / 2.0;
            calculo[2] = Math.Pow(64,0.25);
            calculo[3] = 64 * 0.25;
            calculo[4] = 3.0 * 7.0 % 5.0;
            calculo[5] = 3.0 * 7.0 / 5.0;
            calculo[6] = (3.0 * 7.0) / 5.0;


            Console.WriteLine("\nTestando Hierarquia\n");

            Console.WriteLine($"\n12+5/2é igual a: {calculo[0]}");

            Console.WriteLine($"\nÉ DIFERENTE DE (12 + 5)/2 que é igual a: {calculo[1]} " +
                $"logo / tem HIERARQUIA MAIOR do que + ou -");

            Console.WriteLine($"\n64**1/4 é igual a: {calculo[3]}");
            Console.WriteLine($"\nÉ DIFERENTE de 64**(1/4)que é igual a: {calculo[2]} logo **" +
                $" tem HIERARQUIA MAIOR do que* ou /;" );

            Console.WriteLine($"\n3 * 7 div 5 é igual a: {calculo[4]}");
            Console.WriteLine($"\n É DIFERENTE de(3 * 7) % 5 que é igual a: {calculo[5]}"+
                " logo % tem HIERARQUIA MAIOR do que * ");
            
            Console.WriteLine($"\nÉ IGUAL a (3 * 7) div 5 : {calculo[6]} "+

        }
        public void Run() => Logic();

    }
}