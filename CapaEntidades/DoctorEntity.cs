using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class DoctorEntity
    {
        private int _id;
        private List<AppointmentEntity> _appointments;
        private AddressEntity _address;
        private string _first_name;
        private string _last_name;
        private Gender _genre;
        private DateTime _birth_date;
        private Identity _identity_type;
        private Role _role;
        private int _identity_number;
        private int _phone_number;
        private int _phone_number2;
        private string _email;
        private string _password;
        private DateTime _created_at;
        private DateTime _updated_at;

        public DoctorEntity(
            int id,
            List<AppointmentEntity> appointments,
            AddressEntity address,
            string first_name,
            string last_name,
            Gender genre,
            DateTime birth_date,
            Identity identity_type,
            Role role,
            int identity_number,
            int phone_number,
            int phone_number2,
            string email,
            string password,
            DateTime created_at,
            DateTime updated_at
        )
        {
            _id = id;
            _appointments = appointments;
            _address = address;
            _first_name = first_name;
            _last_name = last_name;
            _genre = genre;
            _birth_date = birth_date;
            _identity_type = identity_type;
            _role = role;
            _identity_number = identity_number;
            _phone_number = phone_number;
            _phone_number2 = phone_number2;
            _email = email;
            _password = password;
            _created_at = created_at;
            _updated_at = updated_at;
        }

        public int Id { get => _id; set => _id = value; }
        public List<AppointmentEntity> Appointments { get => _appointments; set => _appointments = value; }
        public AddressEntity Address { get => _address; set => _address = value; }
        public string First_name { get => _first_name; set => _first_name = value; }
        public string Last_name { get => _last_name; set => _last_name = value; }
        public Gender Genre { get => _genre; set => _genre = value; }
        public DateTime Birth_date { get => _birth_date; set => _birth_date = value; }
        public Identity Identity_type { get => _identity_type; set => _identity_type = value; }
        public Role Role { get => _role; set => _role = value; }
        public int Identity_number { get => _identity_number; set => _identity_number = value; }
        public int Phone_number { get => _phone_number; set => _phone_number = value; }
        public int Phone_number2 { get => _phone_number2; set => _phone_number2 = value; }
        public string Email { get => _email; set => _email = value; }
        public string Password { get => _password; set => _password = value; }
        public DateTime Created_at { get => _created_at; set => _created_at = value; }
        public DateTime Updated_at { get => _updated_at; set => _updated_at = value; }
    }

    public enum Gender
    {
        Masculino, Femenino, Otro
    }

    public enum Role
    {
        Admin, Practicante
    }

    public enum Identity
    {
        DNI, Pasaporte
    }

}
