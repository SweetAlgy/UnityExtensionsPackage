using UnityEngine;
using NUnit.Framework;

namespace SweetAlgy.Extensions.Tests.Runtime
{
    [TestFixture]
    public sealed class Vector3IntExtensionsTest
    {
        [Test]
        public void AddX_ShouldAddValueToX()
        {
            const int xToAdd = 3;
            Vector3Int original = new(1, 2, 3);
            Vector3Int result = original.AddX(xToAdd);

            Assert.AreEqual(original.x + xToAdd, result.x);
            Assert.AreEqual(original.y, result.y);
            Assert.AreEqual(original.z, result.z);
        }

        [Test]
        public void AddY_ShouldAddValueToY()
        {
            const int yToAdd = 3;
            Vector3Int original = new(1, 2, 3);
            Vector3Int result = original.AddY(yToAdd);

            Assert.AreEqual(original.x, result.x);
            Assert.AreEqual(original.y + yToAdd, result.y);
            Assert.AreEqual(original.z, result.z);
        }

        [Test]
        public void AddZ_ShouldAddValueToZ()
        {
            const int zToAdd = 3;
            Vector3Int original = new(1, 2, 3);
            Vector3Int result = original.AddZ(zToAdd);

            Assert.AreEqual(original.x, result.x);
            Assert.AreEqual(original.y, result.y);
            Assert.AreEqual(original.z + zToAdd, result.z);
        }

        [Test]
        public void SubtractX_ShouldSubtractValueFromX()
        {
            const int xToSubtract = 3;
            Vector3Int original = new(5, 2, 3);
            Vector3Int result = original.SubtractX(xToSubtract);

            Assert.AreEqual(original.x - xToSubtract, result.x);
            Assert.AreEqual(original.y, result.y);
            Assert.AreEqual(original.z, result.z);
        }

        [Test]
        public void SubtractY_ShouldSubtractValueFromY()
        {
            const int yToSubtract = 2;
            Vector3Int original = new(1, 5, 3);
            Vector3Int result = original.SubtractY(yToSubtract);

            Assert.AreEqual(original.x, result.x);
            Assert.AreEqual(original.y - yToSubtract, result.y);
            Assert.AreEqual(original.z, result.z);
        }

        [Test]
        public void SubtractZ_ShouldSubtractValueFromZ()
        {
            const int zToSubtract = 2;
            Vector3Int original = new(1, 2, 5);
            Vector3Int result = original.SubtractZ(zToSubtract);

            Assert.AreEqual(original.x, result.x);
            Assert.AreEqual(original.y, result.y);
            Assert.AreEqual(original.z - zToSubtract, result.z);
        }

        [Test]
        public void MultiplyX_ShouldMultiplyValueToX()
        {
            const int xToMultiply = 3;
            Vector3Int original = new(1, 2, 3);
            Vector3Int result = original.MultiplyX(xToMultiply);

            Assert.AreEqual(original.x * xToMultiply, result.x);
            Assert.AreEqual(original.y, result.y);
            Assert.AreEqual(original.z, result.z);
        }

        [Test]
        public void MultiplyY_ShouldMultiplyValueToY()
        {
            const int yToMultiply = 3;
            Vector3Int original = new(1, 2, 3);
            Vector3Int result = original.MultiplyY(yToMultiply);

            Assert.AreEqual(original.x, result.x);
            Assert.AreEqual(original.y * yToMultiply, result.y);
            Assert.AreEqual(original.z, result.z);
        }
        
        [Test]
        public void MultiplyZ_ShouldMultiplyValueToZ()
        {
            const int zToMultiply = 3;
            Vector3Int original = new(1, 2, 3);
            Vector3Int result = original.MultiplyZ(zToMultiply);

            Assert.AreEqual(original.x, result.x);
            Assert.AreEqual(original.y, result.y);
            Assert.AreEqual(original.z * zToMultiply, result.z);
        }

        [Test]
        public void DivideX_ShouldDivideValueFromX()
        {
            const int xToDivide = 2;
            Vector3Int original = new(6, 3, 2);
            Vector3Int result = original.DivideX(xToDivide);

            Assert.AreEqual(original.x / xToDivide, result.x);
            Assert.AreEqual(original.y, result.y);
            Assert.AreEqual(original.z, result.z);
        }

        [Test]
        public void DivideY_ShouldDivideValueFromY()
        {
            const int yToDivide = 2;
            Vector3Int original = new(6, 4, 3);
            Vector3Int result = original.DivideY(yToDivide);

            Assert.AreEqual(original.x, result.x);
            Assert.AreEqual(original.y / yToDivide, result.y);
            Assert.AreEqual(original.z, result.z);
        }

