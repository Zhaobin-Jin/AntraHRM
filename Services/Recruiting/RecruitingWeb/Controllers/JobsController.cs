using System.Diagnostics;
using ApplicationCore.Contracts.Services;
using Infrastructure.Services;
using Microsoft.AspNetCore.Mvc;
using RecruitingWeb.Models;

namespace RecruitingWeb.Controllers;

public class JobsController : Controller
{
    private IJobsService _jobService;
    public JobsController(IJobsService jobService)
    {
        _jobService = jobService;
    }
    [HttpGet]
    public IActionResult Index()
    {
        // all jobs can be applied
        
        var jobs = _jobService.GetAllJobs();
        return View();
    }
    
    [HttpGet]
    public IActionResult Details(int id)
    {
        // get details
        
        var jobs = _jobService.GetJobById(4);
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