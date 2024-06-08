using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms_Sueldo_Neto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            // Limpiar los cuadros de texto
            txt_pago_por_hora.Clear();
            txt_horas_trabajadas.Clear();
            txt_sueldo_bruto.Clear();
            txt_descuento_afp.Clear();
            txt_descuento_sfs.Clear();
            txt_total_descuento.Clear();
            txt_sueldo_neto.Clear();
        }

        private void btn_calcular_Click(object sender, EventArgs e)
        {
            // Obtener el pago por horas trabajadas y las horas trabajadas
            double pagoPorHora = Convert.ToDouble(txt_pago_por_hora.Text);
            double horasTrabajadas = Convert.ToDouble(txt_horas_trabajadas.Text);

            // Calcular el sueldo bruto
            double sueldoBruto = pagoPorHora * horasTrabajadas;

            // Calcular los descuentos de AFP y SFS
            double descuentoAFP = sueldoBruto * 0.0287; // 2.87%
            double descuentoSFS = sueldoBruto * 0.0304; // 3.04%

            // Calcular el total de descuentos
            double totalDescuentos = descuentoAFP + descuentoSFS;

            // Calcular el sueldo neto
            double sueldoNeto = sueldoBruto - totalDescuentos;

            // Mostrar los resultados en los cuadros de texto correspondientes
            txt_sueldo_bruto.Text = sueldoBruto.ToString("0.00");
            txt_descuento_afp.Text = descuentoAFP.ToString("0.00");
            txt_descuento_sfs.Text = descuentoSFS.ToString("0.00");
            txt_total_descuento.Text = totalDescuentos.ToString("0.00");
            txt_sueldo_neto.Text = sueldoNeto.ToString("0.00");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
