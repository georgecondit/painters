using System;
using System.Collections.Generic;
using painters.Models;
using painters.Services;
using Microsoft.AspNetCore.Mvc;

namespace painters.Controllers
{
    public class PaintersController
    {
        [ApiController]
        [Route("api/[controller]")]
        public class PaintersController : ControllerBase
        {
            private readonly PaintersService _service;

            public PaintersController(PaintersService service)
            {
                _service = service;
            }
        }

        [HttpGet]
        public ActionResult<IEnumerable<Painter>> Get()
        {
            try
            {
                return Ok(_service.Get())
            }
            catch (Exception e)
            {
                
                return BadRequest(e.Message)
            }
        }
    }

}