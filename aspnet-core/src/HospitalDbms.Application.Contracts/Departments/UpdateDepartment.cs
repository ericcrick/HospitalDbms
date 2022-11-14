using System.ComponentModel.DataAnnotations;

namespace HospitalDbms.Departments;

public class UpdateDepartmentDto{
  [Required]
  [StringLength(128)]
  public string DepartmentName { get; set; }
  [StringLength(128)]
  public string DepartmentHead { get; set; }
  public string DepartmentTelephone { get; set;}
  public string DepartmentMail { get; set;}
}