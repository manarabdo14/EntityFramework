using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF01.Entities
{
    // entity  model 
    //poco class => plain old clr object
    #region By Convention
    //internal class Employee
    //{
    //    public int Id { get; set; }
    //    public string EmpName { get; set; }
    //    public decimal Salary   { get; set; }
    //    public int? Age { get; set; }

    //    public string Address { get; set; }

    //}
    #endregion


    #region Data annotaion 

    internal class Employee
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int EmpId { get; set; }
        [Required]
        [StringLength(50)]
        [Column(TypeName ="varchar")]
        public string EmpName { get; set; }
        //[Column(TypeName = "Money")]
        [DataType(DataType.Currency)]
        public decimal Salary { get; set; }
        [Range(22,60)]
        public int? Age { get; set; }
        [DataType(DataType.EmailAddress)]
        //[EmailAddress]
        public string Email { get; set; }
        [DataType(DataType.PhoneNumber)]
        public string phoneNum { get; set; }
        [DataType(DataType.Password)]
        public string password { get; set; }
        
        [ForeignKey("department")]
        public int? departmentId { get; set; }
        public Department department { get; set; }
    }
    #endregion
}
