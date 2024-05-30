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
                MessageBox.Show("Unesi Cijelovite Podatke", "Ne radi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                foreach (StudentClass student in Klasa.students)
                {
                    //Console.WriteLine("Student "+student.ImeIprezime.ToString() + "jmbag njegov" + student.JMBAG + "Jmbag Unese:" + BoxUnosStudenta.Text);
                    if (student.ImeIprezime == BoxUnosStudenta.Text)
                    {

                        MessageBox.Show("Procitan Student", "Radi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        UnosProizvoda.Enabled = true;
                        label4.Text = student.ImeIprezime;
                        label3.Text = student.JMBAG;
                        UnesenStudent = 1;
                        break;


                    }
                }
                if (UnesenStudent == 0)
                {
                    MessageBox.Show("Ne postoji taj student", "Ne radi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void UnosProizvoda_Click(object sender, EventArgs e)
        {
            int uneseno = 0;

            if (UnosProizvoda.Text == "") MessageBox.Show("Unesi Cijelovite Podatke", "Ne radi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("Ne postoji taj proizvod", "Ne radi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Procitan Proizvod", "Radi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
    }
}
