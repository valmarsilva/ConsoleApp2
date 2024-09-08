using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");


            // numeeros iteriros
            byte idade1 = 30;
            sbyte idade2 = -40;
            short valor1 = 30000;
            ushort valor2 = 65535;
            int pontos1 = 10000;
            uint pontos2 = 30000;
            ulong contador = 2000000;
            long contagem = 8000000;

            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.Clear();
            Console.SetWindowSize(42, 22);
            Console.Title = "Tipos Inteiros";

            Linha(true);
            Console.SetCursorPosition(10, 1);
            ConsoleColor a = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Tipos Inteiros em C# \n");
            Console.ForegroundColor = a;
            Linha(true);

            Console.Write("\n\nVariavel do tipo byte  :{0}\n", idade1);
            Linha(false);
            Console.Write("\n\nVariavel do tipo sbyte  :{0}\n", idade2);
            Linha(false);

            Console.Write("\n\nVariavel do tipo short  :{0}\n", valor1);
            Linha(false);

            Console.Write("\n\nVariavel do tipo ushort :{0}\n", valor2);
            Linha(false);

            Console.Write("\n\nVariavel do tipo int  :{0}\n", pontos1);
            Linha(false);

            Console.Write("\n\nVariavel do tipo uint  :{0}\n", pontos1);
            Linha(false);

            Console.Write("\n\nVariavel do tipo ulong  :{0}\n", contador);
            Linha(false);

            Console.Write("\n\nVariavel do tipo long  :{0}\n", contagem);
            Linha(false);
            Console.ReadLine();


            //Ponto Flutuante



            int x = 3;
            float y = 4.5f;
            decimal d = 9.1m;
            double w = 1.7E+3;
            short z = 5;

            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.Clear();
            Console.SetWindowSize(42, 22);
            Console.Title = "Tipos de  Pontos Flutuantes";


            Linha(true);
            Console.SetCursorPosition(1, 1);
            a = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Tipos de Pontos Flutuante em C# [float]\n");
            Console.ForegroundColor = a;
            Linha(true);
            Console.Write("\n0 Resultado : {0}\n", x * y / z);

            Linha(true);
            Console.ReadLine();

            Linha(true);
            Console.SetCursorPosition(1, 1);
            a = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Tipos de Pontos Flutuante em C# [decimal]\n");
            Console.ForegroundColor = a;
            Linha(true);
            Console.Write("\n0 Resultado : {0}\n", (d + x));
            Linha(true);
            Console.ReadLine();

            Linha(true);
            Console.SetCursorPosition(1, 1);
            a = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Tipos de Pontos Flutuante em C# [double]\n");
            Console.ForegroundColor = a;
            Linha(true);
            Console.Write("\n0 Resultado : {0}\n", x + y + z + w);
            Linha(true);
            Console.ReadLine();



            //Booleano
            bool bt = true;
            bool bf = false;

            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.Clear();
            Console.SetWindowSize(42, 22);
            Console.Title = "Tipo Booleano";


            Linha(true);
            Console.SetCursorPosition(1, 1);
            a = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("TipoBooleano em C# [bool]\n");
            Console.ForegroundColor = a;
            Linha(true);
            Console.Write("\nBT : {0}  \t BF: {1}\n ", bt, bf);
            Linha(true);

            Console.ReadLine();
        }
        static void Linha(bool tipo) // se tiop = 0 "-" senão "="
        {

            ConsoleColor a = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.DarkGreen;for (int linha =1; linha <=40; linha++)
            {
                if(tipo)
                {
                    Console.Write("=");
                }
                else
                {
                    Console.Write("-");
                }
            }
            Console.ForegroundColor = a;





        }





        }
    }

