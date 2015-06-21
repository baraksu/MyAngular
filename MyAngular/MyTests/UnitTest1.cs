using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DAL;
using System.Linq;

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


            
            Assert.IsTrue(appatments.Count()>0, "No Data from the repository");

            Console.WriteLine("appatments.Count():{0}",appatments.Count());

        }
    }
}
