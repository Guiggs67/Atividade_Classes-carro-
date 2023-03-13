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

            Carro[] C1 = new Carro[n_carros];

            string marca;
            string modelo;
            int ano;
            double velocidade;
            


            for(int i =0; i <n_carros; i ++)
            {
                Console.WriteLine("Digite a marca do carro:");
                marca = Console.ReadLine();
                Console.WriteLine("Digite a modelo do carro:");
                modelo= Console.ReadLine();
                Console.WriteLine("Digite a ano do carro:");
                ano= int.Parse(Console.ReadLine());
                Console.WriteLine("Digite a velocidade do carro:");
                velocidade= double.Parse(Console.ReadLine());
                C1[i] = new Carro(modelo, marca, ano, velocidade);

                Console.WriteLine("Deseja acelerar(1) ou parar(2)");
                int resposta = int.Parse(Console.ReadLine());

                if (resposta == 1)
                {
                    C1[i].Acelerar();
                }
                else
                {
                    C1[i].Parar();
                }

            }
            for (int i = 0; i < n_carros; i++)
            {
                C1[i].Escrita();
            }

            Console.ReadKey();
        }
    }
}
