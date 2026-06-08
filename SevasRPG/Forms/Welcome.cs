using SevasRPG.Entities.Characters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SevasRPG.Forms
{
    public partial class Welcome : Form
    {
        private Player player;
        public Welcome()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }
        public Welcome(Form mainForm, Player player)
        {
            InitializeComponent();  
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim().Length == 0)
            {
                MessageBox.Show("Некоректне значення імені!", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (textBox1.Text.Trim().Length > 15)
            {
                MessageBox.Show("Ім'я задовге!", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.player = new Player(textBox1.Text.Trim());
                Game pcForm = new Game(player);
                pcForm.Show();
                this.Visible = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}