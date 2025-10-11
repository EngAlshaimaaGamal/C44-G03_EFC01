using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Models
{

    [Table("Employees")]
    internal class Employee
    {
        [Key]
         public int EmpId { get; set; }

        //[MaxLength(50 ,ErrorMessage =" not allowed")] // mapping in Database as nvarchar(50)
        //[MinLength(3)] // appplicayion validation
        //[Length(50,3)] // appplicayion validation
        [StringLength(50 , MinimumLength = 3, ErrorMessage ="Not Allowed" )]
        public string? EmpName { get; set; }

       // [Precision(10,2)]
        [Column( TypeName = "decimal(10,2)")]
        public decimal Salary { get; set; }



        [Range(22,40)] // Application validation  

        [AllowedValues(24,26,28,30)] // Application validation  
        public int Age { get; set; }



        //[DataType(DataType.EmailAddress)] // Ui hint to [font end] 
        [Required]
        [EmailAddress]  // Application validation   
        public string Email { get; set; }


        [DataType(DataType.Password)]

        public string Password { get; set; }


        [Required]
        [Phone]  // Application validation  
        public string PhoneNumber { get; set; }


        [NotMapped]
        public string UserName => Email.Split('@')[0];
        
        
      







        #region By convention
        //public int Id { get; set; }

        //// public numeric / string / Guid => as name ID or name classId
        //// take it as primary key and identity
        //public string? Name { get; set; }
        //// reference datatype => nvarchar allow null

        //public int? Emp_Age { get; set; }
        //// value tupe => int not allow null

        //public decimal? Emp_Salary { get; set; }

        //// value type => decimal not allow null



        #endregion




    }
}
