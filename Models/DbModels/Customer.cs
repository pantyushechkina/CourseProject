using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseProject.Models.DbModels
{
    public class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateBirth { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string Passport { get; set; }

        public Customer(string fn, string ln, DateTime date, string phone, string address, string passport)
        {
            FirstName = fn;
            LastName = ln;
            DateBirth = date;
            PhoneNumber = phone;
            Address = address;
            Passport = passport;
        }
        public Customer() { }
    }
}
