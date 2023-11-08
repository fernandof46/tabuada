using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lacoRepeticao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //solicita uma tabuada para o usuário
            string opcao = "";

            while (opcao != "0") ;
            {
                

                Console.WriteLine("Qual tqbuada deseja calcular?");
                int tabuada = Convert.ToInt32(Console.ReadLine());

                for(int num = 1; num <= 10; num++)
                {
                    Console.WriteLine($"{tabuada} x {num} = {tabuada * num}");
                }
            }
            Console.WriteLine("Deseja imprimir outra tabuada? (0 = não)");
            opcao = Console.ReadLine();
            Console.Clear();


        }
    }
}
