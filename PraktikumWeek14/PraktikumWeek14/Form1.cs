using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PraktikumWeek14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBoxInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonReverse_Click(object sender, EventArgs e)
        {
            if (textBoxInput.Text.Trim() == string.Empty)
            {
                MessageBox.Show("tolong isi textbox terlebih dahulu!");
            }
            else
            {
                string strg = textBoxInput.Text;
                char[] arr1 = strg.ToCharArray();
                string strg2 = "";

                for (int i = 0; i <= strg.Length - 1; i++)
                {
                    Console.Out.Write(strg[1]);
                }
                for (int i = strg.Length - 1; i >= 0; i--)
                {
                    Console.Out.Write(strg[i]);
                    strg2 = strg2 + strg[i];
                }

                labelOutput.Text = strg2;
            }
        }

        private void buttonUrutkan_Click(object sender, EventArgs e)
        {
            if (textBoxInput.Text.Trim() == string.Empty)
            {
                MessageBox.Show("tolong isi textbox terlebih dahulu!");
            }
            else
            {
                char sort;
                string strg = textBoxInput.Text;
                char[] arr1 = strg.ToCharArray();

                for (int i = 1; i < arr1.Length; i++)
                {
                    for (int j = 0; j < arr1.Length - 1; j++)
                    {
                        if (arr1[j] > arr1[j + 1])
                        {
                            sort = arr1[j];
                            arr1[j] = arr1[j + 1];
                            arr1[j + 1] = sort;
                        }
                    }
                }
                labelOutput.Text = arr1.ToString();
            }
            
        }
    }
}
