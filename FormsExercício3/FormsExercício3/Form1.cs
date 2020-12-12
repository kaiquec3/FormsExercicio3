using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsExercício3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lblAreaValor.Text = "0";
        }

        private void clickou_calcular_area(object sender, EventArgs e)
        {
            Quadrado q1 = new Quadrado(double.Parse(txtDiagonal.Text));
            q1.CalcularArea();
            lblAreaValor.Text = q1.GetArea().ToString();
        }
    }
}
