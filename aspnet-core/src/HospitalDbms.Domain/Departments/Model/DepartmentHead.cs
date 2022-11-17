using System;
using Volo.Abp.Domain.Entities.Auditing;

namespace HospitalDbms.Departments.Model;

public class DepartmentHead: AuditedAggregateRoot<Guid>{
  public Guid EmployeeId { get; set; }
  public Guid DepartmentId { get; set; }
  public Guid DesignationId { get; set; }
}