﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Sports_Team01.Pages
{
    public class ColtsSuperbowlModel : PageModel
    {
        public void OnGet()
        {
            //Initialize the header data.
            ViewData["Status"] = HttpContext.Session.GetString("Status");
            ViewData["Page"] = "Super Bowl XLI";
            ViewData["User"] = HttpContext.Session.GetString("User");
            ViewData["MessageColor"] = HttpContext.Session.GetString("MessageColor");
            ViewData["Message"] = HttpContext.Session.GetString("Message");
        }
    }
}