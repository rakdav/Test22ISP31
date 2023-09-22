namespace MyTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethodFactorial()
        {
            MyMath my= new MyMath();
            Assert.AreEqual(my.Factorial(0), 1);
            Assert.AreEqual(my.Factorial(1), 1);
            Assert.AreEqual(my.Factorial(2), 2);
            Assert.AreEqual(my.Factorial(3), 6);
            Assert.AreEqual(my.Factorial(4), 24);
            Assert.AreEqual(my.Factorial(5), 120);

        }
        [TestMethod]
        public void TestMethodSum()
        {
            MyMath my = new MyMath();
            Assert.AreEqual(my.Sum(1,0), 1);
            Assert.AreEqual(my.Sum(0, 1), 1);
            Assert.AreEqual(my.Sum(1, 1), 2);
            Assert.AreEqual(my.Sum(1, 2), 3);
            Assert.AreEqual(my.Sum(2,1), 3);
            Assert.AreEqual(my.Sum(3, 0), 3);
        }
    }
}