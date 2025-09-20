using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Models
{
    internal class Employee
    {
        public int Id { get; set; }

      // public numeric / string / Guid => as name ID or name classId
      // take it as primary key and identity
        public string ? Name { get; set; } 
        // reference datatype => nvarchar allow null
        
         public int ? Emp_Age { get; set; } 
        // value tupe => int not allow null

        public decimal ? Emp_Salary { get; set; }  
        
        // value type => decimal not allow null




    }
}
