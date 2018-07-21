namespace Exam.Application.Dto.Common
{
    using AutoMapper;
    using Exam.Application.Dto.Students;
    using Exam.Domain.Entity.Students;
    using System;

    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<Student, StudentDto>()
            .ForMember(destination => destination.ScholarShip,
                    opts => opts.MapFrom(source => source.CalculateScholarship()))
             .ForMember(destination => destination.DegreeType,
                    opts => opts.MapFrom(source => Enum.GetName(typeof(DegreeType), source.DegreeType)));

            CreateMap<StudentPreGrado, StudentPreGradoDto>()
           .ForMember(destination => destination.ScholarShip,
                   opts => opts.MapFrom(source => source.CalculateScholarship()))
            .ForMember(destination => destination.DegreeType,
                   opts => opts.MapFrom(source => Enum.GetName(typeof(DegreeType), source.DegreeType)));

            CreateMap<StudentMaestria, StudentMaestriaDto>()
           .ForMember(destination => destination.ScholarShip,
                   opts => opts.MapFrom(source => source.CalculateScholarship()))
            .ForMember(destination => destination.DegreeType,
                   opts => opts.MapFrom(source => Enum.GetName(typeof(DegreeType), source.DegreeType)));

            CreateMap<StudentDoctorado, StudentDoctoradoDto>()
           .ForMember(destination => destination.ScholarShip,
                   opts => opts.MapFrom(source => source.CalculateScholarship()))
            .ForMember(destination => destination.DegreeType,
                   opts => opts.MapFrom(source => Enum.GetName(typeof(DegreeType), source.DegreeType)));

        }
    }
}