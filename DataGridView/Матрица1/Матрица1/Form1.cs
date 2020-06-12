using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Матрица1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int a;
        private void btnCreate_Click(object sender, EventArgs e)
        {
            while (!int.TryParse(txtSize.Text, out a) | a < 1)
            {
                MessageBox.Show("Ошибка");
                txtSize.Focus();
                return;
            }

            table1.ColumnCount = table1.RowCount = a;

            Random value = new Random();

            for (int i = 0; i < a; i++)
                for (int j = 0; j < a; j++)
                    table1[i, j].Value = value.Next(0, 10);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
