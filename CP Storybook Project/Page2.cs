using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CP_Storybook_Project
{
    public partial class Page2 : Form
    {
        public Page2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Page3 frm = new Page3();
            frm.Show();
            this.Hide();
        }
    }
}
