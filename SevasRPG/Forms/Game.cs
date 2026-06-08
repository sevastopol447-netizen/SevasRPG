using SevasRPG.Entities.Characters;
using SevasRPG.GameServices.Events;
using SevasRPG.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
namespace SevasRPG.Forms
{
    public partial class Game : Form
    {
        private Player player;
        List<Event> randomEventList = new List<Event>();

        public Game(Player player)
        {
            InitializeComponent();

            this.player = player;
            labelName.Text = player.getName();

            randomEventList.Add(new DroppedOnFloor());
            randomEventList.Add(new Lost());
            randomEventList.Add(new FoundSkillBook());
        }
        public void AddText(string txt)
        {
            textBox1.AppendText(txt + Environment.NewLine);
            //listBox1.Items.Add("");
        }

        public void GenerateAction()
        {
            int num = CustomRandomizer.generateNumber(1, 100);
            if (num < 40)
            {
                AddText("Нічого не сталось");
            }
            else if (num >= 40 && num < 55)
            {
                if (num >=40 && num < 45)
                {
                    AddText("Ти проходиш повз магазин. Варто ззайти туди, може там є щось що знадобиться?");
                    Shop pcForm = new Shop(this, player, 2);
                    pcForm.Show();
                    this.Visible = false;

                }
                else if (num >= 45 && num < 50)
                {
                    AddText("Ти проходиш повз кузню. Може коваль накував щось новеньке?");
                    Shop pcForm = new Shop(this, player, 3);
                    pcForm.Show();
                    this.Visible = false;
                }
                else
                {
                    AddText("Ти проходиш повз магазин алхіміка. Варто заглянути, може там є щось корисне?");
                    Shop pcForm = new Shop(this, player, 1);
                    pcForm.Show();
                    this.Visible = false;
                }
            }
            else
            {
                Event ev = this.randomEventList[CustomRandomizer.generateNumber(this.randomEventList.Count)];
                ev.execute(player);
                AddText(ev.getDescription());

            }
        }
        private void button1_Click(object sender, EventArgs e)
        {   
            GenerateAction();
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