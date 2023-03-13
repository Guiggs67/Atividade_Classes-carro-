using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_de_classe_carro_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n_carros;
            Console.WriteLine("Digite o numero de carros: ");
            n_carros = int.Parse(Console.ReadLine());

            string[] marca= new string[n_carros];
            string[] modelo = new string[n_carros];
            int[] ano = new int[n_carros];
            double[] velocidade = new double[n_carros];
            

            Carro C1 = new Carro (n_carros,modelo,marca, ano, velocidade);
            


            for(int i =0; i <n_carros; i ++)
            {
                Console.WriteLine("Digite a marca do carro:");
                marca[i] = Console.ReadLine();
                Console.WriteLine("Digite a modelo do carro:");
                modelo[i] = Console.ReadLine();
                Console.WriteLine("Digite a ano do carro:");
                ano[i] = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite a velocidade do carro:");
                velocidade[i] = double.Parse(Console.ReadLine());

                Console.WriteLine("Deseja acelerar(1) ou parar(2)");
                int resposta = int.Parse(Console.ReadLine());

                if (resposta == 1)
                {
                    C1.Acelerar(velocidade);
                }
                else
                {
                    C1.Parar(velocidade);
                }

            }
            for (int i = 0; i < n_carros; i++)
            {
                Console.WriteLine(marca[i]);
                Console.WriteLine(modelo[i]);
                Console.WriteLine(ano[i]);
                Console.WriteLine(velocidade[i]);
            }

            Console.ReadKey();
        }
    }
}
