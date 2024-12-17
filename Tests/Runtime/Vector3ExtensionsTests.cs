using UnityEngine;
using NUnit.Framework;

namespace SweetAlgy.Extensions.Tests.Runtime
{
    [TestFixture]
    public sealed class Vector3ExtensionsTests
    {
        [Test]
        public void AddX_ShouldAddValueToX()
        {
            const float xToAdd = 3.0f;
            Vector3 original = new(1.0f, 2.0f, 3.0f);
            Vector3 result = original.AddX(xToAdd);

            Assert.AreEqual(original.x + xToAdd, result.x);
            Assert.AreEqual(original.y, result.y);
            Assert.AreEqual(original.z, result.z);
        }
        
        [Test]
        public void AddY_ShouldAddValueToY()
        {
            const float yToAdd = 3.0f;
            Vector3 original = new(1.0f, 2.0f, 3.0f);
            Vector3 result = original.AddY(yToAdd);

            Assert.AreEqual(original.x, result.x);
            Assert.AreEqual(original.y + yToAdd, result.y);
            Assert.AreEqual(original.z, result.z);
        }

        [Test]
        public void AddZ_ShouldAddValueToZ()
        {
            const float zToAdd = 3.0f;
            Vector3 original = new(1.0f, 2.0f, 3.0f);
            Vector3 result = original.AddZ(zToAdd);

            Assert.AreEqual(original.x, result.x);
            Assert.AreEqual(original.y, result.y);
            Assert.AreEqual(original.z + zToAdd, result.z);
        }
        
        [Test]
        public void SubtractX_ShouldSubtractValueFromX()
        {
            const float xToSubtract = 3.0f;
            Vector3 original = new(5.0f, 2.0f, 3.0f);
            Vector3 result = original.SubtractX(xToSubtract);

            Assert.AreEqual(original.x - xToSubtract, result.x);
            Assert.AreEqual(original.y, result.y);
            Assert.AreEqual(original.z, result.z);
        }

        [Test]
        public void SubtractY_ShouldSubtractValueFromY()
        {
            const float yToSubtract = 2.0f;
            Vector3 original = new(1.0f, 5.0f, 3.0f);
            Vector3 result = original.SubtractY(yToSubtract);

            Assert.AreEqual(original.x, result.x);
            Assert.AreEqual(original.y - yToSubtract, result.y);
            Assert.AreEqual(original.z, result.z);
        }

        [Test]
        public void SubtractZ_ShouldSubtractValueFromZ()
        {
            const float zToSubtract = 2.0f;
            Vector3 original = new(1.0f, 2.0f, 5.0f);
            Vector3 result = original.SubtractZ(zToSubtract);

            Assert.AreEqual(original.x, result.x);
            Assert.AreEqual(original.y, result.y);
            Assert.AreEqual(original.z - zToSubtract, result.z);
        }
        
        [Test]
        public void MultiplyX_ShouldMultiplyValueToX()
        {
            const float xToMultiply = 3.0f;
            Vector3 original = new(1.0f, 2.0f, 3.0f);
            Vector3 result = original.MultiplyX(xToMultiply);

            Assert.AreEqual(original.x * xToMultiply, result.x);
            Assert.AreEqual(original.y, result.y);
            Assert.AreEqual(original.z, result.z);
        }

        [Test]
        public void MultiplyY_ShouldMultiplyValueToY()
        {
            const float yToMultiply = 3.0f;
            Vector3 original = new(1.0f, 2.0f, 3.0f);
            Vector3 result = original.MultiplyY(yToMultiply);

            Assert.AreEqual(original.x, result.x);
            Assert.AreEqual(original.y * yToMultiply, result.y);
            Assert.AreEqual(original.z, result.z);
        }

        [Test]
        public void MultiplyZ_ShouldMultiplyValueToZ()
        {
            const float zToMultiply = 3.0f;
            Vector3 original = new(1.0f, 2.0f, 3.0f);
            Vector3 result = original.MultiplyZ(zToMultiply);

            Assert.AreEqual(original.x, result.x);
            Assert.AreEqual(original.y, result.y);
            Assert.AreEqual(original.z * zToMultiply, result.z);
        }
        
        [Test]
        public void DivideX_ShouldDivideValueToX()
        {
            const float xToDivide = 2.0f;
            Vector3 original = new(6.0f, 3.0f, 2.0f);
            Vector3 result = original.DivideX(xToDivide);

            Assert.AreEqual(original.x / xToDivide, result.x);
            Assert.AreEqual(original.y, result.y);
            Assert.AreEqual(original.z, result.z);
        }

