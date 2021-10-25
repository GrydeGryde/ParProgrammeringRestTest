using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ParProgrammeringRestTest.Managers;
using ParProgrammeringRestTest.Models;

namespace ParProgrammeringRestTest.Controllers
{
    [ApiController]
    [Route("Music")]
    public class MusicRecordController
    {
        private readonly MusicRecordManager _manager = new MusicRecordManager();

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [HttpGet]
        public IEnumerable<MusicRecord> GetAll()
        {
            return _manager.GetAllRecords();
        }
    }
}
