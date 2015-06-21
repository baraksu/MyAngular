using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DAL;

namespace MyTests
{
    [TestClass]
    public class DalTests
    {
        [TestMethod]
        public void GetApatrment()
        {
            IDataRepository dataRepository = new DataRepository();

            var appatments= dataRepository.GetAppartments();

            Assert.IsNotNull(appatments, "No Data from the repository");
            
        }
    }
}
