

namespace Unitivo.Presentacion.Logica
{
    static class CommonFunctions
    {

        public static void ValidarStringKeyPress(TextBox textBox, KeyPressEventArgs e)
        {
            // Verifica si la tecla presionada es una letra, un espacio, una tecla para volver atrás o un punto.
            if (char.IsLetter(e.KeyChar) || e.KeyChar == ' ' || e.KeyChar == '\b' || e.KeyChar == '.')
            {
                // No permite ingresar la tecla presionada.
                e.Handled = true;
                // Muestra un mensaje de error.
                MessageBox.Show("Solo se aceptan letras.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

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
                MessageBox.Show("Solo se aceptan numeros.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        public static void ValidarKeyPress(TextBox textBox, KeyPressEventArgs e)
        {
            // Verifica que la tecla presionada sea un número, una tecla de borrado o un espacio.
            if (!char.IsLetterOrDigit(e.KeyChar) & e.KeyChar != '.' & e.KeyChar != '\b')
            {
                // No permite ingresar la tecla presionada.
                e.Handled = true;
                // Muestra un mensaje de error.
                MessageBox.Show("No se aceptan caracteres especiales", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        public static void ValidarCamposNoVacios(TextBox[] textBoxes)
        {
            // Verifica que todos los campos estén vacíos.
            foreach (TextBox textBox in textBoxes)
            {
                // Verifica que el texto del cuadro de texto no esté vacío.
                if (string.IsNullOrWhiteSpace(textBox.Text))
                {
                    // Muestra un mensaje de error.
                    MessageBox.Show("Debes completar los campos obligatorios!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }



    }
}
