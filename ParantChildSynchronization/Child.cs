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
    public partial class Child : Form
    {
        Parent parent = null;
        public Child(Parent parent)
        {
            if (parent == null)
            {
                this.parent = parent;
            }
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (parent != null)
                parent.textBox1.Text = this.textBox1.Text;
        }
    }
}
