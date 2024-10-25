using Tyuiu.ShabalinaYP.Sprint3.Task3.V4.Lib;
namespace Tyuiu.ShabalinaYP.Sprint3.Task3.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidDeleteCharInString()
        {
            var ds = new DataService();
            string value = "plkjjdw cvjkl";
            char item = 'j';
            string answer = ds.DeleteCharInString(value, item);
            string wait = "plkdw cvkl";
            Assert.AreEqual(wait, answer);
        }
    }
}