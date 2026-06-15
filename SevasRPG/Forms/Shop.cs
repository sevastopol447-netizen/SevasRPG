using SevasRPG.Entities;
using SevasRPG.Entities.Characters;
using SevasRPG.Entities.Items;
using SevasRPG.Utils;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SevasRPG.Forms
{
    public partial class Shop : Form
    {
        private Game _parentForm;
        private Player player;

        public Shop(Game form, Player player, int type)
        {
            InitializeComponent();
            _parentForm = form;
            this.player = player;

            label1.Text = "У вас " + Convert.ToString(player.getSilver()) + " срібла";

            int num = CustomRandomizer.generateNumber(1, 10);
            ArmorGenerator ArmorGenerator = new ArmorGenerator();
            WeaponGenerator WeaponGenerator = new WeaponGenerator();

            List<Armor> generatedArmors = ArmorGenerator.createMany(num);
            List<Weapon> generatedWeapons = WeaponGenerator.createMany(9 - num);

            foreach (Armor item in generatedArmors)
            {
                listBox1.Items.Add(new ShopItem
                {
                    Item = item,
                    Price = item.getPrice(),
                    DisplayText = item.getName() + " | Захист: " + item.getVal() + " | Ціна: " + item.getPrice() + " срібла"
                });
            }
            foreach (Weapon item in generatedWeapons)
            {
                listBox1.Items.Add(new ShopItem
                {
                    Item = item,
                    Price = item.getPrice(),
                    DisplayText = item.getName() + " | Атака: " + item.getVal() + " | Ціна: " + item.getPrice() + " срібла"
                });
            }
        }

        private void Shop_Load(object sender, EventArgs e)
        {
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _parentForm.getPlayer(player);
            _parentForm.Visible = true;
            this.Close();
        }
        private Armor arm;

        private void button1_Click(object sender, EventArgs e)
        {
            arm = player.getArmor();
            if (listBox1.SelectedItem == null)
            {
                MessageBox.Show("Будь ласка, виберіть товар для покупки!", "Повідомлення", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            ShopItem selectedShopItem = (ShopItem)listBox1.SelectedItem;

            if (player.getSilver() < selectedShopItem.Price)
            {
                MessageBox.Show("У вас недостатньо срібла для цієї покупки!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                MessageBox.Show("Покупка відбулась успішно!", "Покупка", MessageBoxButtons.OK, MessageBoxIcon.None);
                player.decreaseSilver(selectedShopItem.Price);
            }

            listBox1.Items.Remove(selectedShopItem);

            label1.Text = "У вас " + Convert.ToString(player.getSilver()) + " срібла";
        }
    }
}
