using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Astronomy
{
    public partial class InformationForm : Form
    {
        
        public InformationForm()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void return_btn_Click(object sender, EventArgs e)
        {
            MainForm1 mainForm1 = new MainForm1();
            this.Hide();
            mainForm1.Show();
        }

        private void InformationForm_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Вы действительно хотите выйти?", "", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
                Application.Exit();
        }
    }
}
