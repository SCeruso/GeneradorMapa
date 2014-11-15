using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeneradorMapa
{
    public partial class Form1 : Form
    {
      private string entrada;
      private Cuadricula tab_;

        public Form1()
        {
            entrada = null;
           // _C = new System.Windows.Forms.Label(); ;
            tab_ = new Cuadricula(2, 2);
            InitializeComponent();
        
        }

        private void crearToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
  
           // MessageBox.Show("Voy a crearme");
            Form2 f = new Form2(this);
            f.Show();
        }
        public void verDimensiones()
        {
           
            MessageBox.Show(entrada);
           // _C = new System.Windows.Forms.Label();
            /*this._C.AutoSize = true;
            this._C.Location = new System.Drawing.Point(35, 31);
            this._C.Size = new System.Drawing.Size(220, 13);
            this._C.TabIndex = 1;
            this._C.Text = "SOY C";
            this._C.Image = global::GeneradorMapa.Properties.Resources.rojo;*/
            this.label1.Text = "Cambiado";
           // _C.Refresh();
        }
        public string getent() { return entrada; }
        public void setent(string s) {  entrada = s; }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
          
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        //    this.pictureBox1.Image = global::GeneradorMapa.Properties.Resources.rojo;
        }
    }
}
