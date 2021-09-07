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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttoncontraseña_Click(object sender, EventArgs e)
        {

            if (boxContraseña.Text == "DubanSmith")
            {
                MenuPrincipal mimenu = new MenuPrincipal();
                mimenu.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("*****\tContraseña Incorrecta, Intentelo Nuevamente\t*****");
                boxContraseña.Clear();
            }
        }
    }
}
