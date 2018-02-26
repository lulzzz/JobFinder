using System;
using System.Collections.Generic;
using Core.Application.Api.Messages;
namespace JobFinder.Application.Api.JobApplications.Queries
{
  public class GetRecommendedApplicationListResult : QueryResult
  {
    public IEnumerable<RecommendedJobApplicationDto> RecommendedJobApplications { get; set; }
    public GetRecommendedApplicationListResult(IEnumerable<RecommendedJobApplicationDto> recommendedJobApplications)
    {
      RecommendedJobApplications = recommendedJobApplications;
    }
    public class RecommendedJobApplicationDto
    {
      public Guid Id { get; set; }
      public string Name { get; set; }
      public string Surname { get; set; }
      public string Profession { get; set; }
      public string ProfessionCategory { get; set; }
      public decimal RequiredSalary { get; set; }
      public double Score { get; set; }
      public RecommendedJobApplicationDto(Guid id,
        string name,
        string surname,
        string profession,
        string professionCategory,
        decimal requiredSalary,
        double score)
      {
        Id = id;
        Name = name;
        Surname = surname;
        Profession = profession;
        ProfessionCategory = professionCategory;
        RequiredSalary = requiredSalary;
        Score = score;
      }
    }
  }
}
