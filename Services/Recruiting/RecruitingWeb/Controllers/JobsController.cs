using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using RecruitingWeb.Models;

namespace RecruitingWeb.Controllers;

public class JobsController : Controller
{
    [HttpGet]
    public IActionResult Index()
    {
        // all jobs can be applied
        return View();
    }
    
    [HttpGet]
    public IActionResult Details(int id)
    {
        // get details
        return View();
    }
    
    [HttpPost]
    public IActionResult Create()
    {
        // only authed and have role / HR ? manager
        // take info from view then save to DB
        return View();
    }
}