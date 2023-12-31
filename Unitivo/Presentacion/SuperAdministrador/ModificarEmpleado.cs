﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unitivo.Modelos;
using Unitivo.Presentacion.Logica;
using Unitivo.Repositorios.Implementaciones;

namespace Unitivo.Presentacion.SuperAdministrador
{
    public partial class ModificarEmpleado : Form
    {
        public int fila;
        EmpleadoRepositorio empleadoRepositorio = new EmpleadoRepositorio();

        //Valores del empleado
        private string? nombreOriginal;
        private string? apellidoOriginal;
        private int? dniOriginal;
        private string? telefonoOriginal;
        private string? direccionOriginal;
        private string? correoOriginal;


        public ModificarEmpleado(int id)
        {
            InitializeComponent();
            MostrarEmpleado(empleadoRepositorio.BuscarEmpleadoPorId(id));
        }

        private void String_KeyPress(object sender, KeyPressEventArgs e)
        {
            CommonFunctions.ValidarStringKeyPress((TextBox)sender, e);
        }

        private void Num_KeyPress(object sender, KeyPressEventArgs e)
        {
            CommonFunctions.ValidarNumberKeyPress((TextBox)sender, e);
        }

        private void NumStr_KeyPress(object sender, KeyPressEventArgs e)
        {
            CommonFunctions.ValidarKeyPress((TextBox)sender, e);
        }

        private void Email_KeyPress(object sender, KeyPressEventArgs e)
        {
            CommonFunctions.ValidarEmailKeyPress((TextBox)sender, e);
        }

        private void BCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MostrarEmpleado(Empleado empleado)
        {
            // Cargar los datos del empleado en los TextBox
            TBNombreEmpleado.Text = empleado.Nombre;
            nombreOriginal = empleado.Nombre;

            TBApellidoEmpleado.Text = empleado.Apellido;
            apellidoOriginal = empleado.Apellido;

            TBDniEmpleado.Text = empleado.Dni.ToString();
            dniOriginal = empleado.Dni;

            TBTelEmpleado.Text = empleado.Telefono;
            telefonoOriginal = empleado.Telefono;

            TBDireccionEmpleado.Text = empleado.Direccion;
            direccionOriginal = empleado.Direccion!;

            TBCorreoEmpleado.Text = empleado.Correo;
            correoOriginal = empleado.Correo;

        }

        private void BModEmpleado_Click(object sender, EventArgs e)
        {
            // Obtén los nuevos valores de los TextBox
            string nuevoNombre = TBNombreEmpleado.Text;
            string nuevoApellido = TBApellidoEmpleado.Text;
            int nuevoDni = int.Parse(TBDniEmpleado.Text);
            string nuevoTelefono = TBTelEmpleado.Text;
            string nuevaDireccion = TBDireccionEmpleado.Text;
            string nuevoCorreo = TBCorreoEmpleado.Text;


            // Compara los nuevos valores con los originales
            if (nuevoNombre != nombreOriginal || nuevoApellido != apellidoOriginal || nuevoDni != dniOriginal ||
                nuevoTelefono != telefonoOriginal || nuevaDireccion != direccionOriginal || nuevoCorreo != correoOriginal)
            {
                Empleado empleado = new Empleado();
                empleado.Nombre = nuevoNombre;
                empleado.Apellido = nuevoApellido;
                empleado.Dni = nuevoDni;
                empleado.Telefono = nuevoTelefono;
                empleado.Direccion = nuevaDireccion;
                empleado.Correo = nuevoCorreo;
                try
                {
                    if (empleadoRepositorio.ModificarEmpleado(empleado))
                    {
                        MessageBox.Show("Cliente modificado con éxito.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo modificar el cliente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch
                {
                }

            }
            else
            {
                MessageBox.Show("No se han realizado cambios.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


    }
}
