using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssEF01.Entities
{
    internal class Instructor
    {
        [Key]
        public int ID { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        public double Bonus { get; set; }
        public double Salary { get; set; }

        [MaxLength(200)]
        public string Address { get; set; }

        public double HourRate { get; set; }

        [ForeignKey("Department")]
        public int Dept_ID { get; set; }

        public Department Department { get; set; }
        public ICollection<Course_Inst> Course_Insts { get; set; } = new List<Course_Inst>();
    }
}
