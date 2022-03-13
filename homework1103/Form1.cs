using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace homework1103
{
    public partial class Form1 : Form
    {
        int id;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("List.txt");

            DataSet ds = new DataSet();

            ds.Tables.Add("List");
            string str = sr.ReadLine();

            string[] count = System.Text.RegularExpressions.Regex.Split(str, ",");

            for (int i = 0; i < count.Length; i++)
            {
                ds.Tables[0].Columns.Add(count[i]);
            }

            string row = sr.ReadLine();
            while (row != null)
            {
                string[] val = System.Text.RegularExpressions.Regex.Split(row, ",");
                ds.Tables[0].Rows.Add(val);
                row = sr.ReadLine();
            }

            dataGridView1.DataSource = ds.Tables[0];

        }

        private void button2_Click(object sender, EventArgs e)
        {
            NewP newP = new NewP();
            newP.ShowDialog();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel1.Visible = !panel1.Visible;
        }

        private void button5_Click(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            if (rowIndex < 0 || rowIndex >= PerData.people.Count)
            {
                return;
            }
            panel1.Visible = true;

            id = int.Parse(dataGridView1.Rows[rowIndex].Cells[0].Value.ToString());

            pictureBox1.Image = Image.FromFile(PerData.people[id].image);
            textBox2.Text = dataGridView1.Rows[rowIndex].Cells[1].Value.ToString() + " " + dataGridView1.Rows[rowIndex].Cells[2].Value.ToString();
            textBox5.Text = dataGridView1.Rows[rowIndex].Cells[3].Value.ToString();
            if (dataGridView1.Rows[rowIndex].Cells[4].Value is Gender.male)
            {
                textBox3.Text = "М";
            }
            else
            {
                textBox3.Text = "Ж";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Inf inf = new Inf();
            if (inf.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }
            dataGridView1.Rows.Clear();
        }
    }

    
} 
