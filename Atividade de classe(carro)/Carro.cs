using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_de_classe_carro_
{
    internal class Carro
    {
        public string _modelo;
        public string _marca;
        public int _ano;
        public double _velocidade;
       
        public Carro(string  modelo, string marca, int ano, double velocidade)
        {
            _modelo = modelo;
            _marca = marca;
            _ano = ano;
            _velocidade = velocidade;
        }
        public void Acelerar()
        {
            _velocidade +=50;
                 

        }
        public void Parar()
        {
            _velocidade =0;
        }

        public void Escrita()
        {
            Console.WriteLine($"_modelo: {_modelo}");
            Console.WriteLine($"_marca: {_marca}");
            Console.WriteLine($"_modelo: {_ano}");
            Console.WriteLine($"_: {_velocidade}");

        }


    }

    
        
        
}
