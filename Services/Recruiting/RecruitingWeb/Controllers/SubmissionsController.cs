﻿using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using RecruitingWeb.Models;

namespace RecruitingWeb.Controllers;

public partial class SubmissionsController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}