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

        #region Cushion
        public static CushionViewModel ToViewModel(this Cushion entity)
        {
            return entity.MapTo<Cushion, CushionViewModel>();
        }
        #endregion
    }
}