using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using RecruitingWeb.Models;

namespace RecruitingWeb.Controllers;

public class CandidatesController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}