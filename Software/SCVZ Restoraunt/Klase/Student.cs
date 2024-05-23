using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollegeRestraunt.classes
{
    public class StudentClass
    {
        public string ID, JMBAG, ImeIprezime;
        public StudentClass(string jmbag, string imeiprezime) { JMBAG = jmbag; ImeIprezime = imeiprezime; }
        public StudentClass(string id, string jmbag, string imeiprezime) { JMBAG = jmbag; ImeIprezime = imeiprezime; ID = id; }
    }


}
