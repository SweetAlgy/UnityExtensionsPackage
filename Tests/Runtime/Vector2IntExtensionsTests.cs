using NUnit.Framework;
using UnityEngine;

namespace SweetAlgy.Extensions.Tests.Runtime
{
    [TestFixture]
    public sealed class Vector2IntExtensionsTests
    {
        [Test]
        public void AddX_ShouldAddValueToX()
        {
            const int xToAdd = 3;
            Vector2Int original = new(1, 2);
            Vector2Int result = original.AddX(xToAdd);

            Assert.AreEqual(original.x + xToAdd, result.x);
            Assert.AreEqual(original.y, result.y);
        }

        [Test]
        public void AddY_ShouldAddValueToY()
        {
            const int yToAdd = 3;
            Vector2Int original = new(1, 2);
            Vector2Int result = original.AddY(yToAdd);

            Assert.AreEqual(original.x, result.x);
            Assert.AreEqual(original.y + yToAdd, result.y);
        }

        [Test]
        public void SubtractX_ShouldSubtractValueFromX()
        {
            const int xToSubtract = 3;
            Vector2Int original = new(5, 2);
            Vector2Int result = original.SubtractX(xToSubtract);

            Assert.AreEqual(original.x - xToSubtract, result.x);
            Assert.AreEqual(original.y, result.y);
        }

        [Test]
        public void SubtractY_ShouldSubtractValueFromY()
        {
            const int yToSubtract = 2;
            Vector2Int original = new(1, 5);
            Vector2Int result = original.SubtractY(yToSubtract);

            Assert.AreEqual(original.x, result.x);
            Assert.AreEqual(original.y - yToSubtract, result.y);
        }

        [Test]
        public void MultiplyX_ShouldMultiplyValueToX()
        {
            const int xToMultiply = 3;
            Vector2Int original = new(1, 2);
            Vector2Int result = original.MultiplyX(xToMultiply);

            Assert.AreEqual(original.x * xToMultiply, result.x);
            Assert.AreEqual(original.y, result.y);
        }

        [Test]
        public void MultiplyY_ShouldMultiplyValueToY()
        {
            const int yToMultiply = 3;
            Vector2Int original = new(1, 2);
            Vector2Int result = original.MultiplyY(yToMultiply);

            Assert.AreEqual(original.x, result.x);
            Assert.AreEqual(original.y * yToMultiply, result.y);
        }

        [Test]
        public void DivideX_ShouldDivideValueToX()
        {
            const int xToDivide = 2;
            Vector2Int original = new(4, 2);
            Vector2Int result = original.DivideX(xToDivide);

            Assert.AreEqual(original.x / xToDivide, result.x);
            Assert.AreEqual(original.y, result.y);
        }

        [Test]
        public void DivideY_ShouldDivideValueToY()
        {
            const int yToDivide = 2;
            Vector2Int original = new(4, 6);
            Vector2Int result = original.DivideY(yToDivide);

            Assert.AreEqual(original.x, result.x);
            Assert.AreEqual(original.y / yToDivide, result.y);
        }

        [Test]
        public void Clone_ShouldReturnExactCopy()
        {
            Vector2Int original = new(1, 2);
            Vector2Int result = original.Clone();

            Assert.AreEqual(original.x, result.x);
            Assert.AreEqual(original.y, result.y);
        }

        [Test]
        public void WithX_ShouldReplaceXComponent()
        {
            const int newX = 10;
            Vector2Int original = new(1, 2);
            Vector2Int result = original.WithX(newX);

            Assert.AreEqual(newX, result.x);
            Assert.AreEqual(original.y, result.y);
        }

        [Test]
        public void WithY_ShouldReplaceYComponent()
        {
            const int newY = 10;
            Vector2Int original = new(1, 2);
            Vector2Int result = original.WithY(newY);

            Assert.AreEqual(original.x, result.x);
            Assert.AreEqual(newY, result.y);
        }

        [Test]
        public void ToVector3XY_ShouldIncludeOptionalZValue()
        {
            const float optionalZ = 5.0f;
            Vector2Int original = new(1, 2);
            Vector3 result = original.ToVector3XY(optionalZ);

            Assert.AreEqual(original.x, result.x);
            Assert.AreEqual(original.y, result.y);
            Assert.AreEqual(optionalZ, result.z);
        }

        [Test]
        public void ToVector3XZ_ShouldIncludeOptionalYValue()
        {
            const float optionalY = 7.0f;
            Vector2Int original = new(1, 2);
            Vector3 result = original.ToVector3XZ(optionalY);

            Assert.AreEqual(original.x, result.x);
            Assert.AreEqual(optionalY, result.y);
            Assert.AreEqual(original.y, result.z);
        }

        [Test]
        public void ToVector3IntXY_ShouldIncludeOptionalZValue()
        {
            const int zValue = 3;
            Vector2Int original = new(1, 2);
            Vector3Int result = original.ToVector3IntXY(zValue);

            Assert.AreEqual(original.x, result.x);
            Assert.AreEqual(original.y, result.y);
            Assert.AreEqual(zValue, result.z);
        }

        [Test]
        public void ToVector3IntXZ_ShouldIncludeOptionalYValue()
        {
            const int yValue = 4;
            Vector2Int original = new(1, 2);
            Vector3Int result = original.ToVector3IntXZ(yValue);

            Assert.AreEqual(original.x, result.x);
            Assert.AreEqual(yValue, result.y);
            Assert.AreEqual(original.y, result.z);
        }
    }
}