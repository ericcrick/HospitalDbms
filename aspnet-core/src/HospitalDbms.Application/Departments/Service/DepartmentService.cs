using System;
using System.Threading.Tasks;
using HospitalDbms.Departments.Dto;
using HospitalDbms.Departments.Interface;
using HospitalDbms.Departments.Model;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace HospitalDbms.Departments.Service;

public class DepartmentService :
CrudAppService<
Department,
DepartmentDto,
Guid,
PagedAndSortedResultRequestDto,
CreateUpdateDepartmentDto>,
IDepartmentService
{
  public DepartmentService(IRepository<Department,Guid> repository): base(repository)
  {
    
  }
}