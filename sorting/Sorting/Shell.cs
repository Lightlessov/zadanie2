using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Components;
using MetroFramework.Forms;

namespace Sorting
{
    public partial class Shell : MetroForm
    {
        char[] split_chars = { ' ', ',' };
        public Shell()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string[] S_array = textBox1.Text.Split(split_chars);
                int[] I_arr = Array.ConvertAll(S_array, s => int.Parse(s));

                string[] sorted = ShellSort(I_arr);

                textBox1.Text = "";
                for (int i = 0; i < sorted.Length; i++)
                {
                    textBox1.Text += sorted[i] + " ";
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Неверный формат ввода. Пожалуйста, введите целые числа, разделенные пробелами или запятыми.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка: " + ex.Message);
            }
        }
        private static string[] ShellSort(int[] array)//Сортировка Шелла
        {
            string[] S_Arr = new string[array.Length];
            int step = array.Length / 2;
            while (step > 0)
            {
                int i, j;
                for (i = step; i < array.Length; i++)
                {
                    int value = array[i];
                    for (j = i - step; (j >= 0) && (array[j] > value); j -= step)
                    {
                        array[j + step] = array[j];
                    }
                    array[j + step] = value;
                }
                step /= 2;
            }
            for (int i = 0; i < array.Length; i++)
            {
                S_Arr[i] = array[i].ToString();
            }
            return S_Arr;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Создаем новый экземпляр Form1
            Form2 form2 = new Form2();

            // Открываем Form1
            form2.Show();
        }
    }
}
