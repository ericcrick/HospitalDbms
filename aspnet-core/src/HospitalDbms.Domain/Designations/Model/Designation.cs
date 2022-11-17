using System;
using Volo.Abp.Domain.Entities.Auditing;

namespace HospitalDbms.Designations.Model;

public class Designation: AuditedAggregateRoot<Guid>{
  public string DesignationName { get; set; }
  
  public Designation(Guid id): base(id)
  {
    
  }

  protected Designation()
  {
    
  }
}