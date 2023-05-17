using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using RecruitingWeb.Models;

namespace RecruitingWeb.Controllers;

public class JobRequirementController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}