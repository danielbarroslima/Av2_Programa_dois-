﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pomodoro.CSharp
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void btnInicioTempo_Click(object sender, EventArgs e)
        {
           primeira pri new = primeira();
            pri.ShowDialog();
        }
    }
}
