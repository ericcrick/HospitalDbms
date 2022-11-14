using System;
using System.ComponentModel.DataAnnotations;
using Volo.Abp.Application.Dtos;

namespace HospitalDbms.Departments;

public class CreateDepartmentDto: AuditedEntityDto<Guid>{
  [Required]
  public string DepartmentName { get; set; }
  public string DepartmentHead { get; set; }
  public string DepartmentTelephone { get; set;}
  public string DepartmentMail { get; set;}
}