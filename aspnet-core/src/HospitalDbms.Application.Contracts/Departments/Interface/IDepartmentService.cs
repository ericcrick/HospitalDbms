using System;
using System.Threading.Tasks;
using HospitalDbms.Departments.Dto;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace HospitalDbms.Departments.Interface;

public interface IDepartmentService: 
ICrudAppService<
DepartmentDto, 
Guid, 
PagedAndSortedResultRequestDto, 
CreateUpdateDepartmentDto>,
IApplicationService
{
  public Task<long> GetDepartmentRecordCount(); 
}