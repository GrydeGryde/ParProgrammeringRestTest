using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using ParProgrammeringRestTest.Models;

namespace ParProgrammeringRestTest.Managers
{
    public class MusicRecordManager
    {
        private static List<MusicRecord> liste = new List<MusicRecord>
        {
            new MusicRecord{Title = "Bohemian Rhapsody", Artist = "Queen", Duration = 300, PublicationYear = 1975},
            new MusicRecord{Title = "Asmus Sang", Artist = "Asmus", Duration = 170, PublicationYear = 2021}
        };

        public List<MusicRecord> GetAllRecords()
        {
            return new List<MusicRecord>(liste);
        }
    }
}
