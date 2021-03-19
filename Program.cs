using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_7
{
    class Program
    {
        static void Main(string[] args)
        {
            string resposta = "sim";

            while (resposta == "sim")
            {
                Pessoa a = new Pessoa();
                Console.WriteLine("Por favor digite seu peso");
                a.peso = double.Parse(Console.ReadLine());
                Console.WriteLine("Por favor digite sua altura");
                a.altura = double.Parse(Console.ReadLine());
                a.mensagem();
                do
                {
                    Console.WriteLine("Gostaria de Calcular novamente? Digite sim ou não");
                    resposta = Console.ReadLine();
                    resposta = resposta.Trim();
                    resposta = resposta.ToLower();
                    if (resposta == "sim")
                    {
                        resposta = "sim";
                    }
                    else if (resposta == "não")
                    {
                        resposta = "não";
                    }
                    else
                    {
                        Console.WriteLine("Resposta invalida!");
                        resposta = "erro";
                    }
                }
                while (resposta == "erro");
                Console.Clear();
            }
        }
    }
}
