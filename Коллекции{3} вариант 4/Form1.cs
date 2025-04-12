using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Коллекции_3__ArrayLisdt
{
    public partial class Form1 : Form
    {
        int counter = 0;
        int CollectionLength = 0;
        ArrayList collection = new ArrayList();
        public Form1()
        {
            InitializeComponent();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            CollectionLength = (int)numericUpDown1.Value;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(CollectionLength.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (CollectionLength <= collection.Count)
            {
                MessageBox.Show("Достигнута граница массива");
                return;
            }

            if (string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("Введите текст!");
                return;
            }

            collection.Add(textBox2.Text);
            counter++;

            listBox1.Items.Clear();
            foreach (var item in collection)
            {
                listBox1.Items.Add(item);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Выберите элемент из списка!");
                return;
            }

            object selectedItem = collection[listBox1.SelectedIndex];

            bool isNumber = double.TryParse(selectedItem.ToString(), out double selectedNumber);
            if (!isNumber)
            {
                MessageBox.Show("Выбранное значение не является числом!");
                return;
            }

            if (!double.TryParse(textBox1.Text, out double inputNumber))
            {
                MessageBox.Show("Вы ввели не число!");
                return;
            }

            MessageBox.Show($"Ответ: {selectedNumber * inputNumber}");
        }
    }
}
