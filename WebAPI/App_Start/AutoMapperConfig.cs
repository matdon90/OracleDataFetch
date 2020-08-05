using WebAPI.Infrastructure.Mapper;

namespace WebAPI.App_Start
{
    public class AutoMapperConfig
    {
        public static void AutoMapperRegister()
        {
            new AutoMapperStartupTask().Execute();
        }
    }
}