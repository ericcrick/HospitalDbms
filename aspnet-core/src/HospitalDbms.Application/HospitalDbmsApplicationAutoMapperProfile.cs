using AutoMapper;
using HospitalDbms.Departments.Model;
using HospitalDbms.Departments.Dto;

namespace HospitalDbms;

public class HospitalDbmsApplicationAutoMapperProfile : Profile
{
    public HospitalDbmsApplicationAutoMapperProfile()
    {
        CreateMap<Department,DepartmentDto>();
        CreateMap<CreateUpdateDepartmentDto,Department>();
    }
}
