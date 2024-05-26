using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using CollegeRestraunt.classes;
using System.Threading.Tasks;

namespace SCVZ_Restoraunt.Klase
{
    public class DBclass
    {
        string Connection = "Server=31.147.206.65;Database=PI2324_dsedlan22_DB;Persist Security Info=True;User Id=PI2324_dsedlan22_User;Password='!;sx].Ga'";
        SqlConnection konekcija;
        public List<StudentClass> students = new List<StudentClass>();
        public List<JeloClass> jela = new List<JeloClass>();

        public DBclass()
        {

            konekcija = new SqlConnection(Connection);
            try
            {
                konekcija.Open();
                SqlCommand cmd;
                SqlDataReader reader;
                cmd = new SqlCommand("Select * from Studenti", konekcija);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    //Console.WriteLine(reader.GetValue(1) + " " + reader.GetValue(2));
                    StudentClass noviStudent = new StudentClass(reader.GetValue(0).ToString(), reader.GetValue(1).ToString(), reader.GetValue(2).ToString());
                    students.Add(noviStudent);


                }
                reader.Close();
                cmd = new SqlCommand("Select * from Jela", konekcija);

                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    //Console.WriteLine(reader.GetValue(0) + " " + reader.GetValue(1) + " " + reader.GetValue(2));
                    JeloClass novoJelo = new JeloClass(reader.GetValue(1).ToString(), reader.GetValue(2).ToString(), reader.GetValue(3).ToString());
                    jela.Add(novoJelo);
                }
                konekcija.Close();
                reader.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                konekcija.Close();
            }
        }

        private void UcitavanjeJela()
        {
            jela.Clear();
            //konekcija.Open();
            SqlCommand cmd = new SqlCommand("Select * from Jela", konekcija);
            SqlDataReader reader;
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                JeloClass novoJelo = new JeloClass(reader.GetValue(1).ToString(), reader.GetValue(2).ToString(), reader.GetValue(3).ToString());
                jela.Add(novoJelo);
            }
            konekcija.Close();

        }

        public int RegistracijaProizvoda(string naziv, string kod, string cijena)
        {
            try
            {
                string query = "INSERT INTO Jela (NazivJela, KodJela, CijenaJela)  VALUES('" + naziv + "', '" + kod + "'," + cijena + "); ";
                SqlCommand sqlCommand = new SqlCommand(query, konekcija);

                SqlDataAdapter adapter = new SqlDataAdapter();
                konekcija.Open();
                jela.Add(new JeloClass(naziv, kod, cijena));
                adapter.InsertCommand = sqlCommand;
                adapter.InsertCommand.ExecuteNonQuery();
                //konekcija.Close();

                return 1;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return 0;
            }
            finally
            {
                konekcija.Close();

            }
        }

        public string InsertStudent(string ime, string jmbag)
        {
            //string ImeIPrezime, int Jmbag
            try
            {
                //SqlConnection konekcija = new SqlConnection(Connection);
                string query = "INSERT INTO Studenti (ImeIPrezimeStudenta, Jmbag) VALUES('" + ime + "', '" + jmbag + "'); ";
                SqlCommand sqlCommand = new SqlCommand(query, konekcija);

                SqlDataAdapter adapter = new SqlDataAdapter();
                konekcija.Open();
                adapter.InsertCommand = sqlCommand;
                adapter.InsertCommand.ExecuteNonQuery();
                konekcija.Close();
                return "1";
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return ex.Message.ToString();
            }

        }

        public int AzurirajJelo(string naziv, string kod, string cijena, string Usporedba)
        {
            try
            {
                konekcija.Open();
                string query = "UPDATE Jela SET NazivJela = '" + naziv + "', KodJela = '" + kod + "', CijenaJela = " + cijena + " WHERE KodJela = '" + Usporedba + "' ";
                SqlCommand sqlCommand = new SqlCommand(query, konekcija);
                Console.WriteLine(query);
                SqlDataAdapter adapter = new SqlDataAdapter();
                //konekcija.Open();
                adapter.InsertCommand = sqlCommand;
                adapter.InsertCommand.ExecuteNonQuery();

                UcitavanjeJela();
                konekcija.Close();

                return 1;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                konekcija.Close();
                return 0;
            }

        }

        public int ObrisiJelo(string Kod)
        {
            try
            {
                konekcija.Open();
                string query = "DELETE FROM Jela WHERE KodJela = '" + Kod + "'";
                SqlCommand sqlCommand = new SqlCommand(query, konekcija);
                Console.WriteLine(query);
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.InsertCommand = sqlCommand;
                adapter.InsertCommand.ExecuteNonQuery();
                UcitavanjeJela();
                konekcija.Close();
            }
            catch (Exception ex)
            {

            }
            return 1;
        }

        private void UcitavanjeStudenata()
        {
            students.Clear();
            //konekcija.Open();
            SqlCommand cmd;
            SqlDataReader reader;
            cmd = new SqlCommand("Select * from Studenti", konekcija);
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                //Console.WriteLine(reader.GetValue(1) + " " + reader.GetValue(2));
                StudentClass noviStudent = new StudentClass(reader.GetValue(0).ToString(), reader.GetValue(1).ToString(), reader.GetValue(2).ToString());
                students.Add(noviStudent);


            }
            //reader.Close();
            konekcija.Close();

        }

        public int ObrisiStudenta(string jmbag)
        {
            try
            {
                konekcija.Open();
                string query = "DELETE FROM Studenti WHERE Jmbag = '" + jmbag + "'";
                SqlCommand sqlCommand = new SqlCommand(query, konekcija);
                Console.WriteLine(query);
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.InsertCommand = sqlCommand;
                adapter.InsertCommand.ExecuteNonQuery();
                UcitavanjeStudenata();
                konekcija.Close();
                return 1;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return 0;
            }
        }

        public int AzurirajStudenta(string naziv, string jmbag, string Usporedba)
        {
            try
            {
                konekcija.Open();
                string query = "UPDATE Studenti SET ImeIPrezimeStudenta = '" + naziv + "', Jmbag='" + jmbag + "' WHERE Jmbag = '" + Usporedba + "' ";
                SqlCommand sqlCommand = new SqlCommand(query, konekcija);

                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.InsertCommand = sqlCommand;
                adapter.InsertCommand.ExecuteNonQuery();
                UcitavanjeStudenata();
                konekcija.Close();
                return 1;
            }
            catch (System.Exception ex)
            {
                return 0;
            }
        }
    }
}
