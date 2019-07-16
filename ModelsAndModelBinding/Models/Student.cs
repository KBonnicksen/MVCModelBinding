using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Primitives;

namespace ModelsAndModelBinding.Models
{
    /// <summary>
    /// Represents an indicidual student
    /// </summary>
    public class Student
    {
        public int StudentID { get; set; }

        /// <summary>
        /// Legal first and last name
        /// </summary>
        public string FullName { get; set; }

        /// <summary>
        /// Program the student intends to complete
        /// </summary>
        public string ProgramOfChoice { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public DateTime DateOfBirth { get; set; }
        public string HomeAddress { get; set; }
    }
}
