using EFCoreKeylessEntityTypes.Database;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace EFCoreKeylessEntityTypes.Controllers
{
    [ApiController, Route("[controller]")]
    public class DatabaseController : ControllerBase
    {
        private readonly AppDbContext _ctx;

        public DatabaseController(AppDbContext ctx)
        {
            _ctx = ctx;
        }

        [HttpGet, Route("[action]")]
        public async Task<IActionResult> AvailablePartsforRackBuild(string qNumber)
        {
            return Ok(_ctx.AvailableParts.FromSqlRaw("EXEC [dbo].[AvailablePartsforRackBuild] {0}", qNumber));

            //The same of:
            //return Ok(_ctx.AvailableParts.FromSqlInterpolated($"EXEC [dbo].[AvailablePartsforRackBuild] {qNumber}"));
        }
    }
}