using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unitivo
{
    static class CommonFunctions
    {

        public static bool ValidarStringKeyPress(TextBox textBox, KeyPressEventArgs e)
        {
            // Verifica que la tecla presionada sea una letra o un número.
            if (char.IsLetterOrDigit(e.KeyChar) | e.KeyChar == '.' | e.KeyChar == '\b')
            {
                // Devuelve True.
                return true;
            }
            else
            {
                // Devuelve False.
                return false;
            }
        }



        public static void ValidarNumberKeyPress(TextBox textBox, KeyPressEventArgs e)
        {
            // Verifica que la tecla presionada sea un número, una tecla de borrado o un espacio.
            if (!char.IsDigit(e.KeyChar) & e.KeyChar != '.' & e.KeyChar != '\b')
            {

                // No permite ingresar la tecla presionada.
                e.Handled = true;

                // Muestra un mensaje de error.
                Interaction.MsgBox("Solo se aceptan números, teclas de borrado y retroceso", Constants.vbCritical, "Error");
            }
        }

        public static void ValidarCamposNoVacios(TextBox[] textBoxes)
        {

            // Verifica que todos los campos estén vacíos.
            foreach (TextBox textBox in textBoxes)
            {

                // Verifica que el texto del cuadro de texto no esté vacío.
                if (textBox.Text.Trim().Length == 0)
                {

                    // Muestra un mensaje de error.
                    Interaction.MsgBox("El campo no puede estar vacío.", Constants.vbCritical, "Error de validación");
                }

            }

        }



    }
}
