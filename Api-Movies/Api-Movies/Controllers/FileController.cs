using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using Api_Movies.Models;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System;
using Microsoft.AspNetCore.Authorization;
using Api_Movies.Core.LoginManager;

using System.IO;
using Microsoft.AspNetCore.Hosting;
using Api_Movies.Helpers;
using File = Api_Movies.Models.File;

namespace Api_Movies.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FileController : ControllerBase
    {

        private readonly IWebHostEnvironment _env;
        private readonly UsersContext _context;

        public FileController(IWebHostEnvironment env, UsersContext context)
        {
            _env = env;
            _context = context;
         
        }

        [HttpPost, Route("cargar-archivo")]

      
            public async Task<ActionResult> UploadFile()
            {
            var file = Request.Form.Files[0];
            string NombreCarpeta = "/Archivos/";
            string RutaRaiz = _env.ContentRootPath;
            string RutaCompleta = RutaRaiz + NombreCarpeta;      
            if (!Directory.Exists(RutaCompleta))
            {
                Directory.CreateDirectory(RutaCompleta);
            }

            if (file.Length > 0)
            {
                string NombreArchivo = file.FileName;

                string RutaFullCompleta = Path.Combine(RutaCompleta, NombreArchivo);
                using (var stream = new FileStream(RutaFullCompleta, FileMode.Create))
                {
                    file.CopyTo(stream);

                }
                await Post(NombreArchivo, RutaCompleta);

            }

            //Se retorna la variable "resultado" como resultado de una tarea
            return Ok(RutaCompleta);

        }

        [HttpPost]
        public async Task<ActionResult> Post(string NombreArchivo, string RutaCompleta)
        {

            var resultado = new ResultHelper<File>();
            try
            {
                File nuevaDoc = new File

                {
                   Name = NombreArchivo,
                   Archivo = RutaCompleta
                };
                _context.Files.Add(nuevaDoc);
                await _context.SaveChangesAsync();
                resultado.Value = nuevaDoc;
            }
            catch (Exception e)
            {
                resultado.AddError(e.Message);
            }
            return Ok(resultado);
        }

        /*public async Task<ActionResult> Post(File file)
        {
            var result = await _fileManager.CreateAsync(file);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Errors);
        }*/

    }
}
