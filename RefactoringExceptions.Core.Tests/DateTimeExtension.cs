using NUnit.Framework;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RefactoringExceptions.Core;

namespace RefactoringExceptions.Core.Tests
{
    [TestFixture]
    public class DateTimeExtension
    {
        [Test]
        public void IsBefore_returns_true_if_the_first_date_is_before_the_second_date()
        {
            DateTime dateTime1 = new DateTime(1111,01,01);
            DateTime dateTime2 = new DateTime(2222,01,01);

            Assert.AreEqual(true, dateTime1.IsBefore(dateTime2));            
        }

        [Test]
        public void IsBefore_returns_false_if_the_first_date_is_after_the_second_date()
        {
            DateTime dateTime1 = new DateTime(2222, 01, 01);
            DateTime dateTime2 = new DateTime(1111, 01, 01);

            Assert.AreEqual(false, dateTime1.IsBefore(dateTime2));
        }

        [Test]        
        public void IsBefore_returns_false_if_the_first_date_is_equal_the_second_date()
        {
            DateTime dateTime1 = new DateTime(1111, 01, 01);
            DateTime dateTime2 = new DateTime(1111, 01, 01);

            Assert.AreEqual(false, dateTime1.IsBefore(dateTime2));
        }
    }
}
