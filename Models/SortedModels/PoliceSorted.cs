using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseProject.Models.SortedModels
{
    public class PoliceSorted
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string Agent { get; set; }
        public int Number { get; set; }
        public string Customer { get; set; }
        public DateTime Validity { get; set; }
    }
}
