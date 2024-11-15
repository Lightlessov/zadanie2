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
	public partial class Form1 : MetroForm
	{
		public Form1()
		{
			InitializeComponent();
		}
        char[] split_chars = { ' ', ',' };

        //---------------------------------------------------------------------------------------
        private void button1_Click(object sender, EventArgs e) //Сортировка вставками
        {
            try
            {
                string[] S_array = richTextBox1.Text.Split(split_chars);
                int[] I_arr = Array.ConvertAll(S_array, s => int.Parse(s));

                string[] sorted = InsertionSort(I_arr);

                richTextBox1.Text = "";
                for (int i = 0; i < sorted.Length; i++)
                {
                    richTextBox1.Text += sorted[i] + " ";
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
		public static string[] InsertionSort(int[] array) //Сортировка вставками
		{
			string[] S_Arr = new string [array.Length];
			for (int i = 1; i < array.Length; i++)
			{
				int cur = array[i];
				int j = i;
				while (j > 0 && cur < array[j - 1])
				{
					array[j] = array[j - 1];
					j--;
				}
				array[j] = cur;
			}
			for (int i = 0; i < array.Length; i++)
			{
				S_Arr[i] = array[i].ToString();
			}
			return S_Arr;
		}
		//---------------------------------------------------------------------------------------
		private void button2_Click(object sender, EventArgs e)//Сортировка пузырьком
		{
            try
            {
                string[] S_array = richTextBox2.Text.Split(split_chars);
                int[] I_arr = Array.ConvertAll(S_array, s => int.Parse(s));

                string[] sorted = BubbleSort(I_arr);

                richTextBox2.Text = "";
                for (int i = 0; i < sorted.Length; i++)
                {
                    richTextBox2.Text += sorted[i] + " ";
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
		//---------------------------------------------------------------------------------------
		private void button3_Click(object sender, EventArgs e)//Сортировка выбором
		{
            try
            {
                string[] S_array = richTextBox3.Text.Split(split_chars);
                int[] I_arr = Array.ConvertAll(S_array, s => int.Parse(s));

                string[] sorted = SelectionSort(I_arr);

                richTextBox3.Text = "";
                for (int i = 0; i < sorted.Length; i++)
                {
                    richTextBox3.Text += sorted[i] + " ";
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
		public static string[] SelectionSort(int[] array)//Сортировка выбором
		{
			string[] S_Arr = new string[array.Length];
			for (int i = 0; i < array.Length - 1; i++)
			{
				int min = i;
				for (int j = i + 1; j < array.Length; j++)
				{
					if (array[j] < array[min])
					{
						min = j;
					}
				}
				int dummy = array[i];
				array[i] = array[min];
				array[min] = dummy;
				min = i;
			}
			for (int i = 0; i < array.Length; i++)
			{
				S_Arr[i] = array[i].ToString();
			}
			return S_Arr;
		}
		//---------------------------------------------------------------------------------------
		private void button4_Click(object sender, EventArgs e)//Сортировка Шелла
		{
            try
            {
                string[] S_array = richTextBox4.Text.Split(split_chars);
                int[] I_arr = Array.ConvertAll(S_array, s => int.Parse(s));

                string[] sorted = ShellSort(I_arr);

                richTextBox4.Text = "";
                for (int i = 0; i < sorted.Length; i++)
                {
                    richTextBox4.Text += sorted[i] + " ";
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

        private void button5_Click(object sender, EventArgs e)
        {
            // Создаем новый экземпляр Form1
            Form2 form2 = new Form2();

            // Открываем Form1
            form2.Show();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