        [Test]
        public void DivideY_ShouldDivideValueToY()
        {
            const float yToDivide = 2.0f;
            Vector3 original = new(6.0f, 4.0f, 3.0f);
            Vector3 result = original.DivideY(yToDivide);

            Assert.AreEqual(original.x, result.x);
            Assert.AreEqual(original.y / yToDivide, result.y);
            Assert.AreEqual(original.z, result.z);
        }

        [Test]
        public void DivideZ_ShouldDivideValueToZ()
        {
            const float zToDivide = 2.0f;
            Vector3 original = new(6.0f, 4.0f, 8.0f);
            Vector3 result = original.DivideZ(zToDivide);

            Assert.AreEqual(original.x, result.x);
            Assert.AreEqual(original.y, result.y);
            Assert.AreEqual(original.z / zToDivide, result.z);
        }
        
        [Test]
        public void Clone_ShouldReturnExactCopy()
        {
            Vector3 original = new(1.0f, 2.0f, 3.0f);
            Vector3 result = original.Clone();

            Assert.AreEqual(original.x, result.x);
            Assert.AreEqual(original.y, result.y);
            Assert.AreEqual(original.z, result.z);
        }
        
        [Test]
        public void WithX_ShouldReplaceXComponent()
        {
            const float newX = 10.0f;
            Vector3 original = new(1.0f, 2.0f, 3.0f);
            Vector3 result = original.WithX(newX);

            Assert.AreEqual(newX, result.x);
            Assert.AreEqual(original.y, result.y);
            Assert.AreEqual(original.z, result.z);
        }
        
        [Test]
        public void WithY_ShouldReplaceYComponent()
        {
            const float newY = 10.0f;
            Vector3 original = new(1.0f, 2.0f, 3.0f);
            Vector3 result = original.WithY(newY);

            Assert.AreEqual(original.x, result.x);
            Assert.AreEqual(newY, result.y);
            Assert.AreEqual(original.z, result.z);
        }
        
        [Test]
        public void WithZ_ShouldReplaceZComponent()
        {
            const float newZ = 10.0f;
            Vector3 original = new(1.0f, 2.0f, 3.0f);
            Vector3 result = original.WithZ(newZ);

            Assert.AreEqual(original.x, result.x);
            Assert.AreEqual(original.y, result.y);
            Assert.AreEqual(newZ, result.z);
        }
        
        [Test]
        public void WithXY_ShouldReplaceXAndYComponents()
        {
            const float newX = 10.0f;
            const float newY = 20.0f;

            Vector3 original = new(1.0f, 2.0f, 3.0f);
            Vector3 result = original.WithXY(newX, newY);

            Assert.AreEqual(newX, result.x);
            Assert.AreEqual(newY, result.y);
            Assert.AreEqual(original.z, result.z);
        }

        [Test]
        public void WithXZ_ShouldReplaceXAndZComponents()
        {
            const float newX = 10.0f;
            const float newZ = 30.0f;

            Vector3 original = new(1.0f, 2.0f, 3.0f);
            Vector3 result = original.WithXZ(newX, newZ);

            Assert.AreEqual(newX, result.x);
            Assert.AreEqual(original.y, result.y);
            Assert.AreEqual(newZ, result.z);
        }

        [Test]
        public void WithYZ_ShouldReplaceYAndZComponents()
        {
            const float newY = 20.0f;
            const float newZ = 30.0f;

            Vector3 original = new(1.0f, 2.0f, 3.0f);
            Vector3 result = original.WithYZ(newY, newZ);

            Assert.AreEqual(original.x, result.x);
            Assert.AreEqual(newY, result.y);
            Assert.AreEqual(newZ, result.z);
        }

        [Test]
        public void ToVector2XY_ShouldReturnVector2FromXAndY()
        {
            Vector3 original = new(1.0f, 2.0f, 3.0f);
            Vector2 result = original.ToVector2XY();

            Assert.AreEqual(original.x, result.x);
            Assert.AreEqual(original.y, result.y);
        }

        [Test]
        public void ToVector2XZ_ShouldReturnVector2FromXAndZ()
        {
            Vector3 original = new(1.0f, 2.0f, 3.0f);
            Vector2 result = original.ToVector2XZ();

            Assert.AreEqual(original.x, result.x);
            Assert.AreEqual(original.z, result.y);
        }

        [Test]
        public void ToVector2YZ_ShouldReturnVector2FromYAndZ()
        {
            Vector3 original = new(1.0f, 2.0f, 3.0f);
            Vector2 result = original.ToVector2YZ();

            Assert.AreEqual(original.y, result.x);
            Assert.AreEqual(original.z, result.y);
        }

