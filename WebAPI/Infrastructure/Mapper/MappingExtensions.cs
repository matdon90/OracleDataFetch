using DAL.Models;
using WebAPI.ViewModels;

namespace WebAPI.Infrastructure.Mapper
{
    public static class MappingExtensions
    {
        public static TDestination MapTo<TSource, TDestination>(this TSource source)
        {
            return AutoMapperConfiguration.Mapper.Map<TSource, TDestination>(source);
        }

        public static TDestination MapTo<TSource, TDestination>(this TSource source, TDestination destination)
        {
            return AutoMapperConfiguration.Mapper.Map<TSource, TDestination>(source, destination);
        }

        #region BearingChokes
        public static BearingChokesViewModel ToViewModel(this BearingChokes entity)
        {
            return entity.MapTo<BearingChokes, BearingChokesViewModel>();
        }
        #endregion
    }
}