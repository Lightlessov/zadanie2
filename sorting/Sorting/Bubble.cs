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
   
    public partial class Bubble : MetroForm
    {
        char[] split_chars = { ' ', ',' };
        public Bubble()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string[] S_array = textBox1.Text.Split(split_chars);
                int[] I_arr = Array.ConvertAll(S_array, s => int.Parse(s));

                string[] sorted = BubbleSort(I_arr);

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
        public static string[] BubbleSort(int[] array)//Сортировка пузырьком
        {
            string[] S_Arr = new string[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;

                    }
                }
            }
            for (int i = 0; i < array.Length; i++)
            {
                S_Arr[i] = array[i].ToString();
            }
            return S_Arr;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            // Создаем новый экземпляр Form1
            Form2 form2 = new Form2();

            // Открываем Form1
            form2.Show();
        }
    }
}
