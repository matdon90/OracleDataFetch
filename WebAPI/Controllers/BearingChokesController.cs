using DAL.Interfaces;
using System.Linq;
using System.Web.Http;
using WebAPI.Infrastructure.Mapper;
using WebAPI.ViewModels;

namespace WebAPI.Controllers
{
    /// <summary>
    /// Api controller for bearing chokes.
    /// </summary>
    public class BearingChokesController : ApiController
    {
        private readonly IBearingChokesData _context;

        /// <summary>
        /// Constructor with database context injected.
        /// </summary>
        /// <param name="context"></param>
        public BearingChokesController(IBearingChokesData context)
        {
            _context = context;
        }

        /// <summary>
        /// Action fetching bearing chokes from database.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public BearingChokesViewModel Get()
        {
            return _context.GetInstalledBearingChokes().First().ToViewModel();
        }
    }
}