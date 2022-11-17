using System;
using Volo.Abp.Domain.Entities.Auditing;

public class Grade: AuditedAggregateRoot<Guid>{
  public string GradeName { get; set; }
}