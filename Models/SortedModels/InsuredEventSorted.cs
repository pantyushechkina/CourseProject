using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseProject.Models.SortedModels
{
    public class InsuredEventSorted
    {
        public string Customer { get; set; }
        public DateTime Date { get; set; }
        public int IdPolicy { get; set; }
        public int Id { get; set; }
        public string InsureType { get; set; }
    }
}
