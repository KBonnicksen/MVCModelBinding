using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        [Required(ErrorMessage = "*Required")]
        [Display(Name = "First and Last Name")]
        public string FullName { get; set; }

        /// <summary>
        /// Program the student intends to complete
        /// </summary>
        [Required(ErrorMessage = "*Required")]
        [Display(Name = "Program")]
        public string ProgramOfChoice { get; set; }

        /// <summary>
        /// Date that the student was born
        /// </summary>
        [DataType(DataType.Date)] //date input will be generated in the browser
        public DateTime DateOfBirth { get; set; }

        //Max 30 chars just for demo
        [StringLength(30, MinimumLength = 10)] //Will only run if a value is given (still optional)
        public string HomeAddress { get; set; }
    }
}
