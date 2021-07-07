using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PDFGenerator.Domain.Entities;

namespace PDFGenerator.App.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PDFController : ControllerBase
    {
        [HttpPost]
        [Route("Generate")]
        public async Task<ActionResult<string>> Generate([FromBody] PDFData data)
        {
            if(!ModelState.IsValid)
                return BadRequest();

            return await Task.Run(() =>
                Ok(data.Name)
            );
        }
    }
}
