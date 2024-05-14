using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace actividad2.Pages
{
    public class programa2Model : PageModel
    {
        // DEFINIMOS LOS ATRIBUTOS
        public String res = "";
        [BindProperty]
        public string mensaje { get; set; } = "";
        [BindProperty]
        public int n { get; set; } = 0;
        public void OnPost()
        {

            res = CifrarMensaje(mensaje, n);

            ModelState.Clear();
        }

        // FUNCION PARA CIFRAR EL MENSAJE
        private string CifrarMensaje(string mensaje, int n)
        {
            string resultado = "";
            foreach (char letra in mensaje)
            {
                if (char.IsLetter(letra))
                {
                    char letraCifrada = (char)(letra + n);
                    if ((char.IsLower(letra) && letraCifrada > 'z') || (char.IsUpper(letra) && letraCifrada > 'Z'))
                    {
                        letraCifrada = (char)(letraCifrada - 26);
                    }
                    resultado += letraCifrada;
                }
                else
                {
                    resultado += letra; // Mantener caracteres que no son letras
                }
            }
            return resultado;
        }
    }
}

