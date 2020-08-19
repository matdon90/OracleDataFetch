using DAL.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using WebAPI.Infrastructure.Mapper;
using WebAPI.ViewModels;

namespace WebAPI.Controllers
{
    /// <summary>
    /// Api controller for cushions.
    /// </summary>
    public class CushionsController : ApiController
    {
        private readonly ICushionsData _context;
        /// <summary>
        /// Constructor with database context injected.
        /// </summary>
        /// <param name="context"></param>
        public CushionsController(ICushionsData context)
        {
            _context = context;
        }

        /// <summary>
        /// Action fetching all cushions numbers from database.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IEnumerable<CushionViewModel> List()
        {
            return _context.GetAllInstalledCushions().Select(m => m.ToViewModel());
        }

        /// <summary>
        /// Action fetching cushions numbers for one roll
        /// </summary>
        /// <param name="standNumber"></param>
        /// <param name="position"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("api/cushions/{standNumber}/{position}")]
        public CushionViewModel Get(int standNumber, string position)
        {
            return _context.GetInstalledCushionByPosition(standNumber, position).ToViewModel();
        }
    }
}