﻿namespace Unitivo.Presentacion.Logica
{
    static class CommonFunctions
    {

        public static void ValidarStringKeyPress(TextBox textBox, KeyPressEventArgs e)
        {
            // Verifica si la tecla presionada no es una letra, un espacio o un punto.
            if (!(char.IsLetter(e.KeyChar) || e.KeyChar == ' ' || e.KeyChar == '.' || e.KeyChar == (char)Keys.Back))
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

        public static bool ValidarCamposNoVacios(Control control)
        {
            // Verifica si el control es TextBox.
            if (control is TextBox textBox)
            {
                // Muestra un mensaje de error que incluye el nombre del campo.
                MessageBox.Show($"Debes completar todos campos obligatorios(*)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            // Verifica si el control es ComboBox.
            else if (control is ComboBox comboBox && comboBox.SelectedItem == null)
            {
                // Muestra un mensaje de error que incluye el nombre del campo.
                MessageBox.Show($"No pueden quedar campos vacios!.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                return true;
            }
        }






    }
}
