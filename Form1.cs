using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APPcontinuacion_sobre__el_promedio_de_calificaciones
{
    public partial class Form1 : Form
    {
        private object txt_Promedio_Completivo;
        private object txt_Nota_Completiva_Calculo;
        private object txt_Nota_Completivo_calculo;
        private object txt_Sitacion_Completivo;
        private object txt_Situacion_Completivo;
        private object txt_aSitacion_Completiva;
        private object txt_Promedio_Completiv;

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Calcular_Click(object sender, EventArgs e)
        {
            // Obtener las notas ingresadas por el usuario
            double nota1 = Convert.ToDouble(txtNota1.Text);
            double nota2 = Convert.ToDouble(txtNota2.Text);
            double nota3 = Convert.ToDouble(txtNota3.Text);
            double nota4 = Convert.ToDouble(txtNota4.Text);

            // Calcular el promedio
            double promedio = (nota1 + nota2 + nota3 + nota4) / 4;

            // Mostrar el promedio
            lblPromedio.Text = $"Promedio: {promedio:F2}";

            if (promedio >= 70)
            {
                lblMensaje.Text = "Aprobado";
                lblMensaje.ForeColor = Color.Green;
                txtNotaCompletiva.Enabled = false;
            }
            else
            {
                lblMensaje.Text = "Reprobado";
                lblMensaje.ForeColor = Color.Red;
                txtNotaCompletiva.Enabled = true;

                // Calcular nota completiva si el promedio es menor a 70
                double notaCompletiva = Convert.ToDouble(txtNotaCompletiva.Text);
                double notaCompletiva50 = notaCompletiva * 0.5;

                // Calcular la nota final sumando el 50% de la prueba completiva al promedio
                double notaFinal = promedio + notaCompletiva50;

                // Mostrar la nota final
                lblNotaFinal.Text = $"Nota Final: {notaFinal:F2}";
            }

            private void btn_Limpiar_Click(object sender, EventArgs e)
            {
                txt_Nota1.Clear();
                txt_Nota2.Clear();
                txt_Nota3.Clear();
                txt_Nota_Completiva.Clear();
                txt_Prueva_Completivao.Clear();
                txt_Promedio_Completivo.Clear();
                txt_Situacion_Completivo.Clear();
                txt_Promedio.Clear();
                txt_Situacion.Clear();
               
            }

            private void btn_Salir_Click(object sender, EventArgs e)
            {
                Close();
            }
        }   
                
    }
        
}