        [Test]
        public void FloorToInt_ShouldReturnFlooredVector3Int()
        {
            Vector3 original = new(1.7f, 2.8f, 3.9f);
            Vector3Int result = original.FloorToInt();

            Assert.AreEqual(Mathf.FloorToInt(original.x), result.x);
            Assert.AreEqual(Mathf.FloorToInt(original.y), result.y);
            Assert.AreEqual(Mathf.FloorToInt(original.z), result.z);
        }

        [Test]
        public void CeilToInt_ShouldReturnCeiledVector3Int()
        {
            Vector3 original = new(1.2f, 2.3f, 3.4f);
            Vector3Int result = original.CeilToInt();

            Assert.AreEqual(Mathf.CeilToInt(original.x), result.x);
            Assert.AreEqual(Mathf.CeilToInt(original.y), result.y);
            Assert.AreEqual(Mathf.CeilToInt(original.z), result.z);
        }

        [Test]
        public void RoundToInt_ShouldReturnRoundedVector3Int()
        {
            Vector3 original = new(1.5f, 2.3f, 3.8f);
            Vector3Int result = original.RoundToInt();

            Assert.AreEqual(Mathf.RoundToInt(original.x), result.x);
            Assert.AreEqual(Mathf.RoundToInt(original.y), result.y);
            Assert.AreEqual(Mathf.RoundToInt(original.z), result.z);
        }

        [Test]
        public void FloorToIntXY_ShouldFloorXAndYToVector2Int()
        {
            Vector3 original = new(1.8f, 2.9f, 3.1f);
            Vector2Int result = original.FloorToIntXY();

            Assert.AreEqual(Mathf.FloorToInt(original.x), result.x);
            Assert.AreEqual(Mathf.FloorToInt(original.y), result.y);
        }

        [Test]
        public void FloorToIntXZ_ShouldFloorXAndZToVector2Int()
        {
            Vector3 original = new(4.6f, 2.2f, 6.3f);
            Vector2Int result = original.FloorToIntXZ();

            Assert.AreEqual(Mathf.FloorToInt(original.x), result.x);
            Assert.AreEqual(Mathf.FloorToInt(original.z), result.y);
        }

        [Test]
        public void FloorToIntYZ_ShouldFloorYAndZToVector2Int()
        {
            Vector3 original = new(3.1f, 5.7f, 7.8f);
            Vector2Int result = original.FloorToIntYZ();

            Assert.AreEqual(Mathf.FloorToInt(original.y), result.x);
            Assert.AreEqual(Mathf.FloorToInt(original.z), result.y);
        }

        [Test]
        public void CeilToIntXY_ShouldCeilXAndYToVector2Int()
        {
            Vector3 original = new(1.3f, 2.2f, 3.7f);
            Vector2Int result = original.CeilToIntXY();

            Assert.AreEqual(Mathf.CeilToInt(original.x), result.x);
            Assert.AreEqual(Mathf.CeilToInt(original.y), result.y);
        }

        [Test]
        public void CeilToIntXZ_ShouldCeilXAndZToVector2Int()
        {
            Vector3 original = new(4.4f, 2.1f, 6.8f);
            Vector2Int result = original.CeilToIntXZ();

            Assert.AreEqual(Mathf.CeilToInt(original.x), result.x);
            Assert.AreEqual(Mathf.CeilToInt(original.z), result.y);
        }

        [Test]
        public void CeilToIntYZ_ShouldCeilYAndZToVector2Int()
        {
            Vector3 original = new(3.5f, 5.2f, 7.6f);
            Vector2Int result = original.CeilToIntYZ();

            Assert.AreEqual(Mathf.CeilToInt(original.y), result.x);
            Assert.AreEqual(Mathf.CeilToInt(original.z), result.y);
        }

        [Test]
        public void RoundToIntXY_ShouldRoundXAndYToVector2Int()
        {
            Vector3 original = new(1.4f, 2.6f, 3.0f);
            Vector2Int result = original.RoundToIntXY();

            Assert.AreEqual(Mathf.RoundToInt(original.x), result.x);
            Assert.AreEqual(Mathf.RoundToInt(original.y), result.y);
        }

        [Test]
        public void RoundToIntXZ_ShouldRoundXAndZToVector2Int()
        {
            Vector3 original = new(4.5f, 2.7f, 6.3f);
            Vector2Int result = original.RoundToIntXZ();

            Assert.AreEqual(Mathf.RoundToInt(original.x), result.x);
            Assert.AreEqual(Mathf.RoundToInt(original.z), result.y);
        }

        [Test]
        public void RoundToIntYZ_ShouldRoundYAndZToVector2Int()
        {
            Vector3 original = new(3.2f, 5.4f, 7.9f);
            Vector2Int result = original.RoundToIntYZ();

            Assert.AreEqual(Mathf.RoundToInt(original.y), result.x);
            Assert.AreEqual(Mathf.RoundToInt(original.z), result.y);
        }
    }
}