        [Test]
        public void DivideZ_ShouldDivideValueFromZ()
        {
            const int zToDivide = 2;
            Vector3Int original = new(6, 4, 8);
            Vector3Int result = original.DivideZ(zToDivide);

            Assert.AreEqual(original.x, result.x);
            Assert.AreEqual(original.y, result.y);
            Assert.AreEqual(original.z / zToDivide, result.z);
        }

        [Test]
        public void Clone_ShouldReturnExactCopy()
        {
            Vector3Int original = new(1, 2, 3);
            Vector3Int result = original.Clone();

            Assert.AreEqual(original.x, result.x);
            Assert.AreEqual(original.y, result.y);
            Assert.AreEqual(original.z, result.z);
        }

        [Test]
        public void WithX_ShouldReplaceXComponent()
        {
            const int newX = 10;
            Vector3Int original = new(1, 2, 3);
            Vector3Int result = original.WithX(newX);

            Assert.AreEqual(newX, result.x);
            Assert.AreEqual(original.y, result.y);
            Assert.AreEqual(original.z, result.z);
        }

        [Test]
        public void WithY_ShouldReplaceYComponent()
        {
            const int newY = 10;
            Vector3Int original = new(1, 2, 3);
            Vector3Int result = original.WithY(newY);

            Assert.AreEqual(original.x, result.x);
            Assert.AreEqual(newY, result.y);
            Assert.AreEqual(original.z, result.z);
        }

        [Test]
        public void WithZ_ShouldReplaceZComponent()
        {
            const int newZ = 10;
            Vector3Int original = new(1, 2, 3);
            Vector3Int result = original.WithZ(newZ);

            Assert.AreEqual(original.x, result.x);
            Assert.AreEqual(original.y, result.y);
            Assert.AreEqual(newZ, result.z);
        }

        [Test]
        public void WithXY_ShouldReplaceXAndYComponents()
        {
            const int newX = 10;
            const int newY = 20;

            Vector3Int original = new(1, 2, 3);
            Vector3Int result = original.WithXY(newX, newY);

            Assert.AreEqual(newX, result.x);
            Assert.AreEqual(newY, result.y);
            Assert.AreEqual(original.z, result.z);
        }

        [Test]
        public void WithXZ_ShouldReplaceXAndZComponents()
        {
            const int newX = 10;
            const int newZ = 30;

            Vector3Int original = new(1, 2, 3);
            Vector3Int result = original.WithXZ(newX, newZ);

            Assert.AreEqual(newX, result.x);
            Assert.AreEqual(original.y, result.y);
            Assert.AreEqual(newZ, result.z);
        }

        [Test]
        public void WithYZ_ShouldReplaceYAndZComponents()
        {
            const int newY = 20;
            const int newZ = 30;

            Vector3Int original = new(1, 2, 3);
            Vector3Int result = original.WithYZ(newY, newZ);

            Assert.AreEqual(original.x, result.x);
            Assert.AreEqual(newY, result.y);
            Assert.AreEqual(newZ, result.z);
        }

        [Test]
        public void ToVector2XY_ShouldReturnVector2FromXAndY()
        {
            Vector3Int original = new(1, 2, 3);
            Vector2 result = original.ToVector2XY();

            Assert.AreEqual(original.x, result.x);
            Assert.AreEqual(original.y, result.y);
        }

        [Test]
        public void ToVector2XZ_ShouldReturnVector2FromXAndZ()
        {
            Vector3Int original = new(1, 2, 3);
            Vector2 result = original.ToVector2XZ();

            Assert.AreEqual(original.x, result.x);
            Assert.AreEqual(original.z, result.y);
        }

        [Test]
        public void ToVector2YZ_ShouldReturnVector2FromYAndZ()
        {
            Vector3Int original = new(1, 2, 3);
            Vector2 result = original.ToVector2YZ();

            Assert.AreEqual(original.y, result.x);
            Assert.AreEqual(original.z, result.y);
        }

        [Test]
        public void ToVector2IntXY_ShouldReturnVector2IntFromXAndY()
        {
            Vector3Int original = new(1, 2, 3);
            Vector2Int result = original.ToVector2IntXY();

            Assert.AreEqual(original.x, result.x);
            Assert.AreEqual(original.y, result.y);
        }

        [Test]
        public void ToVector2IntXZ_ShouldReturnVector2IntFromXAndZ()
        {
            Vector3Int original = new(1, 2, 3);
            Vector2Int result = original.ToVector2IntXZ();

            Assert.AreEqual(original.x, result.x);
            Assert.AreEqual(original.z, result.y);
        }

        [Test]
        public void ToVector2IntYZ_ShouldReturnVector2IntFromYAndZ()
        {
            Vector3Int original = new(1, 2, 3);
            Vector2Int result = original.ToVector2IntYZ();

            Assert.AreEqual(original.y, result.x);
            Assert.AreEqual(original.z, result.y);
        }
    }
}