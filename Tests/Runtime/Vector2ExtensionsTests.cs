using NUnit.Framework;
using UnityEngine;

namespace SweetAlgy.Extensions.Tests.Runtime
{
    [TestFixture]
    public sealed class Vector2ExtensionsTests
    {
        [Test]
        public void AddX_ShouldAddValueToX()
        {
            const float xToAdd = 3.0f;
            Vector2 original = new(1.0f, 2.0f);
            Vector2 result = original.AddX(xToAdd);

            Assert.AreEqual(original.x + xToAdd, result.x);
            Assert.AreEqual(original.y, result.y);
        }

        [Test]
        public void AddY_ShouldAddValueToY()
        {
            const float yToAdd = 3.0f;
            Vector2 original = new(1.0f, 2.0f);
            Vector2 result = original.AddY(yToAdd);

            Assert.AreEqual(original.x, result.x);
            Assert.AreEqual(original.y + yToAdd, result.y);
        }

        [Test]
        public void SubtractX_ShouldSubtractValueFromX()
        {
            const float xToSubtract = 3.0f;
            Vector2 original = new(5.0f, 2.0f);
            Vector2 result = original.SubtractX(xToSubtract);

            Assert.AreEqual(original.x - xToSubtract, result.x);
            Assert.AreEqual(original.y, result.y);
        }

        [Test]
        public void SubtractY_ShouldSubtractValueFromY()
        {
            const float yToSubtract = 2.0f;
            Vector2 original = new(1.0f, 5.0f);
            Vector2 result = original.SubtractY(yToSubtract);

            Assert.AreEqual(original.x, result.x);
            Assert.AreEqual(original.y - yToSubtract, result.y);
        }

        [Test]
        public void MultiplyX_ShouldMultiplyValueToX()
        {
            const float xToMultiply = 3.0f;
            Vector2 original = new(1.0f, 2.0f);
            Vector2 result = original.MultiplyX(xToMultiply);

            Assert.AreEqual(original.x * xToMultiply, result.x);
            Assert.AreEqual(original.y, result.y);
        }

        [Test]
        public void MultiplyY_ShouldMultiplyValueToY()
        {
            const float yToMultiply = 3.0f;
            Vector2 original = new(1.0f, 2.0f);
            Vector2 result = original.MultiplyY(yToMultiply);

            Assert.AreEqual(original.x, result.x);
            Assert.AreEqual(original.y * yToMultiply, result.y);
        }

        [Test]
        public void DivideX_ShouldDivideValueToX()
        {
            const float xToDivide = 3.0f;
            Vector2 original = new(1.0f, 2.0f);
            Vector2 result = original.DivideX(xToDivide);

            Assert.AreEqual(original.x / xToDivide, result.x);
            Assert.AreEqual(original.y, result.y);
        }

        [Test]
        public void DivideY_ShouldDivideValueToY()
        {
            const float yToDivide = 3.0f;
            Vector2 original = new(1.0f, 2.0f);
            Vector2 result = original.DivideY(yToDivide);

            Assert.AreEqual(original.x, result.x);
            Assert.AreEqual(original.y / yToDivide, result.y);
        }

        [Test]
        public void Clone_ShouldReturnExactCopy()
        {
            Vector2 original = new(1.0f, 2.0f);
            Vector2 result = original.Clone();

            Assert.AreEqual(original.x, result.x);
            Assert.AreEqual(original.y, result.y);
        }

        [Test]
        public void WithX_ShouldReplaceXComponent()
        {
            const float newX = 10.0f;
            Vector2 original = new(1.0f, 2.0f);
            Vector2 result = original.WithX(newX);

            Assert.AreEqual(newX, result.x);
            Assert.AreEqual(original.y, result.y);
        }

        [Test]
        public void WithY_ShouldReplaceYComponent()
        {
            const float newY = 10.0f;
            Vector2 original = new(1.0f, 2.0f);
            Vector2 result = original.WithY(newY);

            Assert.AreEqual(original.x, result.x);
            Assert.AreEqual(newY, result.y);
        }

