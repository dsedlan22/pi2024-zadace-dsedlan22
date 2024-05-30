using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SCVZ_Restoraunt.Klase;


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
    }
}
