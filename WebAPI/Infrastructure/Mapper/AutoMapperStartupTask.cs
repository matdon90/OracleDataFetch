namespace WebAPI.Infrastructure.Mapper
{
    public class AutoMapperStartupTask
    {
        public void Execute()
        {
            AutoMapperConfiguration.Init();
        }
    }
}