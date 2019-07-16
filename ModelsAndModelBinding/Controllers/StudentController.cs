using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ModelsAndModelBinding.Models;

//Controllers are for routing user input and information
namespace ModelsAndModelBinding.Controllers
{
    public class StudentController : Controller
    {
        //Default (get request) (when you go to a url and the server sends you something back)
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        //When data is posted to /Student/Register, this action will execute
        [HttpPost]
        public IActionResult Register(IFormCollection data)
        {
            //Validate input (lots of work!)
            //Server side and client side
            //Add error message on page to notify user

            Student stu = new Student()
            {
                FullName = data["full-name"],
                ProgramOfChoice = data["program"],
                DateOfBirth = Convert.ToDateTime(data["dob"]),
                HomeAddress = data["address"]
            };

            //Add to database
            return View();
        }

        //Registration done with Model Binding
        [HttpGet]
        public IActionResult RegisterMB()
        {
            return View();
        }

        [HttpPost] //Take a student as a parameter so that it can do model binding
        public IActionResult RegisterMB(Student s)
        {
            //Verifies all data annotations in the class are valid
            if (ModelState.IsValid)
            {
                //Add to database
                SudentDB.Register(s);

                //Display thank you/success message
                ViewData["Success"] = "Student was successfully registered!";
            }
            return View();
        }
    }
}