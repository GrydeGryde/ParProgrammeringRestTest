using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ParProgrammeringRestTest.Managers;

namespace ParProgrammeringRestTest.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MusicRecordController
    {
        private readonly MusicRecordManager manager = new MusicRecordManager();

    }
}
