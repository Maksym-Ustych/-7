using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Practical7_Ustych
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Початковий стан груп
            groupBoxTea.Enabled = checkBoxTea.Checked;
            groupBoxPizza.Enabled = checkBoxPizza.Checked;

            // Події вибору страв
            checkBoxTea.CheckedChanged += Dish_CheckedChanged;
            checkBoxCoffee.CheckedChanged += Dish_CheckedChanged;
            checkBoxPizza.CheckedChanged += Dish_CheckedChanged;
            checkBoxSalad.CheckedChanged += Dish_CheckedChanged;

            // Події начинки піци
            checkBoxCheese.CheckedChanged += CalculateChanged;
            checkBoxMushrooms.CheckedChanged += CalculateChanged;
            checkBoxChicken.CheckedChanged += CalculateChanged;

            // Подія знижки
            checkBoxDiscount.CheckedChanged += CalculateChanged;

            CalculateTotal();
        }

        // Вибір або скасування страви
        private void Dish_CheckedChanged(object? sender, EventArgs e)
        {
            // Додаткові параметри доступні тільки після вибору страви
            groupBoxTea.Enabled = checkBoxTea.Checked;
            groupBoxPizza.Enabled = checkBoxPizza.Checked;

            // Відображення зображення
            if (sender == checkBoxTea && checkBoxTea.Checked)
            {
                ShowImage("tea.jpg");
            }
            else if (sender == checkBoxCoffee && checkBoxCoffee.Checked)
            {
                ShowImage("coffee.jpg");
            }
            else if (sender == checkBoxPizza && checkBoxPizza.Checked)
            {
                ShowImage("pizza.jpg");
            }
            else if (sender == checkBoxSalad && checkBoxSalad.Checked)
            {
                ShowImage("salad.jpg");
            }
            else
            {
                ShowSelectedImage();
            }

            CalculateTotal();
        }

        // Перерахунок після зміни начинки або знижки
        private void CalculateChanged(object? sender, EventArgs e)
        {
            CalculateTotal();
        }

        // Обчислення загальної вартості
        private void CalculateTotal()
        {
            double total = 0;

            if (checkBoxTea.Checked)
            {
                total += 40;
            }

            if (checkBoxCoffee.Checked)
            {
                total += 60;
            }

            if (checkBoxPizza.Checked)
            {
                total += 120;

                if (checkBoxCheese.Checked)
                {
                    total += 20;
                }

                if (checkBoxMushrooms.Checked)
                {
                    total += 25;
                }

                if (checkBoxChicken.Checked)
                {
                    total += 35;
                }
            }

            if (checkBoxSalad.Checked)
            {
                total += 80;
            }

            // Знижка 10%
            if (checkBoxDiscount.Checked)
            {
                total *= 0.90;
            }

            lblTotal.Text = $"Загальна сума: {total:0.##} грн";
        }

        // Показ зображення у PictureBox
        private void ShowImage(string fileName)
        {
            string path = Path.Combine(Application.StartupPath, fileName);

            if (File.Exists(path))
            {
                if (pictureBoxDish.Image != null)
                {
                    pictureBoxDish.Image.Dispose();
                    pictureBoxDish.Image = null;
                }

                pictureBoxDish.Image = Image.FromFile(path);
            }
        }

        // Відображення однієї з вибраних страв
        private void ShowSelectedImage()
        {
            if (checkBoxPizza.Checked)
            {
                ShowImage("pizza.jpg");
            }
            else if (checkBoxSalad.Checked)
            {
                ShowImage("salad.jpg");
            }
            else if (checkBoxCoffee.Checked)
            {
                ShowImage("coffee.jpg");
            }
            else if (checkBoxTea.Checked)
            {
                ShowImage("tea.jpg");
            }
            else
            {
                if (pictureBoxDish.Image != null)
                {
                    pictureBoxDish.Image.Dispose();
                    pictureBoxDish.Image = null;
                }
            }
        }

        // Старі події, які залишилися прив'язаними у конструкторі форми
        private void checkBoxTea_CheckedChanged(object? sender, EventArgs e)
        {
        }

        private void checkBoxCoffee_CheckedChanged(object? sender, EventArgs e)
        {
        }

        private void checkBox1_CheckedChanged(object? sender, EventArgs e)
        {
        }

        private void Form1_Load(object? sender, EventArgs e)
        {
        }
    }
}