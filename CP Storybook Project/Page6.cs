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
    public partial class Page6 : Form
    {
        public Page6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Page7 frm = new Page7();
            frm.Show();
            this.Hide();
        }
    }
}
