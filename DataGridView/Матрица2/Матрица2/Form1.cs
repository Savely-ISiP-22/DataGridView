using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Матрица2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int a;
        int value;
        int minValue;
        int maxValue;

        private void btnCreate_Click(object sender, EventArgs e)
        {
            minValue = 51;
            maxValue = -1;
            while (!int.TryParse(txtSize.Text, out a) | a < 1)
            {
                MessageBox.Show("Ошибка в данных!");
                txtSize.Focus();
                return;
            }

            table1.ColumnCount = table1.RowCount = a;

            Random rnd = new Random();

            for (int i = 0; i < a; i++)
                for (int j = 0; j < a; j++)
                {
                    value = rnd.Next(0, 51);

                    if (value >= maxValue)
                    {
                        maxValue = value;
                    }

                    else

                    if (value <= minValue)
                    {
                        minValue = value;
                    }

                    table1[i, j].Value = value;
                }

            lb1.Text = "Разница: " + (maxValue - minValue).ToString();
        }
    }
}
