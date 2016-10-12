using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Iterator_Pattern_Employee;
using Iterator_Pattern_Employee.Iterator;
using Iterator_Pattern_Employee.Aggregate;
using System.Collections.Generic;
using System.Linq;

namespace IteratorPatternTest
{
    [TestClass]
    public class IteratorTest
    {
        [TestMethod]
        public void hr_test()
        {
            HR hr = new HR();
            IIterator hrIterator = hr.CreateIterator();
            List<string> fromIterator = new List<string>();
            fromIterator.Add(hrIterator.Next());
            Assert.AreEqual(fromIterator.Count(), 1);
            Assert.AreEqual(hrIterator.IsDone(), false);
            fromIterator.Add(hrIterator.Next());
            Assert.AreEqual(fromIterator.Count(), 2);
            Assert.AreEqual(hrIterator.IsDone(), false);
            fromIterator.Add(hrIterator.Next());
            Assert.AreEqual(fromIterator.Count(), 3);
            Assert.AreEqual(hrIterator.IsDone(), false);
            fromIterator.Add(hrIterator.Next());
            Assert.AreEqual(fromIterator.Count(), 4);
            Assert.AreEqual(hrIterator.IsDone(), true);
           
        }
        [TestMethod]
        public void ict_test()
        {
            ICT ict = new ICT();
            IIterator ictIterator = ict.CreateIterator();
            List<string> fromIterator = new List<string>();
            fromIterator.Add(ictIterator.Next());
            Assert.AreEqual(fromIterator.Count(), 1);
            Assert.AreEqual(ictIterator.IsDone(), false);
            fromIterator.Add(ictIterator.Next());
            Assert.AreEqual(fromIterator.Count(), 2);
            Assert.AreEqual(ictIterator.IsDone(), false);
            fromIterator.Add(ictIterator.Next());
            Assert.AreEqual(fromIterator.Count(), 3);
            Assert.AreEqual(ictIterator.IsDone(), false);
            fromIterator.Add(ictIterator.Next());
            Assert.AreEqual(fromIterator.Count(), 4);
            Assert.AreEqual(ictIterator.IsDone(), true);
        }


        [TestMethod]
        public void management_test()
        {
            Management management = new Management();
            IIterator managementIterator = management.CreateIterator();
            List<string> fromIterator = new List<string>();
            fromIterator.Add(managementIterator.Next());
            Assert.AreEqual(fromIterator.Count(), 1);
            fromIterator.Add(managementIterator.Next());
            Assert.AreEqual(fromIterator.Count(), 2);
            fromIterator.Add(managementIterator.Next());
            Assert.AreEqual(fromIterator.Count(), 3);
            fromIterator.Add(managementIterator.Next());
            Assert.AreEqual(fromIterator.Count(), 4);
            Assert.AreEqual(managementIterator.IsDone(), false);
            fromIterator.Add(managementIterator.Next());
            Assert.AreEqual(fromIterator.Count(), 5);
            Assert.AreEqual(managementIterator.IsDone(), true);

        }
    }
}
