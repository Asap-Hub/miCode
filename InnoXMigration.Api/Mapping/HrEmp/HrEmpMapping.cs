using AutoMapper;
using InnoXMigration.Application.Dtos.HrEmpDto;
using InnoXMigration.Domain.Models;

namespace InnoXMigration.Api.Mapping.HrEmp
{
    public class HrEmpMapping : Profile
    {
        public HrEmpMapping()
        {
            CreateMap<TblHrEmpDto, TblHrEmp>().ReverseMap();
            CreateMap<UpdateHrEmpDto, TblHrEmp>().ReverseMap();
            CreateMap<TblHrOrgBranch, TblHrOrgBranchDto>().ReverseMap();
            CreateMap<TblHrDept, TblHrDeptsDto>().ReverseMap();
            CreateMap<TblHrUnit, TblHrUnitsDto>().ReverseMap();
        }
    }
  }
