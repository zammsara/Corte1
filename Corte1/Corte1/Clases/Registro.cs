using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Corte1.Clases
{
    public  class Registro
    {
        // Arreglo para almacenar un maximo de 30 nombres
        private string[] personas;
        // Contador para llevar la cuenta de las personas agregadas
        private int contador;

        // Constructor de la clase
        public Registro()
        {
            // Inicializa el arreglo y el contador
            personas = new string[30];
            contador = 0;
        }

        // Metodo para agregar una persona al arreglo
        public bool AgregarPersona(string nombre)
        {
            // Verificar si hay espacio en el arreglo
            if (contador < 30)
            {
                // Agregar a la persona y aumentar el contador
                personas[contador] = nombre;
                contador++;
                return true; // Regresa true si se agrego exitosamente
            }
            else
            {
                // Muestra un mensaje si no se puede agregar a mas personas
                MessageBox.Show("No se pueden agregar mas de 30 personas.");
                return false; // Regresa false si no se pudo agregar
            }
        }

        // Metodo para mostrar todas las personas registradas
        public string MostrarPersonas()
        {
            // Verificar si no hay personas registradas
            if (contador == 0)
                return "No hay personas registradas.";

            // Se crea una lista de las personas registradas
            string lista = "Personas registradas:\n";
            for (int i = 0; i < contador; i++)
            {
                lista += $"{i + 1}. {personas[i]}\n"; // Formatea la lista
            }
            return lista; // Regresa la lista de personas
        }
    }
}
