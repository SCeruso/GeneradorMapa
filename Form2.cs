﻿using System;
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
    public partial class Form2 : Form
    {

        Form1 _parent;
        public Form2(Form1 p)
        {
            _parent = p;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           _parent.setent(textBox1.Text);
            MessageBox.Show(_parent.getent());
            _parent.verDimensiones();
            
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            

        }
    }
}
