using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections;
using UnitTestProject1;
using Moq;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        //[TestMethod]
        //[DataRow(10,0)]
        //[DataRow(5, 6)]
        //[DataRow(1, 10)]
        //public void TestMethod1(int i ,int j)
        //{
        //    //int i = 5, j = 6;
        //    int result = 11;
        //    int output = new Class1().AddNumber(i, j, new Class1().SetHashtable());
        //    Assert.AreEqual(result, output);
        //    //var flag = false;
        //    //Assert.IsFalse(flag, $"{i} should not be true");
        //}

        [TestMethod]
        public void TestMethod2()
        {
            var c = new Class1();
            PrivateObject privBase = new PrivateObject(c, new PrivateType(typeof(Class1)));
            int i = 5, j = 6;
            int result = 30;
            int output = new Class1().AddNumber(i, j, (Hashtable)privBase.Invoke("SetHashtable"));

            var mock = new Mock<IFoo>();
            // lazy evaluating return value
            var count = 1;
            mock.Setup(foo => foo.GetCount()).Returns(() => count);
            result += mock.Object.GetCount();
            Assert.AreEqual(result, output);
        }
    }
}
