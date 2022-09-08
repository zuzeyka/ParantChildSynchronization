using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParantChildSynchronization
{
    public partial class Parent : Form
    {
        Child child;
        public Parent()
        {
            InitializeComponent();
            child = new Child(this);
            child.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (child != null)
                child.textBox1.Text = this.textBox1.Text;
        }

    }
}
