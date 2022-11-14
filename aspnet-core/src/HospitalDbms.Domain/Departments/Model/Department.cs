using System;
using Volo.Abp.Domain.Entities.Auditing;

namespace HospitalDbms.Departments.Model ;

public class Department: AuditedAggregateRoot<Guid>{

  public string DepartmentName { get; set; }
  public string DepartmentHead { get; set; }
  public string DepartmentTelephone { get; set;}
  public string DepartmentMail { get; set;}
}