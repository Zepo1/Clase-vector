using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplicacion_Vectores
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Vector V1 = new Vector();
        Vector V2 = new Vector();
        Vector V3 = new Vector();
       
        private void button1_Click(object sender, EventArgs e)
        {
            V1.Dimensionar(int.Parse(textBox1.Text));
        }

        private void cargarParesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            V1.CargarPares();
        }

        private void dESCARGARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox2.Text = V1.ToString();
        }

        private void cargarImparesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            V1.CargarImpares();
        }
        private void cARGARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox3.Text);  
            int b = int.Parse(textBox4.Text);
            V1.CargarRandom(a, b);
        }
        private void ordenarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            V1.Ordenar();
        }

        private void insertarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int pos = int.Parse(textBox3.Text);
            int valor= int.Parse(textBox4.Text);
            V1.Insertar(pos, valor);
        }

        private void frecToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            int digito = int.Parse(textBox3.Text);
            textBox4.Text = string.Concat(V1.Frec(digito));
        }

        private void dESCARGARToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            textBox7.Text = V2.ToString();
        }

        private void dESCARGARToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            textBox8.Text = V3.ToString();
        }
        private void cARGARToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox3.Text);   
            int b = int.Parse(textBox4.Text);
            V2.CargarRandom(a, b);
        }

        private void cARGARToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox3.Text);
            int b = int.Parse(textBox4.Text);
            V3.CargarRandom(a, b);
        }

        private void dIMENSIONARToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            V2.Dimensionar(int.Parse(textBox1.Text));
        }

        private void dIMENSIONARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            V3.Dimensionar(int.Parse(textBox1.Text));
        }
        private void verifOrdToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            int a = int.Parse(textBox5.Text);
            int b = int.Parse(textBox6.Text);
            textBox6.Text = V1.VerifOrd(a, b).ToString();
        }

        private void fIbonacciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int ne = int.Parse(textBox5.Text);
            V1.CargarFibonacciINV(ne);
        }

        private void dESCARGARToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            textBox2.Text = V1.ToString();
        }

        private void fibonacciDIVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox6.Text = V1.FibonaDiv().ToString();
        }

        private void cargarfibonacciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int dim = int.Parse(textBox5.Text);
            V1.fibonacciNormal(dim);
        }

        private void buscarElemMayorMultToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox7.Text= V1.BusElemMay2().ToString();
           
        }

        private void multiplosNOMultiplosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int multiplo = int.Parse(textBox5.Text);
            V1.Multiplos(V2, V3, multiplo);
        }

        private void invDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            V1.invertirElem();
        }

        private void bucarMediaMult2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
           textBox7.Text = V1.BusMediaDe2().ToString();
        }

        private void verificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool bandera = false;
            if (V1.VeriIgual() == bandera)            
                textBox7.Text = "FALSE";           
            else           
                textBox7.Text = "TRUE";
            
        }
    }
}
