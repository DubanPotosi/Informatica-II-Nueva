using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace forma_grafica_desprendible
{
    public partial class MenuPrincipal : Form
    {
        Nomina miNomina = new Nomina();
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                miNomina.Nombre = txtNombre.Text;
                miNomina.Identificacion = Convert.ToInt32(txtID.Text);
                miNomina.Cargo = boxCargo.Items[boxCargo.SelectedIndex].ToString();
                miNomina.AsignacionDias = decimal.Parse(txtSalarioDia.Text);
                miNomina.Diastrabajados = Convert.ToInt32(txtDiasLaborados.Text);
                miNomina.fecha = Fecha.Text;
                miNomina.hora = Hora.Text;

                if (radMasculino.Checked == true)
                    miNomina.Genero = radMasculino.Text;
                if (radFemenino.Checked == true)
                    miNomina.Genero = radFemenino.Text;
                if (radNoBinario.Checked == true)
                    miNomina.Genero = radNoBinario.Text;
                MessageBox.Show("Se guardo el registro");
            }
            catch
            {
                MessageBox.Show("Faltan datos por ingresar");
            }
        }

        private void boxCargo_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtSalarioDia.Text = boxCargo.Items[boxCargo.SelectedIndex].ToString() == "Electricista" ? "20000" :
                              boxCargo.Items[boxCargo.SelectedIndex].ToString() == "Programador" ? "80000" :
                              boxCargo.Items[boxCargo.SelectedIndex].ToString() == "Abogado" ? "12000" :
                              boxCargo.Items[boxCargo.SelectedIndex].ToString() == "Arquitecta" ? "40000" :
                              boxCargo.Items[boxCargo.SelectedIndex].ToString() == "Aseader" ? "40000" : "0" ;


             
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DesprendibleTrabajador miDesprendible = new DesprendibleTrabajador();
            miDesprendible.Show();
            this.Hide();

            miDesprendible.lblNombre.Text = miNomina.Nombre;
            miDesprendible.lblID.Text = miNomina.Identificacion.ToString();
            miDesprendible.lblGenero.Text = miNomina.Genero;
            miDesprendible.lblCargo.Text = miNomina.Cargo;
            miDesprendible.lblDias.Text = miNomina.Diastrabajados.ToString("N");
            miDesprendible.lblSalario.Text = miNomina.AsignacionDias.ToString("C");
            miDesprendible.lblValor.Text = miNomina.CalcularNomina(miNomina.Diastrabajados, miNomina.AsignacionDias).ToString();
            miDesprendible.lblFecha.Text = miNomina.fecha;
            miDesprendible.lblHora.Text = miNomina.hora; 
        

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Fecha.Text = DateTime.Now.ToShortDateString();
            Hora.Text = DateTime.Now.ToShortTimeString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
