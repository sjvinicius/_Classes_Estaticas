using System;
using _Classes_Atributos_Metodos_Static.Classes_static;

namespace _Classes_Atributos_Metodos_Static
{
    class Program
    {
        static void Main(string[] args)
        {
        
            //Variáveis
            char operades;
            float cotdol;
            float cotreal;
            string r = "n";


            //Menu
            Console.WriteLine("-----    -------------------------------------------");
            Console.WriteLine("-----    CONVERSOR 2.0 ULTRA HD");
            Console.WriteLine("-----    -------------------------------------------");
            Console.WriteLine("-----    Qual Operação Deseja Fazer?");
            Console.WriteLine("-----    [1] Dólar Para Real (Dol To Real)");
            Console.WriteLine("-----    [2] Real Para Dólar (Real To Dol)");
            

            //Receber a Operação Desejada
            operades = char.Parse( Console.ReadLine() );

            do
            {
                

                switch (operades)
                {

                    case '1':

                        Console.WriteLine("-----    -------------------------------------------");
                        Console.WriteLine("-----    Dólar Para Real (Dol To Real)");
                        Console.WriteLine("-----    -------------------------------------------");
                        // Console.Write("-----    Digite a Cotação do Real: ");
                        // cotreal = float.Parse( Console.ReadLine() );
                        cotreal = 0.20f;
                        Console.Write("-----    Digite o Valor: US$");
                        Conversor.Dolar = 1f;
                        Console.Write($"\n-----    O Resultado da Conversão é: R${ Conversor.dolartoreal(cotreal, Conversor.Dolar)}"  ) ;
                        Console.WriteLine("\n-----    -------------------------------------------");

                        break;

                    case '2':

                        Console.WriteLine("-----    -------------------------------------------");
                        Console.WriteLine("-----    Real Para Dólar (Real To Dol)");
                        Console.WriteLine("-----    -------------------------------------------");
                        // Console.Write("-----    Digite a Cotação do Dólar: ");
                        // cotdol = float.Parse( Console.ReadLine() );
                        cotdol = 5.15f;
                        Console.Write("-----    Digite o Valor: R$");
                        // Conversor.Real = float.Parse( Console.ReadLine() );
                        Conversor.Real = 1;
                        Console.Write($"\n-----    O Resultado da Conversão é: US${ Conversor.realtodolar(cotdol, Conversor.Real) }"  ) ;
                        Console.WriteLine("\n-----    -------------------------------------------");

                        break;


                    default:

                        Console.WriteLine("-----    -------------------------------------------");
                        Console.WriteLine("-----    !!! ALERTA !!! \n-----    Operação Inválida Tente Novamente, \n------    Digite um Valaor Válido");
                        Console.WriteLine("-----    -------------------------------------------");
                        
                        r = "s";

                        break;
                }
            
            
            } while ( r == "s");
            
        }
    }
}
