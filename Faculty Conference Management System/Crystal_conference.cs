﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.Shared;

namespace Faculty_Conference_Management_System
{
    public partial class Crystal_conference : Form
    {
        conference c;
        public Crystal_conference()
        {
            InitializeComponent();
        }

        private void Crystal_conference_Load(object sender, EventArgs e)
        {

            c = new conference();
            foreach (ParameterDiscreteValue V in c.ParameterFields[0].DefaultValues)
                comboBox1.Items.Add(V);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            c.SetParameterValue(0, comboBox1.Text);
            crystalReportViewer1.ReportSource = c;
        }
    }
}
