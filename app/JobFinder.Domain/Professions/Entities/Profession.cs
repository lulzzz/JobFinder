using System;
using System.Collections.Generic;
using Core.Domain.Ddd;

namespace JobFinder.Domain.Professions.Entities
{
  public class Profession : AggregateRoot
  {
    public string Name { get; private set; }
    public ProfessionCategory Category { get; private set; }
    public virtual ICollection<ProposedSkill> ProposedSkills { get; private set; }
    protected Profession() : base(Guid.Empty) { }
    protected Profession(Guid id,
      string name,
      ProfessionCategory category,
      ICollection<ProposedSkill> proposedSkills) : base(id)
    {
      Name = name;
      Category = category;
      ProposedSkills = proposedSkills;
    }
    public void AddProposedSkill(ProposedSkill skill)
      => ProposedSkills.Add(skill);
    public static Profession Create(Guid id,
      string name,
      ProfessionCategory category,
      ICollection<ProposedSkill> proposedSkills)
        => new Profession(id, name, category, proposedSkills);
  }
}
