using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using BasicMaths;
namespace BasicMathsTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test_AddMethod()
        {
            BasicMathsOperation bm = new BasicMathsOperation();
                          double res = bm.Add(10, 10);
            Assert.AreEqual(res, 20);
                      }  
	        [TestMethod]  
	    public void Test_SubstractMethod()
        {
            BasicMathsOperation bm = new BasicMathsOperation();
                         double res = bm.Substract(10, 10);
            Assert.AreEqual(res, 0);
                     }  
[TestMethod]  
	    public void Test_DivideMethod()
        {
            BasicMathsOperation bm = new BasicMathsOperation();
                       double res = bm.divide(10, 5);
          Assert.AreEqual(res, 2);
                   }  
     [TestMethod]  
	    public void Test_MultiplyMethod()
        {
            BasicMathsOperation bm = new BasicMathsOperation();
                     double res = bm.Multiply(10, 10);
            Assert.AreEqual(res, 100);
              }

    }
}
