﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FabricaCEAPE.Clases;
using FabricaCEAPE.Datos;

namespace FabricaCEAPE.Datos
{
    public partial class FrmEditarDepartamento : Form
    {
        public FrmEditarDepartamento(int id)
        {
            InitializeComponent();

            if (id == 0)
            {
                departamentoBindingSource.Add(new Departamento());
            }
            else
            {
                departamentoBindingSource.Add(DatosDepartamento.getDepartamento(id));

                Departamento d = (Departamento)departamentoBindingSource.Current;

                if (d.Nombre != "")
                {
                    this.Text = "Editar " + d.Nombre;
                }  
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!validaciones())
                    return;

                Departamento d = (Departamento)departamentoBindingSource.Current;
                d.Activo = true;
                if (d.Id == 0)
                {
                    DatosDepartamento.Crear(d);
                }
                else
                {
                    DatosDepartamento.Modificar(d);
                }
                Close();
            }            
            catch
            {
                MessageBox.Show("Complete todos los campos");
            }
        }

        Color colorOk = (Color)((new ColorConverter()).ConvertFromString("#bbda68"));

        private bool validaciones()
        {
            bool resultados = true;
            string error = null;

            if (string.IsNullOrEmpty(nombreTextBox.Text))
            {
                error = "Ingrese el nombre del departamento";

                errorProvider1.SetError(nombreTextBox, error);
                resultados = false;
            }

            return resultados;
        }

        private void nombreTextBox_Validating(object sender, CancelEventArgs e)
        {
            string error = null;
            if (!Validacion.esCadena(nombreTextBox))
            {
                error = "Ingrese el nombre del departamento";
                e.Cancel = true;
                errorProvider1.SetError((Control)sender, error);
            }
            else
            {
                nombreTextBox.BackColor = colorOk;
                errorProvider1.SetError((Control)sender, String.Empty);
            } 
        }

        private void nombreTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
            else if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
    }
}
