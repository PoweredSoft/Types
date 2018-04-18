using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PoweredSoft.Types.Test
{
    [TestClass]
    public class ConvertionTests
    {
        [TestMethod]
        public void StringToGuid()
        {
            var guid = Guid.NewGuid();
            var guidStr = guid.ToString();
            var guid2 = guidStr.To(typeof(Guid));
            Assert.AreEqual(guid, guid2);
        }

        [TestMethod]
        public void StringToDateTime()
        {
            var date = DateTime.Now;
            var dateStr = date.ToString();
            var date2 = (DateTime)dateStr.To(typeof(DateTime));
            Assert.IsTrue(date.Year == date2.Year && date.Month == date2.Month && date.Day == date2.Day);
            Assert.IsTrue(date.Hour == date2.Hour && date.Minute == date2.Minute && date.Second == date2.Second);
        }

        [TestMethod]
        public void StringToGuidNullable()
        {
            Guid? guid = Guid.NewGuid();
            var guidStr = guid.ToString();
            var guid2 = guidStr.To(typeof(Guid?));
            Assert.AreEqual(guid, guid2);
        }

        [TestMethod]
        public void StringToDateNullable()
        {
            DateTime? date = DateTime.Now;
            var dateStr = date.ToString();
            var date2 = (DateTime?)dateStr.To(typeof(DateTime?));
            Assert.IsTrue(date.Value.Year == date2.Value.Year && date.Value.Month == date2.Value.Month && date.Value.Day == date2.Value.Day);
            Assert.IsTrue(date.Value.Hour == date2.Value.Hour && date.Value.Minute == date2.Value.Minute && date.Value.Second == date2.Value.Second);
        }

        [TestMethod]
        public void IntToStr()
        {
            int a = 123;
            var b = a.To(typeof(string));
            Assert.AreEqual("123", b);
        }

        [TestMethod]
        public void StrToInt()
        {
            var a = "123";
            var b = a.To(typeof(int));
            Assert.AreEqual(123, b);

            var a1 = "12345";
            var b1 = a1.To(typeof(int?));
            Assert.AreEqual(12345, b1);
        }
    }
}
