using StudentServiceLib;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MyTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Score8_Should_ReturnA()
        {
            Student s = new Student();
            s.Id = 1;
            s.Name = "Toan";
            s.Age = 30;
            s.Score = 8;

            char letter = s.getLetterScore();
            Assert.AreEqual('A', letter);
        }

        [TestMethod]
        public void Score7_Should_ReturnB()
        {
            Student s = new Student();
            s.Id = 2;
            s.Name = "Thang";
            s.Age = 29;
            s.Score = 7;

            char letter = s.getLetterScore();
            Assert.AreEqual('B', letter);
        }
        [TestMethod]
        public void Score5_Should_ReturnC()
        {
            Student s = new Student();
            s.Id = 3;
            s.Name = "Loc";
            s.Age = 22;
            s.Score = 5;

            char letter = s.getLetterScore();
            Assert.AreEqual('C', letter);
        }
        [TestMethod]
        public void Score3_Should_ReturnE()
        {
            Student s = new Student();
            s.Id = 4;
            s.Name = "Hung";
            s.Age = 27;
            s.Score = 3;

            char letter = s.getLetterScore();
            Assert.AreEqual('E', letter);
        }
    }
}