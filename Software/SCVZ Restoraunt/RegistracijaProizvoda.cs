using SCVZ_Restoraunt.classes;
using SCVZ_Restoraunt.Klase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SCVZ_Restoraunt
{
    public partial class RegistracijaProizvoda : Form
    {
        DBclass Klasa;
        float suma;
        private string KodProizvoda;
        public RegistracijaProizvoda(DBclass klasa)
        {
            InitializeComponent();
            Klasa = klasa;
            dataGridView1.Columns.Add("kod", "Kod Artikla");
            dataGridView1.Columns.Add("naziv", "Naziv Artikla");
            dataGridView1.Columns.Add("cijena", "Cijena Artikla");
            foreach (JeloClass jelo in Klasa.jela)
            {
                dataGridView1.Rows.Add(jelo.Kod, jelo.Naziv, jelo.Cijena);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "")
            {
                MessageBox.Show("Unesi Cijelovite Podatke", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (Klasa.RegistracijaProizvoda(textBox1.Text, textBox2.Text, textBox3.Text) == 1)
                {
                    dataGridView1.Rows.Add(textBox2.Text, textBox1.Text, textBox3.Text);
                    dataGridView1.Refresh();
                    MessageBox.Show("Proizvod je unesen", "Operacija je uspješna", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else MessageBox.Show("Došlo je do greške", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void UpdateJela(object sender, DataGridViewCellEventArgs e)
        {
            KodProizvoda = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            button3.Enabled = true;
            textBox1.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            textBox2.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            textBox3.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Provjera jesu li svi TextBox ispunjeni
            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text) || string.IsNullOrEmpty(textBox3.Text))
            {
                MessageBox.Show("Unesi Cijelovite Podatke", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Provjera je li cijena ispravno unesena kao decimalni broj
            if (!decimal.TryParse(textBox3.Text, out decimal cijena))
            {
                MessageBox.Show("Unesi ispravnu cijenu", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Ažuriraj proizvod i provjeri je li ažuriranje uspješno
            int rezultat = Klasa.AzurirajJelo(textBox1.Text, textBox2.Text, cijena.ToString(), KodProizvoda);
            if (rezultat == 1)
            {
                // Osvježi DataGridView ako je ažuriranje uspješno
                dataGridView1.Rows.Clear();
                dataGridView1.Refresh();
                foreach (JeloClass jelo in Klasa.jela)
                {
                    dataGridView1.Rows.Add(jelo.Kod, jelo.Naziv, jelo.Cijena);
                }
                MessageBox.Show("Proizvod je ažuriran", "Uspješno ažuriranje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                // Obavijesti korisnika ako ažuriranje nije uspjelo
                MessageBox.Show("Došlo je do greške prilikom ažuriranja", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Klasa.ObrisiJelo(textBox2.Text);
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
            foreach (JeloClass jelo in Klasa.jela)
            {
                dataGridView1.Rows.Add(jelo.Kod, jelo.Naziv, jelo.Cijena);
            }
        }

        private void PretraživanjeProizvodaTextBox_TextChanged(object sender, EventArgs e)
        {
            if (PretraživanjeProizvodaTextBox.Text == "")
            {
                dataGridView1.Rows.Clear();
                dataGridView1.Refresh();
                foreach (JeloClass jelo in Klasa.jela)
                {
                    dataGridView1.Rows.Add(jelo.Kod, jelo.Naziv, jelo.Cijena);
                }
            }
            else
            {
                string regx = "[" + PretraživanjeProizvodaTextBox.Text + "]";
                Regex rg = new Regex(regx);
                dataGridView1.Rows.Clear();
                foreach (JeloClass jelo in Klasa.jela)
                {
                    if (rg.IsMatch(jelo.Naziv))
                        dataGridView1.Rows.Add(jelo.Kod, jelo.Naziv, jelo.Cijena);
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