        [Test]
        public void ToVector3XY_ShouldIncludeOptionalZValue()
        {
            const float optionalZ = 5.0f;
            Vector2 original = new(1.0f, 2.0f);
            Vector3 result = original.ToVector3XY(optionalZ);

            Assert.AreEqual(original.x, result.x);
            Assert.AreEqual(original.y, result.y);
            Assert.AreEqual(optionalZ, result.z);
        }

        [Test]
        public void ToVector3XZ_ShouldIncludeOptionalYValue()
        {
            const float optionalY = 7.0f;
            Vector2 original = new(1.0f, 2.0f);
            Vector3 result = original.ToVector3XZ(optionalY);

            Assert.AreEqual(original.x, result.x);
            Assert.AreEqual(optionalY, result.y);
            Assert.AreEqual(original.y, result.z);
        }

        [Test]
        public void ToVector3IntXY_ShouldTruncateValues()
        {
            const int zValue = 3;
            Vector2 original = new(1.5f, 2.9f);
            Vector3Int result = original.ToVector3IntXY(zValue);

            Assert.AreEqual((int)original.x, result.x);
            Assert.AreEqual((int)original.y, result.y);
            Assert.AreEqual(zValue, result.z);
        }

        [Test]
        public void ToVector3IntXZ_ShouldTruncateValuesWithOptionalY()
        {
            const int yValue = 4;
            Vector2 original = new(1.7f, 2.3f);
            Vector3Int result = original.ToVector3IntXZ(yValue);

            Assert.AreEqual((int)original.x, result.x);
            Assert.AreEqual(yValue, result.y);
            Assert.AreEqual((int)original.y, result.z);
        }

        [Test]
        public void FloorToIntXY_ShouldFloorComponents()
        {
            const int zValue = 3;
            Vector2 original = new(1.8f, 2.9f);
            Vector3Int result = original.FloorToIntXY(zValue);

            Assert.AreEqual(Mathf.FloorToInt(original.x), result.x);
            Assert.AreEqual(Mathf.FloorToInt(original.y), result.y);
            Assert.AreEqual(zValue, result.z);
        }

        [Test]
        public void FloorToIntXZ_ShouldFloorComponentsWithOptionalY()
        {
            const int yValue = 5;
            Vector2 original = new(2.6f, 3.4f);
            Vector3Int result = original.FloorToIntXZ(yValue);

            Assert.AreEqual(Mathf.FloorToInt(original.x), result.x);
            Assert.AreEqual(yValue, result.y);
            Assert.AreEqual(Mathf.FloorToInt(original.y), result.z);
        }

        [Test]
        public void CeilToIntXY_ShouldCeilComponents()
        {
            const int zValue = 4;
            Vector2 original = new(1.1f, 2.2f);
            Vector3Int result = original.CeilToIntXY(zValue);

            Assert.AreEqual(Mathf.CeilToInt(original.x), result.x);
            Assert.AreEqual(Mathf.CeilToInt(original.y), result.y);
            Assert.AreEqual(zValue, result.z);
        }

        [Test]
        public void CeilToIntXZ_ShouldCeilComponentsWithOptionalY()
        {
            const int yValue = 6;
            Vector2 original = new(1.3f, 2.8f);
            Vector3Int result = original.CeilToIntXZ(yValue);

            Assert.AreEqual(Mathf.CeilToInt(original.x), result.x);
            Assert.AreEqual(yValue, result.y);
            Assert.AreEqual(Mathf.CeilToInt(original.y), result.z);
        }

        [Test]
        public void RoundToIntXY_ShouldRoundComponents()
        {
            const int zValue = 7;
            Vector2 original = new(1.5f, 2.3f);
            Vector3Int result = original.RoundToIntXY(zValue);

            Assert.AreEqual(Mathf.RoundToInt(original.x), result.x);
            Assert.AreEqual(Mathf.RoundToInt(original.y), result.y);
            Assert.AreEqual(zValue, result.z);
        }

        [Test]
        public void RoundToIntXZ_ShouldRoundComponentsWithOptionalY()
        {
            const int yValue = 8;
            Vector2 original = new(1.4f, 2.6f);
            Vector3Int result = original.RoundToIntXZ(yValue);

            Assert.AreEqual(Mathf.RoundToInt(original.x), result.x);
            Assert.AreEqual(yValue, result.y);
            Assert.AreEqual(Mathf.RoundToInt(original.y), result.z);
        }
    }
}