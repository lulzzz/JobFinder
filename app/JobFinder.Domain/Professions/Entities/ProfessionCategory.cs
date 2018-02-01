using System;
using System.Collections.Generic;
using Core.Domain.Ddd;

namespace JobFinder.Domain.Professions.Entities
{
  public class ProfessionCategory : AggregateRoot
  {
    public string Name { get; set; }
    public virtual ICollection<ProposedCertificate> ProposedCertificates { get; set; }
    protected ProfessionCategory() : base(Guid.Empty)
    {

    }

    protected ProfessionCategory(Guid id,
                                string name,
                                ICollection<ProposedCertificate> proposedCertificates) : base(id)
    {
      Name = name;
      ProposedCertificates = proposedCertificates;
    }

    public static ProfessionCategory Create(Guid id,
                                string name,
                                ICollection<ProposedCertificate> proposedCertificates)
    {
      return new ProfessionCategory(id, name, proposedCertificates);
    }

    public void AddProposedCertificate(ProposedCertificate certificate)
    {
      ProposedCertificates.Add(certificate);
    }
  }
}
