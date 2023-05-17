using ApplicationCore.Contracts.Services;
using ApplicationCore.Models;

namespace Infrastructure.Services;

public class JobService: IJobsService
{
    public List<JobResponseModel> GetAllJobs()
    {
        // dummy here!
        var jobs = new List<JobResponseModel>()
        {
            new JobResponseModel{Id = 1, Title = "Test job title", Description = "Test dec"},
            new JobResponseModel{Id = 2, Title = "Test job title2", Description = "Test dec2"},
            new JobResponseModel{Id = 3, Title = "Test job title3", Description = "Test dec3"},
            new JobResponseModel{Id = 4, Title = "Test job title4", Description = "Test dec4"}
        };

        return jobs;
    }

    public JobResponseModel GetJobById(int id)
    {
        return new JobResponseModel {Id = 4, Title = "Test job title4", Description = "Test dec4" } ;
    }
}