using System;
using System.Windows.Forms;

namespace Game
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }


        Instruction c = new Instruction();
        Gameplay a = new Gameplay();

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            a.ShowDialog();
            this.Show();
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            c.ShowDialog();
            this.Show();
            Close();
        }
    }
}