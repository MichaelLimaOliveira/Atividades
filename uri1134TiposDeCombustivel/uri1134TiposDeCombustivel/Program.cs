﻿using System;

namespace uri1134TiposDeCombustivel
{
    class Program
    {
        static void Main(string[] args)
        {
            //Um Posto de combustíveis deseja determinar qual de seus produtos tem a preferência de seus clientes.
            //Escreva um algoritmo para ler o tipo de combustível abastecido (codificado da seguinte forma: 1.Álcool 2.Gasolina 3.Diesel 4.Fim).
            //Caso o usuário informe um código inválido (fora da faixa de 1 a 4) deve ser solicitado um novo código (até que seja válido).
            //O programa será encerrado quando o código informado for o número 4.
            //Entrada:
            //A entrada contém apenas valores inteiros e positivos.
            //Saída
            //Deve ser escrito a mensagem: "MUITO OBRIGADO" e a quantidade de clientes que abasteceram cada tipo de combustível, conforme exemplo.

            int tipoDeCombustivel = int.Parse(Console.ReadLine());
            int alcool = 0,
                gasolina = 0,
                diesel = 0,
                fim = 4;

            while (tipoDeCombustivel != fim)
            {
                switch (tipoDeCombustivel)
                {
                    case 1:
                        alcool++;
                        break;
                    case 2:
                        gasolina++;
                        break;
                    case 3:
                        diesel++;
                        break;
                }
                tipoDeCombustivel = int.Parse(Console.ReadLine());
                fim = 4;

            }
            Console.WriteLine("MUITO OBRIGADO");
            Console.WriteLine("Alcool: " + alcool);
            Console.WriteLine("Gasolina: " + gasolina);
            Console.WriteLine("Diesel: " + diesel);
        }
    }
}
