using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab11Q2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            dataGridView.ColumnCount = 6;
            dataGridView.Columns[0].Name = "Account No";
            dataGridView.Columns[1].Name = "Name";
            dataGridView.Columns[2].Name = "Branch Code";
            dataGridView.Columns[3].Name = "Account Type";
            dataGridView.Columns[4].Name = "ATM Request";
            dataGridView.Columns[5].Name = "Balance";

            string[] row = new string[] { "1122334455", "Shayan", "990", "Current", "Yes", "5000000" };
            dataGridView.Rows.Add(row);
            row = new string[] { "9075678456", "Maaz", "156", "Saving", "No", "4000000" };
            dataGridView.Rows.Add(row);
            row = new string[] { "8956780456", "Abdullah", "674", "Current", "Yes", "6500000" };
            dataGridView.Rows.Add(row);
            row = new string[] { "6725823041", "Aziz", "222", "Saving", "Yes", "3590000" };
            dataGridView.Rows.Add(row);

            

        }
    }
}
