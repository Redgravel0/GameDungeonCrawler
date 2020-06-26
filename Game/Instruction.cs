using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game
{
    public partial class Instruction : Form
    {
        public Instruction()
        {
            InitializeComponent();
        }

        

        private void button3_Click(object sender, EventArgs e)
        {
            MainMenu a = new MainMenu();
            this.Hide();
            a.ShowDialog();
            this.Show();
            Close();
        }
    }
}
