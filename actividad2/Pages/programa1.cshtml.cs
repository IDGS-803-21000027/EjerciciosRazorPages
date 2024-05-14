using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace actividad2.Pages
{
    public class programa1Model : PageModel
    {
        // DEFINIMOS LOS ATRIBUTOS
        public double IMC = 0;
        [BindProperty]
        public string peso { get; set; } = "";
        [BindProperty]
        public string altura { get; set; } = "";
        public void OnPost()
        {
            double pesoo = Convert.ToDouble(peso);
            double alturaa = Convert.ToDouble(altura);

            IMC = pesoo / (alturaa * alturaa);

            ModelState.Clear();
        }
    }
}
