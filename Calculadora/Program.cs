using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<Operacoes> filaOperacoes = new();
            Stack<BigInteger> valorOperacoesProcessadas = new();

            filaOperacoes.Enqueue(new Operacoes { valorA = 2, valorB = 3, operador = '+' });
            filaOperacoes.Enqueue(new Operacoes { valorA = 14, valorB = 8, operador = '-' });
            filaOperacoes.Enqueue(new Operacoes { valorA = 5, valorB = 6, operador = '*' });
            filaOperacoes.Enqueue(new Operacoes { valorA = 2147483647, valorB = 2, operador = '+' });
            filaOperacoes.Enqueue(new Operacoes { valorA = 18, valorB = 3, operador = '/' });

            Calculadora calculadora = new();

            while (filaOperacoes.Count > 0)
            {
                Operacoes operacao = filaOperacoes.Dequeue();
                calculadora.calcular(operacao);

                Console.WriteLine("{0} {1} {2} = {3}", operacao.valorA, operacao.operador, operacao.valorB, operacao.resultado);

                valorOperacoesProcessadas.Push(operacao.resultado);

                foreach (var proximaOperacao in filaOperacoes)
                {
                    Console.WriteLine("{0} {1} {2}", proximaOperacao.valorA, proximaOperacao.operador, proximaOperacao.valorB);
                }
                Console.WriteLine();
            }

            foreach (var valorOperacaoProcessada in valorOperacoesProcessadas)
            {
                Console.WriteLine(valorOperacaoProcessada);
            }
        }
    }
}
