using System;

namespace NUnit.Tests1
{
    using Framework;
    [TestFixture]
    public class AxeTest
    {
        [Test]
        public void AxeLosesDurabilityAfterAttack()
        {
            var axe = new Axe(10, 10);
            var dummy = new Dummy(10, 10);

            axe.Attack(dummy);

            Assert.AreEqual(9, axe.DurabilityPoints);
        }
        [Test]
        public void AttackWithBerokenTest()
        {
            var axe = new Axe(1, 1);
            var dummy = new Dummy(10, 10);

            axe.Attack(dummy);

            var ex = Assert.Throws<InvalidOperationException>(() => axe.Attack(dummy));
            Assert.AreEqual("Axe is broken.", ex.Message);
        }
    }
}