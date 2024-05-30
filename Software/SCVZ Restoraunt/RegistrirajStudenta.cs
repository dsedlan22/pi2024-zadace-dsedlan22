using SCVZ_Restoraunt.classes;
using SCVZ_Restoraunt.Klase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SCVZ_Restoraunt
{
    public partial class RegistrirajStudenta : Form
    {
        DBclass Klasa;
        private string JmbagStudenta;
        public RegistrirajStudenta(DBclass klasa)
        {
            InitializeComponent();
            Klasa = klasa;
            dataGridView1.Columns.Add("ime", "Ime Studenta");
            dataGridView1.Columns.Add("jmbag", "JMBAG");
            foreach (StudentClass student in Klasa.students)
            {
                dataGridView1.Rows.Add(student.JMBAG, student.ImeIprezime);
            }
            Klasa = klasa;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ImePrezime.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Unesi Cijelovite Podatke", "Ne radi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Klasa.InsertStudent(ImePrezime.Text, textBox2.Text);
                StudentClass noviStudent = new StudentClass(ImePrezime.Text, textBox2.Text);
                Klasa.students.Add(noviStudent);
                MessageBox.Show("Unesen je student", "Radi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Izlaz_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ObrisiStudenta_Click(object sender, EventArgs e)
        {
            Klasa.ObrisiStudenta(textBox2.Text);
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
            foreach (StudentClass student in Klasa.students)
            {
                dataGridView1.Rows.Add(student.JMBAG, student.ImeIprezime);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            JmbagStudenta = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            ObrisiStudenta.Enabled = true;
            AzurirajStudenta.Enabled = true;
            textBox2.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            ImePrezime.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
        }

        private void AzurirajStudenta_Click(object sender, EventArgs e)
        {
            Klasa.AzurirajStudenta(ImePrezime.Text, textBox2.Text, JmbagStudenta);
            dataGridView1.Rows.Clear();

            foreach (StudentClass student in Klasa.students)
            {
                dataGridView1.Rows.Add(student.JMBAG, student.ImeIprezime);
            }
            dataGridView1.Refresh();
        }
    }
}
