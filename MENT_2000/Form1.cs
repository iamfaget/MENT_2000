﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MENT_2000
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            this.Text = e.X + " " + e.Y; 
        }
    }

    public class Cross
    {
        int x,y;

        public Cross(int X, int Y)
        {
            this.x = X;
            this.y = Y;
        }
    }
    
}
