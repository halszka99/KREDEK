using AutoMapper;
using HalszkaCiesielskaZad4.Infrastructure;
using HalszkaCiesielskaZad4.Models;

namespace HalszkaCiesielskaZad4
{
    /// <summary>
    /// Abstract class with methods all repositories should have
    /// </summary>
    public abstract class Repository
    {
        // variable to storage database context
        protected readonly DataBaseContext DbContext = new DataBaseContext();
        // mapper configuration variable
        private static MapperConfiguration MapperConfig = new MapperConfiguration(cfg => cfg.AddProfile(new MapperProfile()));
        // mapper variable
        protected readonly IMapper Mapper = MapperConfig.CreateMapper();
    }
}
