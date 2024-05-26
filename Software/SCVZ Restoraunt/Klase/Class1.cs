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


    }
}
