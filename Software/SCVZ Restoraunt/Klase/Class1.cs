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
    }
}
