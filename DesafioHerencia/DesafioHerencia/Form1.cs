using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesafioHerencia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPrecioFinal_Click(object sender, EventArgs e)
        {
            if(btnPiso.Checked == true)
            {
                float precioPiso = Convert.ToInt32(txtPrecio.Text);
                int numeroPiso = Convert.ToInt32(txtPisoNro.Text);
                int antiguedadAños = Convert.ToInt32(txtAntiguedad.Text);

                Piso pisoNuevo = new Piso(numeroPiso, precioPiso, antiguedadAños);

                pisoNuevo.CalcularPrecioSegunPiso();
                float precioFinalPiso = pisoNuevo.CalcularPrecioFinal();

                lblPrecioFinal.Text = "El precio final del PISO es de: " + precioFinalPiso;
            }

            if(btnLocal.Checked == true)
            {
                float precioLocal = Convert.ToInt32(txtPrecio.Text);
                int superficie = Convert.ToInt32(txtSuperficie.Text);
                int cantidadVentanales = Convert.ToInt32(txtNumeroVentanas.Text);
                int antiguedadAños = Convert.ToInt32(txtAntiguedad.Text);

                Local localNuevo = new Local(cantidadVentanales, precioLocal, superficie, antiguedadAños);

                localNuevo.CalcularPrecioSegunSuperficie();
                localNuevo.CalcularPrecioSegunVentanales();
                float precioFinalLocal  = localNuevo.CalcularPrecioFinal();

                lblPrecioFinal.Text = "El precio final del LOCAL es de: " + precioFinalLocal;
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtAntiguedad.Text = " ";
            txtDireccion.Text = " ";
            txtNumeroVentanas.Text = " ";
            txtPisoNro.Text = " ";
            txtPrecio.Text = " ";
            txtSuperficie.Text = " ";

            btnLocal.Checked = false;
            btnPiso.Checked = false;

            lblPrecioFinal.Text = " ";
            lblPisoNumero.Text = "Piso Nro";
            lblAntiguedad.Text = "Antiguedad";
            lblPrecioBase.Text = "Precio base";

            lblSuperficie.Text = "Superficie";
            lblNumeroVentanas.Text = "Nro de ventanas";
        }

        private void btnPiso_CheckedChanged(object sender, EventArgs e)
        {
            lblPisoNumero.Text = "Piso Nro *";
            lblAntiguedad.Text = "Antiguedad *";
            lblPrecioBase.Text = "Precio base *";

            lblSuperficie.Text = "Superficie";
            lblNumeroVentanas.Text = "Nro de ventanas";
        }

        private void btnLocal_CheckedChanged(object sender, EventArgs e)
        {
            lblPisoNumero.Text = "Piso Nro";
            lblAntiguedad.Text = "Antiguedad *";
            lblPrecioBase.Text = "Precio base *";

            lblSuperficie.Text = "Superficie *";
            lblNumeroVentanas.Text = "Nro de ventanas *";
        }
    }
}

