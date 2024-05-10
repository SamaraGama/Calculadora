using System;
using System.Numerics;
namespace Calculadora
{
    public class Calculadora
    {
        
        public Operacoes calcular(Operacoes operacao)
        {
            switch(operacao.operador)
            {
                case '+': operacao.resultado = soma(operacao);break;
                case '-': operacao.resultado = subtracao(operacao);break;
                case '*': operacao.resultado = multiplicacao(operacao);break;
                case '/': operacao.resultado = divisao(operacao);break;
                default: operacao.resultado = 0; break;
            }
            return operacao;
        }
        public BigInteger soma(Operacoes operacao)
        {
            return operacao.valorA + operacao.valorB;
        }
        public BigInteger subtracao(Operacoes operacao)
        {
            return operacao.valorA - operacao.valorB;
        }
        public BigInteger multiplicacao(Operacoes operacao)
        {
            return operacao.valorA * operacao.valorB;
        }
        public BigInteger divisao(Operacoes operacao)
        {
            return operacao.valorA / operacao.valorB;
        }
    }
}
