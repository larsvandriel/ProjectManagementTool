using Microsoft.VisualStudio.TestTools.UnitTesting;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace Tests;

[TestClass]
public class Test1
{
    [TestMethod]
    public void TestMethod1()
    {
        Assert.IsTrue(true, "This test always passes.");
    }
}
