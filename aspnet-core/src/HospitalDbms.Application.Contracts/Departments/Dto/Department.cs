using System;
using Volo.Abp.Application.Dtos;

namespace HospitalDbms.Departments.Dto;

public class DepartmentDto: AuditedEntityDto<Guid>{
  public string DepartmentName { get; set; }
  public string DepartmentHead { get; set; }
  public string DepartmentTelephone { get; set;}
  public string DepartmentMail { get; set;}
}