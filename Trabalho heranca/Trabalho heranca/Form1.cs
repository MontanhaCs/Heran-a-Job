﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabalho_heranca
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btncadprofessor_Click(object sender, EventArgs e)
        {
            this.Hide();
            Professor frm = new Professor();
             frm.Show();
        }

        private void btncadaluno_Click(object sender, EventArgs e)
        {
            this.Hide();
            Aluno secundo = new Aluno();
            secundo.Show();
        }

        private void btnsair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }

    }

