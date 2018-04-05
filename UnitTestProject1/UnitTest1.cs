using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Windows.Forms;
using RandomClickerRacing;
using System.Threading.Tasks;
using System;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CPURacerTest1()
        {
            // Assemble
            TextBox tb = new TextBox();
            tb.Visible = false;

            int benchmarkTB = 1;
            CPURacer cpu = new CPURacer();
            cpu.StartCPU();
            System.Threading.Thread.Sleep(2000);

            // Arrange
            cpu.CPURaceCounter(ref tb, benchmarkTB);

            // Assert
            Assert.IsTrue(tb.Visible);
        }
    }
}
