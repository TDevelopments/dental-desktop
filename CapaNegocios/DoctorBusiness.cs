using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace CapaNegocios
{
    public class DoctorBusiness
    {
        DoctorData doctorData = new DoctorData();

        public bool SaveToken(string email, string password)
        {
            return doctorData.SaveToken(email, password);
        }
    }
}
