using Microsoft.AspNetCore.Mvc;

namespace MyFirstApi.Controllers
{
    [ApiController]
    [Route("api/xml")]
    public class XmlController : ControllerBase
    {
        //[HttpPost]
        //[Route("GetXML")]
        //public async Task<IActionResult> GetXML()
        //{
        //    using var reader = new StreamReader(Request.Body);
        //    string xmlContent = await reader.ReadToEndAsync();

        //    if (string.IsNullOrWhiteSpace(xmlContent))
        //    {
        //        return BadRequest("Request body is empty or invalid XML.");
        //    }

        //    return Content(xmlContent, "application/xml");
        //}

        [HttpPost]
        [Route("GetXML")]
        public IActionResult GetXML([FromBody] XmlRequest request)
        {
            if (string.IsNullOrWhiteSpace(request.EntityName) || string.IsNullOrWhiteSpace(request.XmlContent))
            {
                return BadRequest("Entity name or XML content is missing.");
            }

            string response = $"{request.EntityName}\n\n{request.XmlContent}";

            // "text/plain" is better for arbitrary formatting like this
            return Content(response, "text/plain");
        }


    }
}
