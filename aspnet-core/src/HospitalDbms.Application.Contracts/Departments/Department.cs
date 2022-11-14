using System;
using System.ComponentModel.DataAnnotations;
using Volo.Abp.Application.Dtos;

namespace HospitalDbms.Departments;

public class CreateDepartmentDto: AuditedEntityDto<Guid>{
  [Required]
  [StringLength(128)]
  public string DepartmentName { get; set; }
  [StringLength(128)]
  public string DepartmentHead { get; set; }
  public string DepartmentTelephone { get; set;}
  public string DepartmentMail { get; set;}
}