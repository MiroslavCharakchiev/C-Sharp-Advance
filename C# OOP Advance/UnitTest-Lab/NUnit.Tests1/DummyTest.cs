using System;
using System.Runtime.CompilerServices;
using System.Threading;
using NUnit.Framework.Internal;

namespace NUnit.Tests1
{
    using Framework;
    [TestFixture]
    public class DummyTest
    {
        [Test]
        public void DidDummyLoseHealthOnAttack()
        {
            Dummy dummy = new Dummy(10, 10);
            Axe axe = new Axe(5, 5);

            axe.Attack(dummy);

            Assert.AreEqual(5,dummy.Health);
        }

        [Test]
        public void DeadDummyThrowsExeptionIfIsAttacked()
        {

            Dummy dummy = new Dummy(0, 10);
            Axe axe = new Axe(5, 5);

            var ex = Assert.Throws<InvalidOperationException>(() => axe.Attack(dummy));
            Assert.AreEqual("Dummy is dead.", ex.Message);

        }
    }
}