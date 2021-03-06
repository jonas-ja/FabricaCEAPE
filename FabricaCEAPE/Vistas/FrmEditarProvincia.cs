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
        int id;
        bool errorr = true;
        public FrmEditarProvincia(int id)
        {
            InitializeComponent();
            paisBindingSource.DataSource = DatosPais.getPaises();
            this.id = id;
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
            if (!Validacion.esCadena(nombreTextBox) || nombreTextBox.Text.Trim() == String.Empty)
            {
                nombreTextBox.BackColor = Color.White;
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

            if (cbPais.SelectedIndex < 0)
            {
                error = "Seleccione la el Pais";

                errorProvider1.SetError(cbPais, error);
                resultados = false;
            }

            checarExitencia();
            if (!errorr)
            {
                resultados = false;
            }

            return resultados;
        }

        private void cbPais_DropDownClosed(object sender, EventArgs e)
        {
            checarExitencia();
        }

        private void checarExitencia()
        {
            if (cbPais.SelectedIndex >= 0)
            {
                if (DatosProvincia.existe(nombreTextBox.Text, (int)cbPais.SelectedValue))
                {
                    nombreTextBox.BackColor = Color.White;
                    string error = "La localidad ya existe en la provincia seleccionada";
                    errorProvider1.SetError(nombreTextBox, error);
                    errorr = false;
                }
                else
                {
                    nombreTextBox.BackColor = colorOk;
                    errorProvider1.SetError(nombreTextBox, String.Empty);
                    errorr = true;
                }
                if (DatosProvincia.existeProvinciaN(id, nombreTextBox.Text))
                {
                    nombreTextBox.BackColor = colorOk;
                    errorProvider1.SetError(nombreTextBox, String.Empty);
                    errorr = true;
                }
            }
        }
    }
}
