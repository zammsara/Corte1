using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Corte1.Clases
{
    public class Operacion
    {
        // Metodo para calcular la edad a partir de la fecha de nacimiento
        public int CalcularEdad(DateTime fechaNacimiento)
        {
            // Obtiene la fecha actual
            DateTime fechaActual = DateTime.Now;
            // Calcula la edad restando el año de nacimiento del año actual
            int edad = fechaActual.Year - fechaNacimiento.Year;

            // Se verifica si la persona aun no ha cumplido años este año
            if (fechaActual < fechaNacimiento.AddYears(edad))
            {
                edad--; // Resta uno a la edad si aun no ha cumplido años
            }

            return edad; // Regresa la edad calculada
        }

        
        public string VerificarEdad(int edad)
        {
            if (edad >= 18)
            {
                return "Mayor de edad"; // Imprime "Mayor de edad" si la edad es igual a 18 o mayor
            }
            else
            {
                return "Menor de edad"; // Imprime "Menor de edad" si la edad es menor de 18
            }
        }
    }
}
