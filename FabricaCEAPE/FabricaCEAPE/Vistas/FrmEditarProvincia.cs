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

namespace FabricaCEAPE.Vistas
{
    public partial class FrmEditarProvincia : Form
    {
        public FrmEditarProvincia(int id)
        {
            InitializeComponent();
            paisBindingSource.DataSource = DatosPais.getPaises();

            if (id == 0)
            {
                provinciaBindingSource.Add(new Provincia());
            }
            else
            {
                provinciaBindingSource.Add(DatosProvincia.getProvincia(id));

                cbPais.SelectedItem = ((Provincia)provinciaBindingSource.Current).Pais;
                cbPais.SelectedValue = ((Provincia)provinciaBindingSource.Current).Pais.Id;

                Provincia p = (Provincia)provinciaBindingSource.Current;

                if (p.Nombre != "")
                {
                    this.Text = "Editar " + p.Nombre;
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

                Provincia p = (Provincia)provinciaBindingSource.Current;
                p.Pais = (Pais)cbPais.SelectedItem;
                p.Activo = true;
                if (p.Id == 0)
                {
                    DatosProvincia.Crear(p);
                }
                else
                {
                    DatosProvincia.Modificar(p);
                }
                Close();
            }
            catch
            {
                MessageBox.Show("Complete todos los campos");
            }
        }

        Color colorOk = (Color)((new ColorConverter()).ConvertFromString("#bbda68"));

        private void nombreTextBox_Validating(object sender, CancelEventArgs e)
        {
            string error = null;
            if (!Validacion.esCadenaNumeroPunto(nombreTextBox) || nombreTextBox.Text.Trim() == String.Empty)
            {
                error = "Ingrese el nombre del la provincia";
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


        private bool validaciones()
        {
            bool resultados = true;
            string error = null;

            if (string.IsNullOrEmpty(nombreTextBox.Text))
            {
                error = "Ingrese el nombre de la provincia";

                errorProvider1.SetError(nombreTextBox, error);
                resultados = false;
            }

            return resultados;
        }
    }
}
