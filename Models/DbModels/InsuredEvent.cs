using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseProject.Models.DbModels
{
    public class InsuredEvent
    {
        public int IdCustomer { get; set; }
        public DateTime Date { get; set; }
        public int IdPolicy { get; set; }
        public int Id { get; set; }
        public int InsureType { get; set; }
    }
}
