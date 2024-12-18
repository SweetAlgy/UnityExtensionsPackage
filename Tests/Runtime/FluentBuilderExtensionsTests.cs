using NUnit.Framework;

namespace SweetAlgy.Extensions.Tests.Runtime
{
    [TestFixture]
    public sealed class FluentBuilderExtensionsTests
    {
        private sealed class DummyObject
        {
            public int Value { get; set; }

            public DummyObject(int value)
            {
                this.Value = value;
            }
        }

        [Test]
        public void Do_ShouldApplyAction()
        {
            const int expectedValue = 20;
            const int initialValue = 10;
            DummyObject obj = new(initialValue);
            DummyObject result = obj.Do(o => o.Value = expectedValue);

            Assert.AreEqual(expectedValue, result.Value);
            Assert.AreSame(obj, result);
        }

        [Test]
        public void Do_ShouldDoNothing_WhenActionIsNull()
        {
            const int initialValue = 10;
            DummyObject obj = new(initialValue);
            DummyObject result = obj.Do(null);

            Assert.AreEqual(initialValue, obj.Value);
            Assert.AreSame(obj, result);
        }

        [Test]
        public void If_WithConditionTrue_ShouldApplyAction()
        {
            const int initialValue = 10;
            const int expectedValue = 20;
            DummyObject obj = new(initialValue);
            DummyObject result = obj.If(true, o => o.Value = expectedValue);

            Assert.AreEqual(expectedValue, result.Value);
            Assert.AreSame(obj, result);
        }

        [Test]
        public void If_WithConditionFalse_ShouldNotApplyAction()
        {
            const int initialValue = 10;
            const int newValue = 20; // This value should NOT be applied
            DummyObject obj = new(initialValue);
            DummyObject result = obj.If(false, o => o.Value = newValue);

            Assert.AreEqual(initialValue, result.Value);
            Assert.AreSame(obj, result);
        }

        [Test]
        public void If_WithFuncConditionTrue_ShouldApplyAction()
        {
            const int initialValue = 10;
            const int expectedValue = 20;
            DummyObject obj = new(initialValue);
            DummyObject result = obj.If(() => true, o => o.Value = expectedValue);

            Assert.AreEqual(expectedValue, result.Value);
            Assert.AreSame(obj, result);
        }

        [Test]
        public void If_WithFuncConditionFalse_ShouldNotApplyAction()
        {
            const int initialValue = 10;
            const int newValue = 20; // This value should NOT be applied
            DummyObject obj = new(initialValue);
            DummyObject result = obj.If(() => false, o => o.Value = newValue);

            Assert.AreEqual(initialValue, result.Value);
            Assert.AreSame(obj, result);
        }

        [Test]
        public void If_WithObjectBasedConditionTrue_ShouldApplyAction()
        {
            const int initialValue = 10;
            const int expectedValue = 20;
            DummyObject obj = new(initialValue);
            DummyObject result = obj.If(o => o.Value == initialValue, o => o.Value = expectedValue);

            Assert.AreEqual(expectedValue, result.Value);
            Assert.AreSame(obj, result);
        }

        [Test]
        public void If_WithObjectBasedConditionFalse_ShouldNotApplyAction()
        {
            const int initialValue = 10;
            const int newValue = 20; // This value should NOT be applied
            DummyObject obj = new(initialValue);
            DummyObject result = obj.If(o => o.Value != initialValue, o => o.Value = newValue);

            Assert.AreEqual(initialValue, result.Value);
            Assert.AreSame(obj, result);
        }

        [Test]
        public void IfNull_ShouldInvokeAction_WhenObjectIsNull()
        {
            bool actionInvoked = false;
            ((DummyObject)null).IfNull(() => actionInvoked = true);

            Assert.IsTrue(actionInvoked);
        }

        [Test]
        public void IfNull_ShouldNotInvokeAction_WhenObjectIsNotNull()
        {
            const int initialValue = 10;
            bool actionInvoked = false;
            new DummyObject(initialValue).IfNull(() => actionInvoked = true);

            Assert.IsFalse(actionInvoked);
        }

        [Test]
        public void IfNotNull_ShouldInvokeAction_WhenObjectIsNotNull()
        {
            const int initialValue = 10;
            bool actionInvoked = false;
            new DummyObject(initialValue).IfNotNull(_ => actionInvoked = true);

            Assert.IsTrue(actionInvoked);
        }

        [Test]
        public void IfNotNull_ShouldNotInvokeAction_WhenObjectIsNull()
        {
            bool actionInvoked = false;
            ((DummyObject)null).IfNotNull(o => actionInvoked = true);

            Assert.IsFalse(actionInvoked);
        }

        [Test]
        public void WithDefault_ShouldReturnObject_WhenObjectIsNotNull()
        {
            const int initialValue = 10;
            const int defaultValue = 20;
            DummyObject obj = new(initialValue);
            DummyObject result = obj.WithDefault(() => new(defaultValue));

            Assert.AreSame(obj, result);
            Assert.AreEqual(initialValue, result.Value);
        }

        [Test]
        public void WithDefault_ShouldReturnDefault_WhenObjectIsNull()
        {
            const int defaultValue = 20;
            DummyObject result = ((DummyObject)null).WithDefault(() => new(defaultValue));

            Assert.IsNotNull(result);
            Assert.AreEqual(defaultValue, result.Value);
        }
    }
}