using System;
using Volo.Abp.Domain.Entities.Auditing;

namespace HospitalDbms.Employees.Model;

public class Employee: AuditedAggregateRoot<Guid>{
  public string ServiceNumber { get; set; }
  public string PersonalNumber { get; set; }
  public string LastName { get; set; }
  public string FirstName { get; set; }
  public string OtherName { get; set; }
  public DateTime Dob { get; set; }
  public Guid DepartmentId { get; set; }
  public Guid StationId { get; set; }
  public Guid GradeId { get; set; }

  public Employee(Guid id): base(id)
  {
    
  }
  protected Employee()
  {
    
  }

}