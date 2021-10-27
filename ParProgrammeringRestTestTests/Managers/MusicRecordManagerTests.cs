using Microsoft.VisualStudio.TestTools.UnitTesting;
using ParProgrammeringRestTest.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ParProgrammeringRestTest.Models;

namespace ParProgrammeringRestTest.Managers.Tests
{
    [TestClass()]
    public class MusicRecordManagerTests
    {
        private MusicRecordManager _manager = new MusicRecordManager();
        [TestMethod()]
        public void GetAllRecordsTest()
        {
            Assert.AreEqual(2, _manager.GetAllRecords().Count);
        }

        //[TestMethod()]
        //public void GetByTitleTest()
        //{
        //    Assert.Fail();
        //}

        //[TestMethod()]
        //public void GetByArtistTest()
        //{
        //    Assert.Fail();
        //}

        //[TestMethod()]
        //public void GetByYearTest()
        //{
        //    Assert.Fail();
        //}
    }
}