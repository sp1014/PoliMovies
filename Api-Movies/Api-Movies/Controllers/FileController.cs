﻿using Microsoft.AspNetCore.Mvc;
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
using Api_Movies.Core.FileManager;

namespace Api_Movies.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FileController : ControllerBase
    {

        private readonly IWebHostEnvironment _env;
        private readonly UsersContext _context;
        private readonly IFileManager _fileManager;

        public FileController(IWebHostEnvironment env, UsersContext context, IFileManager fileManager)
        {
            _env = env;
            _context = context;
            _fileManager = fileManager;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        /// 
        [AllowAnonymous]
        [HttpGet("{id}")]
        public async Task<ActionResult> GetById(int id)
        {
            var ordenResult = await _fileManager.GetByIdAsync(id);
            if (ordenResult.Success)
            {
                return Ok(ordenResult.Value);
            }
            return NotFound(ordenResult.Errors);
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
            return Ok(RutaCompleta);

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="NombreArchivo"></param>
        /// <param name="RutaCompleta"></param>
        /// <returns></returns>

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

        [AllowAnonymous]
        [HttpGet]
        public async Task<ActionResult> GetAll()
        {
            var usersResult = await _fileManager.GetFilesAsync();
            if (usersResult.Success)
            {
                return Ok(usersResult.Value);
            }
            return NotFound(usersResult.Errors);
        }

    }
}
