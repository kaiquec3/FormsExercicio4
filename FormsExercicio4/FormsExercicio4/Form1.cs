using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsExercicio4
{
    public partial class frmCalculadoraDeAreaDeTriangulo : Form
    {
        public frmCalculadoraDeAreaDeTriangulo()
        {
            InitializeComponent();
            lblAreaValor.Text = "0";
        }

        private void clickou_calcular(object sender, EventArgs e)
        {
            Triangulo t1 = new Triangulo(double.Parse(txtBase.Text), double.Parse(txtAltura.Text));
            t1.CalcularArea();
            lblAreaValor.Text = t1.GetArea().ToString();
        }
    }
}
