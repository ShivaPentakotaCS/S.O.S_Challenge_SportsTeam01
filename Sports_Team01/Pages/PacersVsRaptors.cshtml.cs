﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Sports_Team01.Pages
{
    public class PacersVsRaptorsModel : PageModel
    {
        public void OnGet()
        {
            //Initialize the header data.
            ViewData["Status"] = HttpContext.Session.GetString("Status");
            ViewData["Page"] = "Pacers Vs. Raptors 2016 Playoffs First Round Game 6 ";
            ViewData["User"] = HttpContext.Session.GetString("User");
            ViewData["MessageColor"] = HttpContext.Session.GetString("MessageColor");
            ViewData["Message"] = HttpContext.Session.GetString("Message");
        }
    }
}