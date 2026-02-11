using Microsoft.VisualStudio.TestTools.UnitTesting;
using StrandC_OSZTV;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrandC_OSZTV.Tests
{
    [TestClass()]
    public class FurdoTests
    {
        Furdo furdo;

        [TestMethod()]
        [DataRow("Gyulai Várfürdő;5700 Gyula, Várfürdő u. 1.;6000;36", "Gyula")]
        [DataRow("Harkányi Gyógyfürdő;7815 Harkány, Járó József u. 1.;7100;38", "Harkány")]
        public void TelepulesTrueTest(string adat, string expected)
        {
            furdo = new Furdo(adat);
            string actual = furdo.Telepules();
            Assert.AreEqual(expected, actual);
            
        }

        [TestMethod()]
        [DataRow("Gyulai Várfürdő;5700 Gyula, Várfürdő u. 1.;6000;36", "Gyula,")]
        [DataRow("Harkányi Gyógyfürdő;7815     Harkány, Járó József u. 1.;7100;38", "Harkány")]
        public void TelepulesFalseTest(string adat, string expected)
        {
            furdo = new Furdo(adat);
            string actual = furdo.Telepules();
            Assert.AreNotEqual(expected, actual);
            Assert.ThrowsException<FormatException>(
                () => furdo.Telepules()
                );
        }

        [TestMethod()]
        
        [DataRow("Harkányi Gyógyfürdő;a;7100;38", "Harkány")]
        public void TelepulesExceptionTest(string adat, string expected)
        {
            furdo = new Furdo(adat);
            string actual = furdo.Telepules();
            
            Assert.ThrowsException<IndexOutOfRangeException>(
                () => furdo.Telepules()
                );
        }
    }
}