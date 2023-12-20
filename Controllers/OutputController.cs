using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace TakingFileAsParameter.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OutputController : ControllerBase
    {
        [HttpGet("getfile")]
        public IActionResult GetFile()
        {
            var downloadFolderPath = "E:\\Aman\\Download";
            var filePath = Path.Combine(downloadFolderPath, "output.json");

            if (System.IO.File.Exists(filePath))
            {
                var fileBytes = System.IO.File.ReadAllBytes(filePath);
                var fileContent = new FileContentResult(fileBytes, "application/octet-stream")
                {
                    FileDownloadName = "output.json"
                };

                return fileContent;
            }
            else
            {
                return NotFound("File not found");
            }
        }
    }

}
