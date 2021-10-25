using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ParProgrammeringRestTest.Managers;
using ParProgrammeringRestTest.Models;

namespace ParProgrammeringRestTest.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MusicRecordController
    {
        private readonly MusicRecordManager _manager = new MusicRecordManager();

        [HttpGet]
        public IEnumerable<MusicRecord> GetAll()
        {
            return _manager.GetAllRecords();
        }
    }
}
