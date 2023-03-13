using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_de_classe_carro_
{
    internal class Carro
    {
        public string[]_modelo;
        public string[]_marca;
        public int[]_ano;
        public double[]_velocidade;
        public int n_car;
       
        public Carro(int n_car, string [] modelo, string[] marca, int[] ano, double[]velocidade)
        {
            _modelo = modelo;
            _marca = marca;
            _ano = ano;
            _velocidade = velocidade;
        }
        public void Acelerar(double []velocidade)
        {
            _velocidade = velocidade;
            
            for (int i = 0; i < n_car; i++)
            {
                velocidade[i] += 50;
            }

        }
        public void Parar(double []velocidade)
        {
            _velocidade = velocidade;
            for (int i = 0; i < n_car; i++)
            {
                velocidade[i] =0;
            }
        }


    }

    
        
        
}
