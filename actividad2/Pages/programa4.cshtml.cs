using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Linq;

namespace actividad2.Pages
{
    public class programa4Model : PageModel
    {
        public int[] numeros { get; set; }
        public int suma { get; set; }
        public double promedio { get; set; }
        public int moda { get; set; }
        public int mediana { get; set; }

        public void OnGet()
        {
            // Generar arreglo con 20 números aleatorios entre 0 y 100
            Random rnd = new Random();
            numeros = Enumerable.Range(1, 20).Select(_ => rnd.Next(0, 101)).ToArray();

            // Calcular la suma de los números
            suma = numeros.Sum();

            // Calcular el promedio
            promedio = numeros.Average();

            // Calcular la moda
            moda = numeros.GroupBy(x => x)
                          .OrderByDescending(g => g.Count())
                          .First().Key;

            // Calcular la mediana
            Array.Sort(numeros);
            if (numeros.Length % 2 == 0)
            {
                mediana = (numeros[numeros.Length / 2 - 1] + numeros[numeros.Length / 2]) / 2;
            }
            else
            {
                mediana = numeros[numeros.Length / 2];
            }
        }
    }
}
