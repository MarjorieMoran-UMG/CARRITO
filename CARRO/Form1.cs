using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CARRO.Clase;

namespace CARRO
{
    public partial class Form1 : Form
    {
        ClsMotor Carro;

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonPrincipal_Click(object sender, EventArgs e)
        {
            Carro = new ClsMotor(2021, 130);

            buttonYaris.Visible = true;
            buttonHilux.Visible = true;
            buttonRav.Visible = true;
            labelYARIS.Visible = true;
            labelHILUX.Visible = true;
            labelRAV.Visible = true;
            labelCambio.Visible = true;
            labelEstado.Visible = true;
            labelEstadoVelocidad.Visible = true;
            labelPalanca.Visible = true;
            buttonEncender.Visible = false;
            buttonAcelerar.Visible = false;
            buttonFreno.Visible = false;
            buttonReproducir.Visible = false;
            buttonPausa.Visible = false;
            buttonParar.Visible = false;
            buttonPalanca.Visible = false;
            axWindowsMediaPlayer1.Visible = false;
            buttonPrincipal.Visible = false;

            MessageBox.Show("A continuación se presentan los autos disponibles, por favor elige uno");

        }

        private void buttonEncender_Click(object sender, EventArgs e)
        {
                labelEstado.Text = Carro.EncenderCarro();
            if (Carro == null)
            {
                MessageBox.Show("Por favor elige el carro primero");
            }
            else
            {
                axWindowsMediaPlayer1.Ctlcontrols.pause();
                axWindowsMediaPlayer1.Ctlcontrols.play();
                axWindowsMediaPlayer1.Ctlcontrols.stop();
                axWindowsMediaPlayer1.Visible = true;
            }
        }

        private void buttonAcelerar_Click(object sender, EventArgs e)
        {
            if (Carro == null)
            {
                MessageBox.Show("Por favor elige el carro primero");
            }
            else
            {
                labelEstadoVelocidad.Text = Carro.Acelerar();
                labelCambio.Text = Carro.Cambios();
            }

        }

        private void buttonYaris_Click(object sender, EventArgs e)
        {
            Carro = new ClsMotor(2021, 130, "Rojo");
            buttonEncender.Visible = true;
            buttonAcelerar.Visible = true;
            buttonFreno.Visible = true;
            buttonReproducir.Visible = true;
            buttonPausa.Visible = true;
            buttonParar.Visible = true;
            buttonPalanca.Visible = true;
            labelYARIS.Visible = true;
            labelHILUX.Visible = false;
            labelRAV.Visible = false;
            buttonHilux.Visible = false;
            buttonRav.Visible = false;
            buttonYaris.Visible = true;
            axWindowsMediaPlayer1.Visible = false;
            buttonPrincipal.Visible = false;
            MessageBox.Show($"El carro YARIS llega a {Carro.VelMaxima}KPH, es de color {Carro.Color} y es modelo {Carro.Anio}");
        }

        private void buttonHilux_Click(object sender, EventArgs e)
        {
            Carro = new ClsMotor(2021, 185, "Gris");
            buttonEncender.Visible = true;
            buttonAcelerar.Visible = true;
            buttonFreno.Visible = true;
            buttonReproducir.Visible = true;
            buttonPausa.Visible = true;
            buttonParar.Visible = true;
            buttonPalanca.Visible = true;
            buttonHilux.Visible = true;
            buttonYaris.Visible = false;
            buttonRav.Visible = false;
            labelHILUX.Visible = true;
            labelYARIS.Visible = false;
            labelRAV.Visible = false;
            axWindowsMediaPlayer1.Visible = false;
            buttonPrincipal.Visible = false;

            MessageBox.Show($"El carro HILUX llega a {Carro.VelMaxima}KPH, es de color {Carro.Color} y es modelo {Carro.Anio}");
        }

        private void buttonRav_Click(object sender, EventArgs e)
        {
            Carro = new ClsMotor(2021, 180, "Negro");
            buttonEncender.Visible = true;
            buttonAcelerar.Visible = true;
            buttonFreno.Visible = true;
            buttonReproducir.Visible = true;
            buttonPausa.Visible = true;
            buttonParar.Visible = true;
            buttonPalanca.Visible = true;
            buttonYaris.Visible = false;
            buttonHilux.Visible = false;
            buttonRav.Visible = true;
            labelRAV.Visible = true;
            labelHILUX.Visible = false;
            labelYARIS.Visible = false;
            axWindowsMediaPlayer1.Visible = false;
            buttonPrincipal.Visible = false;

            MessageBox.Show($"El carro RAV4 llega a {Carro.VelMaxima}KPH, es de color {Carro.Color} y es modelo {Carro.Anio}");
        }

        private void buttonFreno_Click(object sender, EventArgs e)
        {
            labelEstadoVelocidad.Text = Carro.Frenar();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonReproducir_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }

        private void buttonParar_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.stop();
        }

        private void buttonPausa_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.pause();
        }

        private void buttonPalanca_Click(object sender, EventArgs e)
        {
            labelPalanca.Text = Carro.PalankdeCambios();
        }
    }
}
