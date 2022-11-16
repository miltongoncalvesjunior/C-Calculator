using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {

          Menu();
        }

        static void Menu()
        {
            Console.Clear();

            Console.WriteLine("Qual operação matematica basica deseja?");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtracão");
            Console.WriteLine("3 - Divisão");
            Console.WriteLine("4 - Multiplicação");
            Console.WriteLine("5 - Sair");
            

            Console.WriteLine("-------------");
            Console.WriteLine("Selecione uma opção: ");
            
            short res = short.Parse(Console.ReadLine());

            switch(res)
            {
                case 1: Soma();break;
                case 2: Subtracao();break;
                case 3: Divisao();break;
                case 4: Multiplicacao();break;
                case 5: System.Environment.Exit(0); break;
                default: Menu();break;
            }   
          

        }

        static void Soma()
        {
            Console.Clear();
            Console.WriteLine("primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());
            Console.WriteLine("segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine(" ");

            float resultado = v1 + v2;
            Console.WriteLine($"A soma dos valores é: {resultado}");
            /* opções  interpolação
            Console.WriteLine("A soma dos valores é: " + resultado); 
            Console.WriteLine("A soma dos valores é: {v1 + v2}");
            Console.WriteLine("A soma dos valores é:" + ( v1 + v2));
            */
            Console.ReadKey();
            Menu();

        }
        
        static void Subtracao()
        {
            Console.Clear();

            Console.WriteLine("Primeiro valor:");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor:");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine(" ");

            float resultado = v1 - v2;  
            Console.WriteLine($" A Subtração dos valores é: {resultado}");
            Console.ReadKey();
            Menu();
        }

        static void Divisao()
        {
            Console.Clear();

            Console.WriteLine("Primeiro valor:");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor:");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine(" ");

            float resultado = v1/v2;
            Console.WriteLine($"A Divisão dos valores é: {resultado}");

            Console.ReadKey();
            Menu();


        }

        static void Multiplicacao()
        {
            Console.Clear ();

            Console.WriteLine("Primeiro valor:");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor:");
            float v2 = float.Parse(Console.ReadLine());
            
           Console.WriteLine("");
           
            float resultado = v1*v2;
            Console.WriteLine ("A Multiplicação dos valores é:" + (v1 * v2   ));
            Console.ReadKey();
            Menu();
        }
        

    }
}
