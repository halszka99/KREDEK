using AutoMapper;
using HalszkaCiesielskaZad4.Models.Entities;
using HalszkaCiesielskaZad4.ViewModels;

namespace HalszkaCiesielskaZad4.Infrastructure
{

    public class MapperProfile:Profile
    {
        public MapperProfile()
        {
            CreateMap<Animal, AnimalViewModel>()
            .ForMember(b => b.AnimalClass, opt => opt.MapFrom(src => src.AnimalClass.Name));

            CreateMap<AnimalClass, AnimalClassViewModel>();

            CreateMap<Area, AreaViewModel>();

            CreateMap<Cage, CageViewModel>()
            .ForMember(b => b.AnimalClass, opt => opt.MapFrom(src => src.AnimalClass.Name))
            .ForMember(b => b.Area, opt => opt.MapFrom(src => src.Area.Name));

            CreateMap<Employee, EmployeeViewModel>()
            .ForMember(b => b.Position, opt => opt.MapFrom(src => src.Position.Name));

            CreateMap<Food, FoodViewModel>()
            .ForMember(b => b.AnimalClass, opt => opt.MapFrom(src => src.AnimalClass.Name));

            CreateMap<Position, PositionViewModel>();
        }
    }
}
