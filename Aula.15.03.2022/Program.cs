using System;
using E = Aula.Entidade;

namespace Aula._15._03._2022
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Tipo de Valor

            //string nome1 = "Juliano";
            //string nome2 = nome1;

            //nome1 = "João";

            //Console.WriteLine($"{nameof(nome1)}:{nome1}");
            //Console.WriteLine($"{nameof(nome2)}:{nome2}");

            //Console.ReadLine();

            #endregion Tipo de Valor

            #region Tipo de Referencia

            //E.Pessoa pessoa = new E.Pessoa()
            //{
            //    Nome = "Juliano",
            //};

            //pessoa.Nome = "João";

            //E.Pessoa pessoa = new E.Pessoa(null);

            //E.Pessoa pessoa1 = new E.Pessoa("Juliano");
            //E.Pessoa pessoa2 = pessoa1;

            //pessoa1.Nome = "João";

            E.Pessoa pessoa1 = new E.Pessoa("Juliano");
            E.Pessoa pessoa2 = pessoa1;

            pessoa1 = new E.Pessoa("João");
            pessoa2 = pessoa1;

            Console.WriteLine($"{nameof(pessoa1)}:" +
                $"{pessoa1.Nome}");

            Console.WriteLine($"{nameof(pessoa2)}:" +
                $"{pessoa2.Nome}");

            Console.ReadLine();

            #endregion Tipo de Referencia
        }
    }
}