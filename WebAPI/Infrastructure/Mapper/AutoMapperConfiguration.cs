using AutoMapper;
using DAL.Models;
using WebAPI.ViewModels;

namespace WebAPI.Infrastructure.Mapper
{
    public static class AutoMapperConfiguration
    {
        public static IMapper Mapper { get; set; }
        public static MapperConfiguration mapperConfiguration;

        public static void Init()
        {
            mapperConfiguration = new MapperConfiguration(cfg =>
            {
                #region BearingChokes
                cfg.CreateMap<BearingChokes, BearingChokesViewModel>();
                cfg.CreateMap<BearingChokesViewModel, BearingChokes>();
                #endregion
            });

            Mapper = mapperConfiguration.CreateMapper();
        }
    }
}