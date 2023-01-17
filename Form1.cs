using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace ЗП
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        StreamReader SR;
        StreamWriter SW;
        double qulification;
        double coeff;
        double Staz;

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.Rows.Add();
                dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[0].Value = textBox1.Text;
                dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[1].Value = textBox9.Text;
                dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[2].Value = comboBox1.SelectedItem;
                dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[3].Value = textBox2.Text;
                dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[4].Value = comboBox2.SelectedItem;
                dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[5].Value = coeff;
                dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[6].Value = Convert.ToDouble(textBox8.Text) * coeff;
                dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[7].Value = Convert.ToDouble(textBox3.Text);
                dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[8].Value = Math.Round(Convert.ToDouble(textBox8.Text) * coeff * Convert.ToDouble(textBox3.Text) / (Convert.ToDouble(textBox3.Text) / Convert.ToDouble(textBox2.Text)), 2, MidpointRounding.AwayFromZero);
                dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[9].Value = textBox4.Text;
                dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[10].Value = Math.Round(Math.Round(Convert.ToDouble(textBox8.Text) * coeff * Convert.ToDouble(textBox3.Text) / (Convert.ToDouble(textBox3.Text) / Convert.ToDouble(textBox2.Text)), 2, MidpointRounding.AwayFromZero) * (Convert.ToDouble(textBox4.Text) / 100), 2, MidpointRounding.AwayFromZero);
                dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[11].Value = Staz;
                dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[12].Value = Staz * Convert.ToDouble(textBox8.Text);
                dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[13].Value = qulification;
                dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[14].Value = Math.Round(qulification * Convert.ToDouble(dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[8].Value), 2, MidpointRounding.AwayFromZero);
                dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[15].Value = textBox6.Text;
                dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[16].Value = Math.Round(Convert.ToDouble(textBox6.Text) / 100 * Convert.ToDouble(dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[8].Value), 2, MidpointRounding.AwayFromZero);
                dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[17].Value = textBox7.Text;
                dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[18].Value = Math.Round(Convert.ToDouble(textBox7.Text) / 100 * Convert.ToDouble(dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[8].Value), 2, MidpointRounding.AwayFromZero);
                dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[19].Value = Convert.ToDouble(dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[8].Value) + Convert.ToDouble(dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[10].Value) + Convert.ToDouble(dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[12].Value) + Convert.ToDouble(dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[14].Value) + Convert.ToDouble(dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[16].Value) + Convert.ToDouble(dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[18].Value);
            }
            catch
            {

            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)//Категория
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    {
                        qulification = 0.3;
                        break;
                    }
                case 1:
                    {
                        qulification = 0.4;
                        break;
                    }
                case 2:
                    {
                        qulification = 0.5;
                        break;
                    }
                case 3:
                    {
                        qulification = 0.65;
                        break;
                    }
                case 4:
                    {
                        qulification = 0.8;
                        break;
                    }
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e) //Коэффициент
        {
            switch (comboBox2.SelectedIndex)
            {
                case 0:
                    {
                        coeff = 1.57;
                        break;
                    }
                case 1:
                    {
                        coeff = 1.68;
                        break;
                    }
                case 2:
                    {
                        coeff = 1.79;
                        break;
                    }
                case 3:
                    {
                        coeff = 1.91;
                        break;
                    }
                case 4:
                    {
                        coeff = 2.03;
                        break;
                    }
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox3.SelectedIndex)
            {
                case 0:
                    {
                        Staz = 0.1;
                        break;
                    }
                case 1:
                    {
                        Staz = 0.15;
                        break;
                    }
                case 2:
                    {
                        Staz = 0.2;
                        break;
                    }
                case 3:
                    {
                        Staz = 0.3;
                        break;
                    }
            }
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                SW = new StreamWriter("Saves.txt");
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    SW.WriteLine();
                    for (int j = 0; j <= 19; j++)
                    {
                        SW.WriteLine(dataGridView1.Rows[i].Cells[j].Value);
                    }
                }
                SW.Close();
            }
            catch
            {

            }
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                SR = new StreamReader("Saves.txt");
                while (SR.ReadLine() != null)
                {
                    dataGridView1.Rows.Add(SR.ReadLine(), SR.ReadLine(), SR.ReadLine(), SR.ReadLine(), SR.ReadLine(), SR.ReadLine(), SR.ReadLine(), SR.ReadLine(), SR.ReadLine(), SR.ReadLine(), SR.ReadLine(), SR.ReadLine(), SR.ReadLine(), SR.ReadLine(), SR.ReadLine(), SR.ReadLine(), SR.ReadLine(), SR.ReadLine(), SR.ReadLine(), SR.ReadLine());
                }
            }
            catch
            {

            }
        }
    }
}