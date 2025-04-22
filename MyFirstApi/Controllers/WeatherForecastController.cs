using Microsoft.AspNetCore.Mvc;

namespace MyFirstApi.Controllers
{
    [ApiController]
    [Route("api/xml")]
    public class XmlController : ControllerBase
    {
        [HttpPost]
        public IActionResult PostXml([FromBody] XmlData XmlData)
        {
            if (XmlData == null || string.IsNullOrEmpty(XmlData.Content))
            {
                return BadRequest("Invalid XML Data");
            }

            return Ok(XmlData.Content);
        }
    }
}
