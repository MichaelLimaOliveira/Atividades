﻿using System;
using System.Globalization;

namespace uri1051
{
    class Program
    {
        static void Main(string[] args)
        {
            
            decimal salary = decimal.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            decimal valorImposto = 0,
                    valorIsento = 2000,
                    aliquotaMinima = 0.08m,
                    aliquotaMedia = 0.18m,
                    aliquotaMaxima = 0.28m,
                    rangeAliquotaMinima = 1000,
                    rangeAliquotaMedia = 1500;

            bool isIsento = salary >= 0 && salary <= 2000;
            if (isIsento)
            {
                Console.WriteLine("Isento");
                return;
            }

            bool isAliquotaMinima = salary > 2000 && salary <= 3000;
            bool isAliquotaMedia = salary > 3000 && salary <= 4500;
            bool isAliquotaMaxima = salary > 4500;
            
            if (isAliquotaMinima)
            {
                valorImposto = (salary - valorIsento) * aliquotaMinima;
            }
            else if (isAliquotaMedia)
            {

                valorImposto = (salary - valorIsento - rangeAliquotaMinima);
                valorImposto = (rangeAliquotaMinima * aliquotaMinima) + (valorImposto * aliquotaMedia);
            }
            else if (isAliquotaMaxima)
            {
                valorImposto = (salary - valorIsento - rangeAliquotaMinima - rangeAliquotaMedia);
                valorImposto = (rangeAliquotaMinima * aliquotaMinima) + (rangeAliquotaMedia * aliquotaMedia) + (valorImposto * aliquotaMaxima);
            }

            Console.WriteLine("R$ " + valorImposto.ToString("F2"), CultureInfo.InvariantCulture);
        }
    }
}
