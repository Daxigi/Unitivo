﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unitivo.Presentacion.Logica;

namespace Unitivo.Presentacion.Administrador
{
    public partial class AñadirTalle : Form
    {
        public AñadirTalle()
        {
            InitializeComponent();
        }

        private void String_KeyPress(object sender, KeyPressEventArgs e)
        {
            CommonFunctions.ValidarStringKeyPress((TextBox)sender, e);
        }

        private void BRegistrarTalle_Click(object sender, EventArgs e)
        {
            // Verificar si el campo Nombre de Perfil está vacío.
            if (string.IsNullOrWhiteSpace(TBNombreTalle.Text))
            {
                // Mostrar un mensaje de error si el campo está vacío.
                MessageBox.Show("El campo Nombre de Talle es obligatorio. Por favor, complételo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // El campo Nombre de Perfil está lleno, puedes proceder a agregar el perfil al DataGridView.

                // Valores estáticos para el ID y el estado.
                string id = "1";
                string descripcion = TBNombreTalle.Text;
                string estado = "1";

                // Crear una nueva fila para el DataGridView.
                DataGridViewRow row = new DataGridViewRow();
                row.Cells.Add(new DataGridViewTextBoxCell { Value = id });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = descripcion });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = estado });

                // Agregar la fila al DataGridView.
                dgvRegistroTalles.Rows.Add(row);

                // Limpiar el campo Nombre de Perfil después de agregar el perfil.
                TBNombreTalle.Clear();

                // Mostrar un mensaje de éxito.
                MessageBox.Show("Talle registrada con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

    }
}
