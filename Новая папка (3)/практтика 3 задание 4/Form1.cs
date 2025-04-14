using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;


namespace практтика_3_задание_4
{
    public partial class Form1 : Form
    {
        private int collectionLength = 0;
        private Calculator calculator = new Calculator(); 
        public Form1()
        {
            InitializeComponent();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            collectionLength = (int)numericUpDown1.Value;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(collectionLength.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (collectionLength <= calculator.GetAllItems().Count)
            {
                MessageBox.Show("Достигнута граница массива");
                return;
            }

            if (string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("Введите текст!");
                return;
            }

            calculator.AddItem(textBox2.Text); 

           
            listBox1.Items.Clear();
            foreach (var item in calculator.GetAllItems())
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

            object selectedItem = calculator.collection[listBox1.SelectedIndex];

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

        private void button4_Click(object sender, EventArgs e)
        {
            double sum = calculator.SumAllNumbers();
            MessageBox.Show($"Сумма всех чисел: {sum}");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            double max = calculator.FindMaxNumber();
            MessageBox.Show($"Максимальное число: {max}");
        }
    }
}
