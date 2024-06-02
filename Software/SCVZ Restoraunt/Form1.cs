using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SCVZ_Restoraunt.classes;
using SCVZ_Restoraunt.Klase;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace SCVZ_Restoraunt
{
    public partial class Form1 : Form
    {
        private int UnesenStudent;
        float suma;
        DBclass Klasa;
        public Form1()
        {

            Klasa = new DBclass();
            InitializeComponent();
            UnesenStudent = 0;
            suma = 0;
            dataGridView1.Columns.Add("kod", "Kod Artikla");
            dataGridView1.Columns.Add("naziv", "Naziv Artikla");
            dataGridView1.Columns.Add("cijena", "Cijena Artikla");
            CijenaSuma.Text = "0";

        }

        private void IzlazGumb_Click(object sender, EventArgs e)
        {
            this.Close();
            return;
        }

        private void RegistracijaStudenta_Click(object sender, EventArgs e)
        {
            RegistrirajStudenta obrazac = new RegistrirajStudenta(Klasa);
            obrazac.ShowDialog();
            Console.WriteLine("Radi gumb");
        }

        private void RegistracijaProizvoda_Click(object sender, EventArgs e)
        {
            RegistracijaProizvoda obrazac = new RegistracijaProizvoda(Klasa);
            obrazac.ShowDialog();
        }

        private void UnosStudenta_Click(object sender, EventArgs e)
        {
            if (BoxUnosStudenta.Text == "")
            {
                MessageBox.Show("Unesi Cijelovite Podatke", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                foreach (StudentClass student in Klasa.students)
                {
                    //Console.WriteLine("Student "+student.ImeIprezime.ToString() + "jmbag njegov" + student.JMBAG + "Jmbag Unese:" + BoxUnosStudenta.Text);
                    if (student.ImeIprezime == BoxUnosStudenta.Text)
                    {

                        MessageBox.Show("Student je uspješno unesen u sustav", "Uspješan unos studenta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        UnosProizvoda.Enabled = true;
                        label4.Text = student.ImeIprezime;
                        label3.Text = student.JMBAG;
                        UnesenStudent = 1;
                        break;


                    }
                }
                if (UnesenStudent == 0)
                {
                    MessageBox.Show("Ne postoji taj student", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void UnosProizvoda_Click(object sender, EventArgs e)
        {
            if (UnesenStudent == 0)
            {
                MessageBox.Show("Student nije unesen. Molimo unesite studenta prije unosa proizvoda.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int uneseno = 0;
            

            if (UnosProizvoda.Text == "") MessageBox.Show("Unesi Cijelovite Podatke", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            Console.WriteLine("Uneseno je " + textBox1.Text);
            foreach (JeloClass jelo in Klasa.jela)
            {
                Console.WriteLine("Kod proizvoda je" + jelo.Kod);
                if (textBox1.Text == jelo.Kod)
                {
                    dataGridView1.Rows.Add(jelo.Kod, jelo.Naziv, jelo.Cijena);
                    suma += float.Parse(jelo.Cijena);
                    CijenaSuma.Text = suma.ToString();
                    uneseno = 1;
                }
            }
            if (uneseno == 0)
            {
                MessageBox.Show("Ne postoji taj proizvod", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Proizvod je uspješno unesen", "Uspješan unos", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void btnNaruci_Click(object sender, EventArgs e)
        {
            // Prikaz poruke o uspješnoj narudžbi
            MessageBox.Show("Uspješno ste naručili svoje proizvode.", "Narudžba uspješna", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Resetiranje DataGridView za ponovnu kupnju
            dataGridView1.Rows.Clear();
            suma = 0;
            CijenaSuma.Text = suma.ToString();
        }
    }
}
