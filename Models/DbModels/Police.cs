using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseProject.Models.DbModels
{
    public class Police
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public int IdAgent { get; set; }
        public int Number { get; set; }
        public int IdCustomer { get; set; }
        public DateTime Validity { get; set; }
    }
}
