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
    public partial class RegistracijaProizvoda : Form
    {
        DBclass Klasa;
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
    }
}
