using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjTermometro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConverter_Click(object sender, EventArgs e)
        {
            
            //========================= CONVERTE CELSIUS PRA KELVIN E KELVIN PRA CELSIUS=========================|
            if (rbFromC.Checked && rbToK.Checked)
            {
                double c = Double.Parse(txtTemperatura.Text);
                double k = c + 273.15;

                lbResposta.Text = k + "Kelvin";

            } 
            if (rbFromK.Checked && rbToC.Checked)
            {
                double b = Double.Parse(txtTemperatura.Text);
                double c = b - 273.15;
                lbResposta.Text = c + " Celsius";

            }
            //========================= CONVERTE FAHRENHEIT PRA CELSIUS E CELSIUS PRA FAHRENHEIT=================|
            if (rbFromF.Checked && rbToC.Checked)
            {
                double f = Double.Parse(txtTemperatura.Text);
                double c = (f - 32) / 1.8; 
                lbResposta.Text = c + " Celsius ";

            }
            if (rbFromC.Checked && rbToF.Checked)
            {
                double c = Double.Parse(txtTemperatura.Text);
                double f = c * 1.8 + 32;
                lbResposta.Text = f+ " Fahrenheit ";

            }
            //========================= CONVERTE FAHRENHEIT PRA KELVIN E KELVIN PRA FAHRENHEIT=================|
            if (rbFromF.Checked && rbToK.Checked)
            {
                double f = Double.Parse(txtTemperatura.Text);
                double k = (f - 32) / 1.8 + 273.15;
                lbResposta.Text =  k  + " Kelvin ";
            }
            if (rbFromK.Checked && rbToF.Checked)
            {
                double k = Double.Parse(txtTemperatura.Text);
                double f = k * 1.8 - 459.67;
                lbResposta.Text = f + " Fahrenheit ";
            }
           //==================================================================================
            else
            {
                lbResposta.Text = "INVÁLIDO";

            }


        }

    }
}