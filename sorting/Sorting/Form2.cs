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
    public partial class Form2 : MetroForm
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Создаем новый экземпляр Form1
            Form1 form1 = new Form1();

            // Открываем Form1
            form1.Show();

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Создаем новый экземпляр Form1
            Vstavka vstavka = new Vstavka();

            // Открываем Form1
            vstavka.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            // Создаем новый экземпляр Form1
            Bubble bubble = new Bubble();

            // Открываем Form1
            bubble.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Bubble bubble = new Bubble();
            bubble.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Shell shell = new Shell();
            shell.Show();
        }
    }
}


