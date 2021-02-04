using System;

namespace SegundoEjercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                string[] NumFolio = new string[10];
                float[] sueldo = new float[10];
                int[] op = new int[10];
                int i;


                for (i = 0; i < 10; i++)
                {
                    Console.WriteLine("{0}º persona", i + 1);
                    Console.Write("Sueldo:");
                    sueldo[i] = float.Parse(Console.ReadLine());
                    Console.Write("Numero de Folio:");
                    NumFolio [i] = Console.ReadLine();
                    Console.Write("1 = Femenino, 2 = Masculino:");
                    op[i] = int.Parse(Console.ReadLine());
                }
                Console.WriteLine();
                for (i = 0; i < 10; i++)
                {
                    if (op[i] == 1 && sueldo[i] > 900000 || op[i] == 2 && sueldo[i] < 1000000)
                        Console.WriteLine("Legajo: {0}|Sexo: {1}|Sueldo: {2}", NumFolio[i], op[i], sueldo[i]);
                }
                Console.Read();
            }
        }
    }
}
