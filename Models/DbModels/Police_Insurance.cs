using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CourseProject.Models.DbModels
{
    public class Police_Insurance
    {
        [Key]
        public int IdPolicy { get; set; }
        
        public int IdInsurance { get; set; }
    }
}
