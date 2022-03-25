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
    public partial class Form3 : Form
    {
        
        public Form3()
        {
            InitializeComponent();
            
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            int[] pole = new int[textBox1.Lines.Length];
            bool skip = false;

            int n = 0;
            for (int i = 0; i < textBox1.Lines.Length; i++)
            {
                try
                {
                    int.Parse(textBox1.Lines[i]);
                }
                catch
                {
                    i = textBox1.Lines.Length;
                    skip = true;
                    MessageBox.Show("Špatná čísla", "Error");
                }
            }
            if (!skip)
            {
                for (int i = 0; i < textBox1.Lines.Length; i++)
                {
                    if (textBox1.Lines[i] == "0")
                    {
                        i = textBox1.Lines.Length;
                    }
                    else
                    {
                        n = i;
                        pole[i] = Convert.ToInt32(textBox1.Lines[i]);
                    }
                }
                label1.Text = ((double)pole[0] / pole[n]).ToString();

                foreach (int i in pole)
                {
                    listBox1.Items.Add(i + " S pocizí: " + (listBox1.Items.Count + 1));
                }
            }
        }
    }
}
