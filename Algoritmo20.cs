﻿using System;
namespace Al500CSharp
{
    /*
    prog funcoes
         */


    public class Algoritmo20
    {

        private void Logic(){

            string c, c1, d, d1, e;
            string strtam, strconcat, strprim;
            string strult, strresto, strelem;
            string strnprim, strnresto;


            Console.WriteLine("\nDigite a primeira palavra: ");
            c = Console.ReadLine();

            Console.WriteLine("\nDigite a segunda palavra: ");
            c1 = Console.ReadLine();

            strtam = Convert.ToString(c.Length);
            
            d1 = string.Concat(c,c1);
            d = string.Copy(c);
            e = c;

            strprim = d1.Substring(0,1);
            strult = d1.Substring(d1.Length - 1,1);
            strresto = d1.Substring(1,d1.Length - 1);
            strelem = d1.Substring(2,1);
            strnprim = d1.Substring(0, 3);
            strnresto = d1.Substring(d1.Length - 3);


            Console.WriteLine($"\nO tamanho da primeira palavra é: {strtam}");
            Console.WriteLine($"\nConcatenando sem armazenar: {c+c1}");
            Console.WriteLine($"\nO conteudo de D variavel que teve valor (COPIADO) de c: {d}");
            Console.WriteLine($"\nO conteudo de E variavel que teve valor (ATRIBUIDO) de c: {e}");
            Console.WriteLine($"\nConcatenacao com armazenamento: {d1}");
            Console.WriteLine($"\nImprimindo a letra inicial: {strprim}");
            Console.WriteLine($"\nImprimindo a letra final: {strult}");
            Console.WriteLine($"\nTodas as letras menos a inicial da primeira palavra: {strresto}");
            Console.WriteLine($"\nO terceiro elemento da palavra: {strelem}");
            Console.WriteLine($"\nOs três elementos iniciais: {strnprim}");
            Console.WriteLine($"\nOs três elementos finais: {strnresto}");
        }
        public void Run() => Logic();


    }
}