using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4
{
    public partial class Form2 : Form
    {
        
        Random r = new Random();
        int[] pole1;
        public Form2()
        {
            InitializeComponent();
           
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = (int)numericUpDown1.Value;
            int[] pole = new int[n];
            pole1 = new int[n];

            for (int i = 0; i < n; i++)
            {
                pole[i] = r.Next(101);
            }
            Array.Sort(pole);
            listBox1.Items.Clear();
            foreach (int i in pole)
            {
                listBox1.Items.Add(i);
            }
            pole1 = pole;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            listBox3.Items.Clear();

           int n = 0;
            for (int i = 0; i < pole1.Length; i++)
            {
                if (pole1[i] < (int)numericUpDown2.Value)
                {
                    n = i + 1;
                }
                else
                    i = pole1.Length;
            }
            foreach (int i in pole1.Take(n).ToArray())
            {
                listBox2.Items.Add(i);
            }
            foreach (int i in pole1.Skip(n + 1).ToArray())
            {
                listBox3.Items.Add(i);
            }
        }
    }
}
