using System;
using Core.Domain.Ddd;
using JobFinder.Domain.Professions.Entities;

namespace JobFinder.Domain.JobApplications.Entities
{
  public class JobApplicationSkill : Entity
  {
    public Guid JobApplicationId { get; private set; }
    public ProposedSkill Skill { get; private set; }
    public int Level { get; private set; }
    protected JobApplicationSkill() : base(Guid.Empty) { }
    protected JobApplicationSkill(Guid id,
      Guid jobApplicationId,
      ProposedSkill skill,
      int level) : base(id)
    {
      JobApplicationId = jobApplicationId;
      Skill = skill;
      Level = level;
    }

    public static JobApplicationSkill Create(Guid id,
      Guid jobApplicationId,
      ProposedSkill skill,
      int level) => new JobApplicationSkill(id, jobApplicationId, skill, level);
  }
}
