using Microsoft.VisualStudio.TestTools.UnitTesting;
using lesson4.Name;

namespace Tests
{
    [TestClass]
    public class FullNameTest
    {
        [TestMethod]
        public void GetFullName()
        {
            FullName n1 = new FullName("A","B","C");
            Assert.AreEqual("A C B", n1.GetName());
            //Assert.AreEqual("A B C", n1.GetName());
        }

        [TestMethod]
        public void GetFullNameInit()
        {
            string nullPatronimic = null;
            Assert.ThrowsException<NamePartNullException>(() => {
                _ = new FullName(firstname: "A", lastname: "B", nullPatronimic);
            });
        }
    }
}
