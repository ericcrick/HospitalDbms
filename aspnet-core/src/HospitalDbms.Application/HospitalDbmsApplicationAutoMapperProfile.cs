using AutoMapper;
using HospitalDbms.Departments;

namespace HospitalDbms;

public class HospitalDbmsApplicationAutoMapperProfile : Profile
{
    public HospitalDbmsApplicationAutoMapperProfile()
    {
        CreateMap<Department,CreateDepartmentDto>();
    }
}
