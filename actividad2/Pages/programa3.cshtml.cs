using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;

namespace actividad2.Pages
{
    public class programa3Model : PageModel
    {
        // DEFINIMOS LOS ATRIBUTOS
        public List<double> resultados = new List<double>();
        public double res1 = 0;
        [BindProperty]
        public int a { get; set; } = 0;
        [BindProperty]
        public int b { get; set; } = 0;
        [BindProperty]
        public int x { get; set; } = 0;
        [BindProperty]
        public int y { get; set; } = 0;
        [BindProperty]
        public int n { get; set; } = 0;

        public void OnPost()
        {
            res1 = Math.Pow((a * x) + (b * y), n);


            for (int k = 0; k <= n; k++)
            {
                double resultado_k = BinomialCoefficient(n, k) * Math.Pow(a * x, n - k) * Math.Pow(b * y, k);
                resultados.Add(resultado_k);
            }

            ModelState.Clear();
        }
        // FUNCION PARA CALCULAR EL COEFICIENTE BINOMIAL
        private double BinomialCoefficient(int n, int k)
        {
            double result = Factorial(n) / (Factorial(k) * Factorial(n - k));
            return result;
        }

        // FUNCION PARA CALCULAR EL FACTORIAL
        private double Factorial(int num)
        {
            if (num == 0)
                return 1;
            double result = 1;
            for (int i = 1; i <= num; i++)
            {
                result *= i;
            }
            return result;
        }
    }
}
