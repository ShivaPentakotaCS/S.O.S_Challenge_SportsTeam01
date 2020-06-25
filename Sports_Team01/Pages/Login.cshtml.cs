﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;


namespace Sports_Team01
{
    [BindProperties]
    public class LoginModel : PageModel
    {
        public string SessionStatus_Name { get; set; }
        public string Message { get; set; }
        public string MessageColor { get; set; }

        public string radUser { get; set; }


        [Display(Name = "Email Address")]
        [Required(ErrorMessage = "Email address is required. Please enter a valid email address.")]
        [StringLength(50)]
        public string EmailAddress { get; set; }

        [Display(Name = "Password")]
        [Required(ErrorMessage = "Password is required. Please enter a valid password.")]
        [StringLength(8)]
        public string Password { get; set; }




        public void OnGet()
        {

            ////Initialize the header data.
            //ViewData["Page"] = "Login";
            //ViewData["User"] = HttpContext.Session.GetString("User");
            //ViewData["Status"] = HttpContext.Session.GetString("Status");
            //ViewData["MessageColor"] = HttpContext.Session.GetString("MessageColor");
            //ViewData["Message"] = HttpContext.Session.GetString("Message");

            //MessageColor = "Blue";
            //Message = "Please select the appropriate user type to login and retrieve password.";

        }
    }
}