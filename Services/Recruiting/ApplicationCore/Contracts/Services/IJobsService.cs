using ApplicationCore.Models;

namespace ApplicationCore.Contracts.Services;

public interface IJobsService
{
    List<JobResponseModel> GetAllJobs();

    JobResponseModel GetJobById(int id);
}