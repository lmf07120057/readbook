using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace Read.Book
{
    partial class Abb_read : Form
    {
        public Abb_read()
        {
            InitializeComponent(); 
        }
          
        private void okButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
